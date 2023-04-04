
namespace DigitalSignatureSigningXML.Forms
{
    partial class DigitalSignerForm
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
            this.SelectMSCertificatePanel = new System.Windows.Forms.Panel();
            this.SelectPFXDocumentPanelButton = new System.Windows.Forms.Button();
            this.MSCertificateValidationLabel = new System.Windows.Forms.Label();
            this.SelectMSCertificateButton = new System.Windows.Forms.Button();
            this.CertificateTypeInLocationPanel = new System.Windows.Forms.Panel();
            this.SelectMSCertificatePanelButton = new System.Windows.Forms.Button();
            this.CertificateLocationLabel = new System.Windows.Forms.Label();
            this.CertificateValidationLabel = new System.Windows.Forms.Label();
            this.CertificateSearchButton = new System.Windows.Forms.Button();
            this.CertificateLocationTextBox = new System.Windows.Forms.TextBox();
            this.CertificateShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.CertificatePasswordTextBox = new System.Windows.Forms.TextBox();
            this.CertificatePasswordLabel = new System.Windows.Forms.Label();
            this.ApplyDigitalSignatureButton = new System.Windows.Forms.Button();
            this.GeneralReportLabel = new System.Windows.Forms.Label();
            this.SigningOptionsPanel = new System.Windows.Forms.Panel();
            this.DestinationValidationLabel = new System.Windows.Forms.Label();
            this.SourceValidationLabel = new System.Windows.Forms.Label();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.SignedDestinationSearchButton = new System.Windows.Forms.Button();
            this.SignedDestinationTextBox = new System.Windows.Forms.TextBox();
            this.SignedDestinationLabel = new System.Windows.Forms.Label();
            this.SourceSearchButton = new System.Windows.Forms.Button();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.MultipleSignChoiceRadio = new System.Windows.Forms.RadioButton();
            this.SingleSignChoiceRadio = new System.Windows.Forms.RadioButton();
            this.SigningChoicesLabel = new System.Windows.Forms.Label();
            this.GeneralPanel.SuspendLayout();
            this.CertificatePFXLocationPanel.SuspendLayout();
            this.SelectMSCertificatePanel.SuspendLayout();
            this.CertificateTypeInLocationPanel.SuspendLayout();
            this.SigningOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralPanel.Controls.Add(this.CertificatePFXLocationPanel);
            this.GeneralPanel.Controls.Add(this.ApplyDigitalSignatureButton);
            this.GeneralPanel.Controls.Add(this.GeneralReportLabel);
            this.GeneralPanel.Controls.Add(this.SigningOptionsPanel);
            this.GeneralPanel.Location = new System.Drawing.Point(1, 1);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(425, 456);
            this.GeneralPanel.TabIndex = 19;
            // 
            // CertificatePFXLocationPanel
            // 
            this.CertificatePFXLocationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CertificatePFXLocationPanel.Controls.Add(this.SelectMSCertificatePanel);
            this.CertificatePFXLocationPanel.Controls.Add(this.CertificateTypeInLocationPanel);
            this.CertificatePFXLocationPanel.Location = new System.Drawing.Point(12, 207);
            this.CertificatePFXLocationPanel.Name = "CertificatePFXLocationPanel";
            this.CertificatePFXLocationPanel.Size = new System.Drawing.Size(400, 153);
            this.CertificatePFXLocationPanel.TabIndex = 13;
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
            this.SelectMSCertificatePanel.Size = new System.Drawing.Size(400, 153);
            this.SelectMSCertificatePanel.TabIndex = 18;
            // 
            // SelectPFXDocumentPanelButton
            // 
            this.SelectPFXDocumentPanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectPFXDocumentPanelButton.Location = new System.Drawing.Point(207, 127);
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
            // CertificateTypeInLocationPanel
            // 
            this.CertificateTypeInLocationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CertificateTypeInLocationPanel.Controls.Add(this.SelectMSCertificatePanelButton);
            this.CertificateTypeInLocationPanel.Controls.Add(this.CertificateLocationLabel);
            this.CertificateTypeInLocationPanel.Controls.Add(this.CertificateValidationLabel);
            this.CertificateTypeInLocationPanel.Controls.Add(this.CertificateSearchButton);
            this.CertificateTypeInLocationPanel.Controls.Add(this.CertificateLocationTextBox);
            this.CertificateTypeInLocationPanel.Controls.Add(this.CertificateShowPasswordCheckBox);
            this.CertificateTypeInLocationPanel.Controls.Add(this.CertificatePasswordTextBox);
            this.CertificateTypeInLocationPanel.Controls.Add(this.CertificatePasswordLabel);
            this.CertificateTypeInLocationPanel.Location = new System.Drawing.Point(0, 0);
            this.CertificateTypeInLocationPanel.Name = "CertificateTypeInLocationPanel";
            this.CertificateTypeInLocationPanel.Size = new System.Drawing.Size(400, 153);
            this.CertificateTypeInLocationPanel.TabIndex = 17;
            // 
            // SelectMSCertificatePanelButton
            // 
            this.SelectMSCertificatePanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectMSCertificatePanelButton.Location = new System.Drawing.Point(207, 127);
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
            // CertificateShowPasswordCheckBox
            // 
            this.CertificateShowPasswordCheckBox.AutoSize = true;
            this.CertificateShowPasswordCheckBox.Location = new System.Drawing.Point(140, 83);
            this.CertificateShowPasswordCheckBox.Name = "CertificateShowPasswordCheckBox";
            this.CertificateShowPasswordCheckBox.Size = new System.Drawing.Size(106, 17);
            this.CertificateShowPasswordCheckBox.TabIndex = 15;
            this.CertificateShowPasswordCheckBox.Text = "Rodyti slaptažodį";
            this.CertificateShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.CertificateShowPasswordCheckBox.Click += new System.EventHandler(this.CertificateShowPasswordCheckBox_CheckedChanged);
            // 
            // CertificatePasswordTextBox
            // 
            this.CertificatePasswordTextBox.Location = new System.Drawing.Point(14, 81);
            this.CertificatePasswordTextBox.Name = "CertificatePasswordTextBox";
            this.CertificatePasswordTextBox.Size = new System.Drawing.Size(109, 20);
            this.CertificatePasswordTextBox.TabIndex = 14;
            this.CertificatePasswordTextBox.UseSystemPasswordChar = true;
            // 
            // CertificatePasswordLabel
            // 
            this.CertificatePasswordLabel.AutoSize = true;
            this.CertificatePasswordLabel.Location = new System.Drawing.Point(11, 65);
            this.CertificatePasswordLabel.Name = "CertificatePasswordLabel";
            this.CertificatePasswordLabel.Size = new System.Drawing.Size(112, 13);
            this.CertificatePasswordLabel.TabIndex = 13;
            this.CertificatePasswordLabel.Text = "Sertifikato slaptažodis:";
            // 
            // ApplyDigitalSignatureButton
            // 
            this.ApplyDigitalSignatureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyDigitalSignatureButton.Location = new System.Drawing.Point(237, 416);
            this.ApplyDigitalSignatureButton.Name = "ApplyDigitalSignatureButton";
            this.ApplyDigitalSignatureButton.Size = new System.Drawing.Size(175, 23);
            this.ApplyDigitalSignatureButton.TabIndex = 1;
            this.ApplyDigitalSignatureButton.Text = "Pasirašyti elektroniniu parašu";
            this.ApplyDigitalSignatureButton.UseVisualStyleBackColor = true;
            this.ApplyDigitalSignatureButton.Click += new System.EventHandler(this.ApplyDigitalSignatureButton_Click);
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
            this.SigningOptionsPanel.Controls.Add(this.DestinationValidationLabel);
            this.SigningOptionsPanel.Controls.Add(this.SourceValidationLabel);
            this.SigningOptionsPanel.Controls.Add(this.InformationLabel);
            this.SigningOptionsPanel.Controls.Add(this.SignedDestinationSearchButton);
            this.SigningOptionsPanel.Controls.Add(this.SignedDestinationTextBox);
            this.SigningOptionsPanel.Controls.Add(this.SignedDestinationLabel);
            this.SigningOptionsPanel.Controls.Add(this.SourceSearchButton);
            this.SigningOptionsPanel.Controls.Add(this.SourceTextBox);
            this.SigningOptionsPanel.Controls.Add(this.SourceLabel);
            this.SigningOptionsPanel.Controls.Add(this.MultipleSignChoiceRadio);
            this.SigningOptionsPanel.Controls.Add(this.SingleSignChoiceRadio);
            this.SigningOptionsPanel.Controls.Add(this.SigningChoicesLabel);
            this.SigningOptionsPanel.Location = new System.Drawing.Point(12, 12);
            this.SigningOptionsPanel.Name = "SigningOptionsPanel";
            this.SigningOptionsPanel.Size = new System.Drawing.Size(400, 189);
            this.SigningOptionsPanel.TabIndex = 0;
            // 
            // DestinationValidationLabel
            // 
            this.DestinationValidationLabel.AutoSize = true;
            this.DestinationValidationLabel.Location = new System.Drawing.Point(11, 150);
            this.DestinationValidationLabel.Name = "DestinationValidationLabel";
            this.DestinationValidationLabel.Size = new System.Drawing.Size(0, 13);
            this.DestinationValidationLabel.TabIndex = 11;
            // 
            // SourceValidationLabel
            // 
            this.SourceValidationLabel.AutoSize = true;
            this.SourceValidationLabel.Location = new System.Drawing.Point(11, 87);
            this.SourceValidationLabel.Name = "SourceValidationLabel";
            this.SourceValidationLabel.Size = new System.Drawing.Size(0, 13);
            this.SourceValidationLabel.TabIndex = 10;
            // 
            // InformationLabel
            // 
            this.InformationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Location = new System.Drawing.Point(11, 176);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(177, 13);
            this.InformationLabel.TabIndex = 9;
            this.InformationLabel.Text = "Elektroninio parašo formatas XAdES";
            // 
            // SignedDestinationSearchButton
            // 
            this.SignedDestinationSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignedDestinationSearchButton.Location = new System.Drawing.Point(354, 124);
            this.SignedDestinationSearchButton.Name = "SignedDestinationSearchButton";
            this.SignedDestinationSearchButton.Size = new System.Drawing.Size(30, 23);
            this.SignedDestinationSearchButton.TabIndex = 8;
            this.SignedDestinationSearchButton.Text = "...";
            this.SignedDestinationSearchButton.UseVisualStyleBackColor = true;
            this.SignedDestinationSearchButton.Click += new System.EventHandler(this.DestinationSearchButton_Click);
            // 
            // SignedDestinationTextBox
            // 
            this.SignedDestinationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignedDestinationTextBox.Location = new System.Drawing.Point(14, 127);
            this.SignedDestinationTextBox.Name = "SignedDestinationTextBox";
            this.SignedDestinationTextBox.Size = new System.Drawing.Size(325, 20);
            this.SignedDestinationTextBox.TabIndex = 7;
            this.SignedDestinationTextBox.Leave += new System.EventHandler(this.SignedDestinationTextBox_Leave);
            // 
            // SignedDestinationLabel
            // 
            this.SignedDestinationLabel.AutoSize = true;
            this.SignedDestinationLabel.Location = new System.Drawing.Point(11, 111);
            this.SignedDestinationLabel.Name = "SignedDestinationLabel";
            this.SignedDestinationLabel.Size = new System.Drawing.Size(197, 13);
            this.SignedDestinationLabel.TabIndex = 6;
            this.SignedDestinationLabel.Text = "Pasirašytų dokumentų talpinimo lokacija:";
            // 
            // SourceSearchButton
            // 
            this.SourceSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceSearchButton.Location = new System.Drawing.Point(354, 61);
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
            this.SourceTextBox.Location = new System.Drawing.Point(14, 64);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(325, 20);
            this.SourceTextBox.TabIndex = 4;
            this.SourceTextBox.TextChanged += new System.EventHandler(this.SourceTextBox_TextChanged);
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(11, 48);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(109, 13);
            this.SourceLabel.TabIndex = 3;
            this.SourceLabel.Text = "Kompiuteryje lokacija:";
            // 
            // MultipleSignChoiceRadio
            // 
            this.MultipleSignChoiceRadio.AutoSize = true;
            this.MultipleSignChoiceRadio.Location = new System.Drawing.Point(166, 16);
            this.MultipleSignChoiceRadio.Name = "MultipleSignChoiceRadio";
            this.MultipleSignChoiceRadio.Size = new System.Drawing.Size(173, 17);
            this.MultipleSignChoiceRadio.TabIndex = 2;
            this.MultipleSignChoiceRadio.Text = "aplankalą su XML dokumentais";
            this.MultipleSignChoiceRadio.UseVisualStyleBackColor = true;
            this.MultipleSignChoiceRadio.CheckedChanged += new System.EventHandler(this.MultipleSignChoiceRadio_CheckedChanged);
            // 
            // SingleSignChoiceRadio
            // 
            this.SingleSignChoiceRadio.AutoSize = true;
            this.SingleSignChoiceRadio.Checked = true;
            this.SingleSignChoiceRadio.Location = new System.Drawing.Point(14, 16);
            this.SingleSignChoiceRadio.Name = "SingleSignChoiceRadio";
            this.SingleSignChoiceRadio.Size = new System.Drawing.Size(132, 17);
            this.SingleSignChoiceRadio.TabIndex = 1;
            this.SingleSignChoiceRadio.TabStop = true;
            this.SingleSignChoiceRadio.Text = "vieną XML dokumentą";
            this.SingleSignChoiceRadio.UseVisualStyleBackColor = true;
            // 
            // SigningChoicesLabel
            // 
            this.SigningChoicesLabel.AutoSize = true;
            this.SigningChoicesLabel.Location = new System.Drawing.Point(11, 0);
            this.SigningChoicesLabel.Name = "SigningChoicesLabel";
            this.SigningChoicesLabel.Size = new System.Drawing.Size(146, 13);
            this.SigningChoicesLabel.TabIndex = 0;
            this.SigningChoicesLabel.Text = "Elektroniniu parašu pasirašyti:";
            // 
            // DigitalSignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 451);
            this.Controls.Add(this.GeneralPanel);
            this.Name = "DigitalSignerForm";
            this.Text = "Pasirašymas el. parašu";
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            this.CertificatePFXLocationPanel.ResumeLayout(false);
            this.SelectMSCertificatePanel.ResumeLayout(false);
            this.SelectMSCertificatePanel.PerformLayout();
            this.CertificateTypeInLocationPanel.ResumeLayout(false);
            this.CertificateTypeInLocationPanel.PerformLayout();
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
        private System.Windows.Forms.CheckBox CertificateShowPasswordCheckBox;
        private System.Windows.Forms.TextBox CertificatePasswordTextBox;
        private System.Windows.Forms.Label CertificatePasswordLabel;
        private System.Windows.Forms.Button ApplyDigitalSignatureButton;
        private System.Windows.Forms.Label GeneralReportLabel;
        private System.Windows.Forms.Panel SigningOptionsPanel;
        private System.Windows.Forms.Label DestinationValidationLabel;
        private System.Windows.Forms.Label SourceValidationLabel;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Button SignedDestinationSearchButton;
        private System.Windows.Forms.TextBox SignedDestinationTextBox;
        private System.Windows.Forms.Label SignedDestinationLabel;
        private System.Windows.Forms.Button SourceSearchButton;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.RadioButton MultipleSignChoiceRadio;
        private System.Windows.Forms.RadioButton SingleSignChoiceRadio;
        private System.Windows.Forms.Label SigningChoicesLabel;
    }
}