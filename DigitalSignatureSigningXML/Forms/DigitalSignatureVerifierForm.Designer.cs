
namespace DigitalSignatureSigningXML.Forms
{
    partial class DigitalSignatureVerifierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.CertificatePFXLocationPanel = new System.Windows.Forms.Panel();
            this.CertificateTypeInLocationPanel = new System.Windows.Forms.Panel();
            this.SelectMSCertificatePanelButton = new System.Windows.Forms.Button();
            this.CertificateLocationLabel = new System.Windows.Forms.Label();
            this.CertificateValidationLabel = new System.Windows.Forms.Label();
            this.CertificateSearchButton = new System.Windows.Forms.Button();
            this.CertificateLocationTextBox = new System.Windows.Forms.TextBox();
            this.SelectMSCertificatePanel = new System.Windows.Forms.Panel();
            this.SelectPFXDocumentPanelButton = new System.Windows.Forms.Button();
            this.MSCertificateValidationLabel = new System.Windows.Forms.Label();
            this.SelectMSCertificateButton = new System.Windows.Forms.Button();
            this.VerifyDigitalSignatureButton = new System.Windows.Forms.Button();
            this.GeneralReportLabel = new System.Windows.Forms.Label();
            this.SigningOptionsPanel = new System.Windows.Forms.Panel();
            this.SourceValidationLabel = new System.Windows.Forms.Label();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.SourceSearchButton = new System.Windows.Forms.Button();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.GeneralPanel.SuspendLayout();
            this.CertificatePFXLocationPanel.SuspendLayout();
            this.CertificateTypeInLocationPanel.SuspendLayout();
            this.SelectMSCertificatePanel.SuspendLayout();
            this.SigningOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralPanel.Controls.Add(this.CertificatePFXLocationPanel);
            this.GeneralPanel.Controls.Add(this.VerifyDigitalSignatureButton);
            this.GeneralPanel.Controls.Add(this.GeneralReportLabel);
            this.GeneralPanel.Controls.Add(this.SigningOptionsPanel);
            this.GeneralPanel.Location = new System.Drawing.Point(0, -3);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(425, 456);
            this.GeneralPanel.TabIndex = 20;
            // 
            // CertificatePFXLocationPanel
            // 
            this.CertificatePFXLocationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CertificatePFXLocationPanel.Controls.Add(this.SelectMSCertificatePanel);
            this.CertificatePFXLocationPanel.Controls.Add(this.CertificateTypeInLocationPanel);
            this.CertificatePFXLocationPanel.Location = new System.Drawing.Point(12, 91);
            this.CertificatePFXLocationPanel.Name = "CertificatePFXLocationPanel";
            this.CertificatePFXLocationPanel.Size = new System.Drawing.Size(400, 85);
            this.CertificatePFXLocationPanel.TabIndex = 13;
            // 
            // CertificateTypeInLocationPanel
            // 
            this.CertificateTypeInLocationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CertificateTypeInLocationPanel.Controls.Add(this.SelectMSCertificatePanelButton);
            this.CertificateTypeInLocationPanel.Controls.Add(this.CertificateLocationLabel);
            this.CertificateTypeInLocationPanel.Controls.Add(this.CertificateValidationLabel);
            this.CertificateTypeInLocationPanel.Controls.Add(this.CertificateSearchButton);
            this.CertificateTypeInLocationPanel.Controls.Add(this.CertificateLocationTextBox);
            this.CertificateTypeInLocationPanel.Location = new System.Drawing.Point(0, 0);
            this.CertificateTypeInLocationPanel.Name = "CertificateTypeInLocationPanel";
            this.CertificateTypeInLocationPanel.Size = new System.Drawing.Size(400, 85);
            this.CertificateTypeInLocationPanel.TabIndex = 17;
            // 
            // SelectMSCertificatePanelButton
            // 
            this.SelectMSCertificatePanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectMSCertificatePanelButton.Location = new System.Drawing.Point(207, 59);
            this.SelectMSCertificatePanelButton.Name = "SelectMSCertificatePanelButton";
            this.SelectMSCertificatePanelButton.Size = new System.Drawing.Size(190, 23);
            this.SelectMSCertificatePanelButton.TabIndex = 17;
            this.SelectMSCertificatePanelButton.Text = "Pasirinkti sertifikatą iš MS saugyklos";
            this.SelectMSCertificatePanelButton.UseVisualStyleBackColor = true;
            this.SelectMSCertificatePanelButton.Click += new System.EventHandler(this.SelectMSCertificatePanelButton_Click);
            // 
            // CertificateLocationLabel
            // 
            this.CertificateLocationLabel.AutoSize = true;
            this.CertificateLocationLabel.Location = new System.Drawing.Point(11, 2);
            this.CertificateLocationLabel.Name = "CertificateLocationLabel";
            this.CertificateLocationLabel.Size = new System.Drawing.Size(96, 13);
            this.CertificateLocationLabel.TabIndex = 10;
            this.CertificateLocationLabel.Text = "Sertifikato lokacija:";
            // 
            // CertificateValidationLabel
            // 
            this.CertificateValidationLabel.AutoSize = true;
            this.CertificateValidationLabel.Location = new System.Drawing.Point(11, 41);
            this.CertificateValidationLabel.Name = "CertificateValidationLabel";
            this.CertificateValidationLabel.Size = new System.Drawing.Size(0, 13);
            this.CertificateValidationLabel.TabIndex = 16;
            // 
            // CertificateSearchButton
            // 
            this.CertificateSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CertificateSearchButton.Location = new System.Drawing.Point(354, 15);
            this.CertificateSearchButton.Name = "CertificateSearchButton";
            this.CertificateSearchButton.Size = new System.Drawing.Size(30, 23);
            this.CertificateSearchButton.TabIndex = 12;
            this.CertificateSearchButton.Text = "...";
            this.CertificateSearchButton.UseVisualStyleBackColor = true;
            this.CertificateSearchButton.Click += new System.EventHandler(this.CertificateSearchButton_Click);
            // 
            // CertificateLocationTextBox
            // 
            this.CertificateLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CertificateLocationTextBox.Location = new System.Drawing.Point(14, 18);
            this.CertificateLocationTextBox.Name = "CertificateLocationTextBox";
            this.CertificateLocationTextBox.Size = new System.Drawing.Size(325, 20);
            this.CertificateLocationTextBox.TabIndex = 11;
            this.CertificateLocationTextBox.TextChanged += new System.EventHandler(this.CertificateLocationTextBox_TextChanged);
            // 
            // SelectMSCertificatePanel
            // 
            this.SelectMSCertificatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectMSCertificatePanel.Controls.Add(this.SelectPFXDocumentPanelButton);
            this.SelectMSCertificatePanel.Controls.Add(this.MSCertificateValidationLabel);
            this.SelectMSCertificatePanel.Controls.Add(this.SelectMSCertificateButton);
            this.SelectMSCertificatePanel.Location = new System.Drawing.Point(0, 0);
            this.SelectMSCertificatePanel.Name = "SelectMSCertificatePanel";
            this.SelectMSCertificatePanel.Size = new System.Drawing.Size(400, 85);
            this.SelectMSCertificatePanel.TabIndex = 18;
            // 
            // SelectPFXDocumentPanelButton
            // 
            this.SelectPFXDocumentPanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectPFXDocumentPanelButton.Location = new System.Drawing.Point(207, 59);
            this.SelectPFXDocumentPanelButton.Name = "SelectPFXDocumentPanelButton";
            this.SelectPFXDocumentPanelButton.Size = new System.Drawing.Size(190, 23);
            this.SelectPFXDocumentPanelButton.TabIndex = 17;
            this.SelectPFXDocumentPanelButton.Text = "Ieškoti sertifikato pagal lokaciją";
            this.SelectPFXDocumentPanelButton.UseVisualStyleBackColor = true;
            this.SelectPFXDocumentPanelButton.Click += new System.EventHandler(this.SelectPFXDocumentPanelButton_Click);
            // 
            // MSCertificateValidationLabel
            // 
            this.MSCertificateValidationLabel.AutoSize = true;
            this.MSCertificateValidationLabel.Location = new System.Drawing.Point(11, 41);
            this.MSCertificateValidationLabel.Name = "MSCertificateValidationLabel";
            this.MSCertificateValidationLabel.Size = new System.Drawing.Size(0, 13);
            this.MSCertificateValidationLabel.TabIndex = 16;
            // 
            // SelectMSCertificateButton
            // 
            this.SelectMSCertificateButton.Location = new System.Drawing.Point(11, 15);
            this.SelectMSCertificateButton.Name = "SelectMSCertificateButton";
            this.SelectMSCertificateButton.Size = new System.Drawing.Size(109, 23);
            this.SelectMSCertificateButton.TabIndex = 12;
            this.SelectMSCertificateButton.Text = "Rinktis sertifikatą";
            this.SelectMSCertificateButton.UseVisualStyleBackColor = true;
            this.SelectMSCertificateButton.Click += new System.EventHandler(this.SelectMSCertificateButton_Click);
            // 
            // VerifyDigitalSignatureButton
            // 
            this.VerifyDigitalSignatureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VerifyDigitalSignatureButton.Location = new System.Drawing.Point(237, 416);
            this.VerifyDigitalSignatureButton.Name = "VerifyDigitalSignatureButton";
            this.VerifyDigitalSignatureButton.Size = new System.Drawing.Size(175, 23);
            this.VerifyDigitalSignatureButton.TabIndex = 1;
            this.VerifyDigitalSignatureButton.Text = "Patikrinti elektroninį parašą";
            this.VerifyDigitalSignatureButton.UseVisualStyleBackColor = true;
            this.VerifyDigitalSignatureButton.Click += new System.EventHandler(this.VerifyDigitalSignatureButton_Click);
            // 
            // GeneralReportLabel
            // 
            this.GeneralReportLabel.AutoSize = true;
            this.GeneralReportLabel.Location = new System.Drawing.Point(23, 363);
            this.GeneralReportLabel.Name = "GeneralReportLabel";
            this.GeneralReportLabel.Size = new System.Drawing.Size(0, 13);
            this.GeneralReportLabel.TabIndex = 2;
            // 
            // SigningOptionsPanel
            // 
            this.SigningOptionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SigningOptionsPanel.Controls.Add(this.SourceValidationLabel);
            this.SigningOptionsPanel.Controls.Add(this.InformationLabel);
            this.SigningOptionsPanel.Controls.Add(this.SourceSearchButton);
            this.SigningOptionsPanel.Controls.Add(this.SourceTextBox);
            this.SigningOptionsPanel.Controls.Add(this.SourceLabel);
            this.SigningOptionsPanel.Location = new System.Drawing.Point(12, 12);
            this.SigningOptionsPanel.Name = "SigningOptionsPanel";
            this.SigningOptionsPanel.Size = new System.Drawing.Size(400, 73);
            this.SigningOptionsPanel.TabIndex = 0;
            // 
            // SourceValidationLabel
            // 
            this.SourceValidationLabel.AutoSize = true;
            this.SourceValidationLabel.Location = new System.Drawing.Point(11, 38);
            this.SourceValidationLabel.Name = "SourceValidationLabel";
            this.SourceValidationLabel.Size = new System.Drawing.Size(0, 13);
            this.SourceValidationLabel.TabIndex = 10;
            // 
            // InformationLabel
            // 
            this.InformationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Location = new System.Drawing.Point(11, 60);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(177, 13);
            this.InformationLabel.TabIndex = 9;
            this.InformationLabel.Text = "Elektroninio parašo formatas XAdES";
            // 
            // SourceSearchButton
            // 
            this.SourceSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceSearchButton.Location = new System.Drawing.Point(354, 12);
            this.SourceSearchButton.Name = "SourceSearchButton";
            this.SourceSearchButton.Size = new System.Drawing.Size(30, 23);
            this.SourceSearchButton.TabIndex = 5;
            this.SourceSearchButton.Text = "...";
            this.SourceSearchButton.UseVisualStyleBackColor = true;
            this.SourceSearchButton.Click += new System.EventHandler(this.SourceSearchButton_Click);
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceTextBox.Location = new System.Drawing.Point(14, 15);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(325, 20);
            this.SourceTextBox.TabIndex = 4;
            this.SourceTextBox.TextChanged += new System.EventHandler(this.SourceTextBox_TextChanged);
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(11, -1);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(127, 13);
            this.SourceLabel.TabIndex = 3;
            this.SourceLabel.Text = "XML dokumento lokacija:";
            // 
            // DigitalSignatureVerifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 451);
            this.Controls.Add(this.GeneralPanel);
            this.Name = "DigitalSignatureVerifierForm";
            this.Text = "Patikrinimas el. parašo";
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            this.CertificatePFXLocationPanel.ResumeLayout(false);
            this.CertificateTypeInLocationPanel.ResumeLayout(false);
            this.CertificateTypeInLocationPanel.PerformLayout();
            this.SelectMSCertificatePanel.ResumeLayout(false);
            this.SelectMSCertificatePanel.PerformLayout();
            this.SigningOptionsPanel.ResumeLayout(false);
            this.SigningOptionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Panel CertificatePFXLocationPanel;
        private System.Windows.Forms.Panel SelectMSCertificatePanel;
        private System.Windows.Forms.Button SelectPFXDocumentPanelButton;
        private System.Windows.Forms.Label MSCertificateValidationLabel;
        private System.Windows.Forms.Button SelectMSCertificateButton;
        private System.Windows.Forms.Panel CertificateTypeInLocationPanel;
        private System.Windows.Forms.Button SelectMSCertificatePanelButton;
        private System.Windows.Forms.Label CertificateLocationLabel;
        private System.Windows.Forms.Label CertificateValidationLabel;
        private System.Windows.Forms.Button CertificateSearchButton;
        private System.Windows.Forms.TextBox CertificateLocationTextBox;
        private System.Windows.Forms.Button VerifyDigitalSignatureButton;
        private System.Windows.Forms.Label GeneralReportLabel;
        private System.Windows.Forms.Panel SigningOptionsPanel;
        private System.Windows.Forms.Label SourceValidationLabel;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Button SourceSearchButton;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.Label SourceLabel;
    }
}