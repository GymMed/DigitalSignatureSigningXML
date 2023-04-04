using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSignatureSigningXML.Forms
{
    public partial class DigitalSignerForm : Form
    {
        private CertificatePanelsManager certificateManager;

        public DigitalSignerForm()
        {
            InitializeComponent();

            List<Panel> certificatePanels = new List<Panel>();

            certificatePanels.Add(this.SelectMSCertificatePanel);// CertificatePanels.ChooseFromMicrosoftStore
            certificatePanels.Add(this.CertificateTypeInLocationPanel);// CertificatePanels.TypeInPFXLocation

            certificateManager = new CertificatePanelsManager(certificatePanels);
        }

        private void SourceSearchButton_Click(object sender, EventArgs e)
        {
            if (this.MultipleSignChoiceRadio.Checked)
            {
                MainNavigationForm.SelectDirectoryPath(SourceTextBox, "Pasirinkite nepasirašytų dokumentų lokacija");
            }
            else
            {
                MainNavigationForm.SelectFilePath(SourceTextBox, ApplicationFileFormats.XML);
            }
        }

        private void DestinationSearchButton_Click(object sender, EventArgs e)
        {
            MainNavigationForm.SelectDirectoryPath(SignedDestinationTextBox, "Pasirinkite pasirašytų dokumentų talpinimo lokacija");
            ValidateSignedDestinationLocationAndPrint();
        }

        private void CertificateSearchButton_Click(object sender, EventArgs e)
        {
            MainNavigationForm.SelectFilePath(CertificateLocationTextBox, ApplicationFileFormats.PFX);
        }

        private void CertificateShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CertificateShowPasswordCheckBox.Checked)
                CertificatePasswordTextBox.UseSystemPasswordChar = false;
            else
                CertificatePasswordTextBox.UseSystemPasswordChar = true;
        }

        private void SourceTextBox_TextChanged(object sender, EventArgs e)
        {
            CertificatePanelsManager.ValidateSourceLocationAndPrint(this.SourceTextBox, this.SourceValidationLabel);
        }

        private void SignedDestinationTextBox_Leave(object sender, EventArgs e)
        {
            ValidateSignedDestinationLocationAndPrint();
        }

        private void CertificateLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            CertificatePanelsManager.ValidateCertificateLocationAndPrint(this.CertificateLocationTextBox, this.CertificateValidationLabel, ApplicationFileFormats.PFX);
        }

        public void ValidateSignedDestinationLocationAndPrint()
        {
            PathValidator.DestinationLocation = this.SignedDestinationTextBox.Text;
            SuccessReport report = PathValidator.ValidateDestinationLocation();
            CertificatePanelsManager.PrintMessage(this.DestinationValidationLabel, report);
        }

        private void MultipleSignChoiceRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (this.MultipleSignChoiceRadio.Checked)
            {
                PathValidator.IsSingleXMLDocument = false;
            }
            else
            {
                PathValidator.IsSingleXMLDocument = true;
            }

            CertificatePanelsManager.ValidateSourceLocationAndPrint(this.SourceTextBox, this.SourceValidationLabel);
        }

        private void ApplyDigitalSignatureButton_Click(object sender, EventArgs e)
        {
            bool multipleSigning = this.MultipleSignChoiceRadio.Checked;

            string sourceLocationPath = this.SourceTextBox.Text;
            string destinationLocationPath = this.SignedDestinationTextBox.Text;
            string certificateLocationPath = this.CertificateLocationTextBox.Text;

            if (multipleSigning)
            {
                PathValidator.IsSingleXMLDocument = false;
            }
            else
            {
                PathValidator.IsSingleXMLDocument = true;
            }

            PathValidator.SourceLocation = sourceLocationPath;
            PathValidator.DestinationLocation = destinationLocationPath;

            if (this.certificateManager.GetCurrentPanelIndex() == (int)CertificatePanelsManager.CertificatePanels.TypeInCertificateLocation)
            {
                PathValidator.CertificateLocation = certificateLocationPath;
                PathValidator.ValidateAllPaths(ApplicationFileFormats.PFX);

                CheckReportsAndStartSigningDocuments(sourceLocationPath, destinationLocationPath, multipleSigning,
                    certificateLocationPath, this.CertificatePasswordTextBox.Text, true);
            }
            else
            {
                PathValidator.ValidatePaths();

                if (ReportsManager.CertificateSelectionReport.Message == null)
                {
                    ReportsManager.CertificateSelectionReport = new SuccessReport("Jūs nepasirinkote sertifikato!", false);
                }

                CheckReportsAndStartSigningDocuments(sourceLocationPath, destinationLocationPath, multipleSigning);
            }

            this.PrintAllReportsMessages();
        }

        private void CheckReportsAndStartSigningDocuments(string sourceLocationPath, string destinationLocationPath, bool isMultipleSigning = false,
            string certificateLocationPath = null, string certificatePassword = null, bool createCertificate = false)
        {
            SuccessReport signingReport = SuccessReport.GetReport();

            if (ReportsManager.SourcePathReport.IsSuccessful &&
                ReportsManager.DestinationPathReport.IsSuccessful &&
                ReportsManager.CertificateSelectionReport.IsSuccessful)
            {
                if (createCertificate)
                    ReportsManager.CertificateSelectionReport = DigitalSignatureSigner.CreateAndSetCertificate(certificateLocationPath, certificatePassword);//"C:\\Users\\pc\\Desktop\\Cryptografija\\DummyCertificate.pfx", "1234"

                if (isMultipleSigning)
                {
                    string[] xmlFiles = Directory.GetFiles(sourceLocationPath, "*.xml");

                    foreach (string XMLDocumentPath in xmlFiles)
                    {
                        signingReport = SetDigitalSignerPathsAndSign(XMLDocumentPath, Path.Combine(destinationLocationPath, Path.GetFileName(XMLDocumentPath)));

                        if (!signingReport.IsSuccessful)
                            break;
                    }

                    if (signingReport.IsSuccessful)
                    {
                        signingReport.Message = "Sėkmingai pasirašyti dokumentai!";
                    }
                }
                else
                {
                    signingReport = SetDigitalSignerPathsAndSign(sourceLocationPath, Path.Combine(destinationLocationPath, Path.GetFileName(sourceLocationPath)));

                    if (signingReport.IsSuccessful)
                    {
                        signingReport.Message = "Sėkmingai pasirašytas dokumentas!";
                    }
                }
            }

            ReportsManager.GeneralReport = signingReport;
        }

        private SuccessReport SetDigitalSignerPathsAndSign(string inputPath, string outputPath)
        {
            DigitalSignatureSigner.SourcePath = inputPath;
            DigitalSignatureSigner.DestinationPath = outputPath;

            return DigitalSignatureSigner.DigitallySignXMLInXades();
        }

        private void PrintAllReportsMessages()
        {
            CertificatePanelsManager.PrintMessage(this.SourceValidationLabel, ReportsManager.SourcePathReport);
            CertificatePanelsManager.PrintMessage(this.DestinationValidationLabel, ReportsManager.DestinationPathReport);

            if (this.certificateManager.GetCurrentPanelIndex() == (int)CertificatePanelsManager.CertificatePanels.TypeInCertificateLocation)
                CertificatePanelsManager.PrintMessage(this.CertificateValidationLabel, ReportsManager.CertificateSelectionReport);
            else
                CertificatePanelsManager.PrintMessage(this.MSCertificateValidationLabel, ReportsManager.CertificateSelectionReport);

            CertificatePanelsManager.PrintMessage(this.GeneralReportLabel, ReportsManager.GeneralReport);
        }

        private void SelectPFXDocumentPanelButton_Click(object sender, EventArgs e)
        {
            this.certificateManager.ChangeCurrentCertificatePanel(CertificatePanelsManager.CertificatePanels.TypeInCertificateLocation);
        }

        private void SelectMSCertificatePanelButton_Click(object sender, EventArgs e)
        {
            this.certificateManager.ChangeCurrentCertificatePanel(CertificatePanelsManager.CertificatePanels.ChooseFromMicrosoftStore);
        }

        private void SelectMSCertificateButton_Click(object sender, EventArgs e)
        {
            CertificatePanelsManager.SelectCertificateFromStoreAndPrint(this.MSCertificateValidationLabel);
        }
    }
}
