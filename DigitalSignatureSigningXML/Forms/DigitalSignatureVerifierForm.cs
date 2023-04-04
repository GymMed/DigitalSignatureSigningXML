using System;
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
    public partial class DigitalSignatureVerifierForm : Form
    {
        private CertificatePanelsManager certificateManager;

        public DigitalSignatureVerifierForm()
        {
            InitializeComponent();
            RegisterResponsiveCertificatePanels();
        }

        private void RegisterResponsiveCertificatePanels()
        {
            List<Panel> responsiveCertificatePanels = new List<Panel>();

            responsiveCertificatePanels.Add(this.SelectMSCertificatePanel);// CertificatePanels.ChooseFromMicrosoftStore
            responsiveCertificatePanels.Add(this.CertificateTypeInLocationPanel);// CertificatePanels.TypeInPFXLocation

            certificateManager = new CertificatePanelsManager(responsiveCertificatePanels);
        }

        private void SourceSearchButton_Click(object sender, EventArgs e)
        {
            MainNavigationForm.SelectFilePath(this.SourceTextBox, ApplicationFileFormats.XML);
        }

        private void SourceTextBox_TextChanged(object sender, EventArgs e)
        {
            PathValidator.IsSingleXMLDocument = true;
            CertificatePanelsManager.ValidateSourceLocationAndPrint(this.SourceTextBox, this.SourceValidationLabel);
        }

        private void VerifyDigitalSignatureButton_Click(object sender, EventArgs e)
        {
            PathValidator.IsSingleXMLDocument = true;
            PathValidator.SourceLocation = this.SourceTextBox.Text;

            if (this.certificateManager.GetCurrentPanelIndex() == (int)CertificatePanelsManager.CertificatePanels.TypeInCertificateLocation)
            {
                PathValidator.CertificateLocation = this.CertificateLocationTextBox.Text;
                PathValidator.ValidatePathsForSignatureVerification(ApplicationFileFormats.CER);

                this.CheckReportsAndVerifyDocument(true);
            }
            else
            {
                ReportsManager.SourcePathReport = PathValidator.ValidateSourceLocation();

                if (ReportsManager.CertificateSelectionReport.Message == null)
                {
                    ReportsManager.CertificateSelectionReport = new SuccessReport("Jūs nepasirinkote sertifikato!", false);
                }

                this.CheckReportsAndVerifyDocument();
            }

            this.PrintAllReportsMessages();
        }

        private void CheckReportsAndVerifyDocument(bool createCertificate = false)
        {
            SuccessReport report = SuccessReport.GetReport();

            if (ReportsManager.SourcePathReport.IsSuccessful &&
                ReportsManager.CertificateSelectionReport.IsSuccessful)
            {
                if (createCertificate)
                    ReportsManager.CertificateSelectionReport = DigitalSignatureSigner.CreateAndSetCertificate(this.CertificateLocationTextBox.Text);//"C:\\Users\\pc\\Desktop\\Cryptografija\\DummyCertificate.pfx", "1234"

                DigitalSignatureSigner.SourcePath = this.SourceTextBox.Text;

                report = DigitalSignatureSigner.VerifyDigitalSignatureInXMLXades();//DigitalSignatureSigner.VerifyDigitalSignatureInXMLDocument(); //senas
            }

            ReportsManager.GeneralReport = report;
        }

        private void SelectMSCertificateButton_Click(object sender, EventArgs e)
        {
            CertificatePanelsManager.SelectCertificateFromStoreAndPrint((this.MSCertificateValidationLabel));
        }

        private void SelectPFXDocumentPanelButton_Click(object sender, EventArgs e)
        {
            this.certificateManager.ChangeCurrentCertificatePanel(CertificatePanelsManager.CertificatePanels.TypeInCertificateLocation);
        }

        private void SelectMSCertificatePanelButton_Click(object sender, EventArgs e)
        {
            this.certificateManager.ChangeCurrentCertificatePanel(CertificatePanelsManager.CertificatePanels.ChooseFromMicrosoftStore);
        }

        private void CertificateSearchButton_Click(object sender, EventArgs e)
        {
            MainNavigationForm.SelectFilePath(CertificateLocationTextBox, ApplicationFileFormats.CER);
        }

        private void CertificateLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            CertificatePanelsManager.ValidateCertificateLocationAndPrint(this.CertificateLocationTextBox, this.CertificateValidationLabel, ApplicationFileFormats.CER);
        }

        private void PrintAllReportsMessages()
        {
            CertificatePanelsManager.PrintMessage(this.SourceValidationLabel, ReportsManager.SourcePathReport);

            if (this.certificateManager.GetCurrentPanelIndex() == (int)CertificatePanelsManager.CertificatePanels.TypeInCertificateLocation)
                CertificatePanelsManager.PrintMessage(this.CertificateValidationLabel, ReportsManager.CertificateSelectionReport);
            else
                CertificatePanelsManager.PrintMessage(this.MSCertificateValidationLabel, ReportsManager.CertificateSelectionReport);

            CertificatePanelsManager.PrintMessage(this.GeneralReportLabel, ReportsManager.GeneralReport);
        }
    }
}
