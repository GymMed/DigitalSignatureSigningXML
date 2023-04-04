using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DigitalSignatureSigningXML
{
    public class CertificatePanelsManager
    {
        public enum CertificatePanels
        {
            ChooseFromMicrosoftStore,
            TypeInCertificateLocation
        }

        private int currentCertificatePanelIndex = 0;
        private List<Panel> responsiveCertificatePanels;

        public CertificatePanelsManager(List<Panel> certificatePanels)
        {
            responsiveCertificatePanels = certificatePanels;
        }

        public void ChangeCurrentCertificatePanel(CertificatePanels panel)
        {
            this.responsiveCertificatePanels[this.currentCertificatePanelIndex].Enabled = false;
            this.responsiveCertificatePanels[this.currentCertificatePanelIndex].Visible = false;
            this.currentCertificatePanelIndex = (int)panel;
            this.responsiveCertificatePanels[this.currentCertificatePanelIndex].Enabled = true;
            this.responsiveCertificatePanels[this.currentCertificatePanelIndex].Visible = true;
        }

        public int GetCurrentPanelIndex()
        {
            return currentCertificatePanelIndex;
        }

        public static void SelectCertificateFromStoreAndPrint(Label certificateValidationLabel)
        {
            SuccessReport report = DigitalSignatureSigner.SelectCertificateFromStore();
            ReportsManager.CertificateSelectionReport = report;
            PrintMessage(certificateValidationLabel, report);
        }

        public static void ValidateSourceLocationAndPrint(TextBox sourceTextBox, Label sourceValidationLabel)
        {
            PathValidator.SourceLocation = sourceTextBox.Text;
            SuccessReport report = PathValidator.ValidateSourceLocation();
            PrintMessage(sourceValidationLabel, report);
        }

        public static void ValidateCertificateLocationAndPrint(TextBox certificateTextBox, Label certificateValidationLabel, ApplicationFileFormats availableFormat)
        {
            PathValidator.CertificateLocation = certificateTextBox.Text;
            SuccessReport report = PathValidator.ValidateCertificateLocation(availableFormat);
            PrintMessage(certificateValidationLabel, report);
        }

        public static void PrintMessage(Label messageLabel, SuccessReport report)
        {
            messageLabel.Text = report.Message;

            if (report.IsSuccessful)
            {
                messageLabel.ForeColor = Color.Green;
            }
            else
            {
                messageLabel.ForeColor = Color.Red;
            }
        }
    }
}
