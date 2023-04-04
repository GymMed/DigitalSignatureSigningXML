
namespace DigitalSignatureSigningXML
{
    partial class MainNavigationForm
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
            this.NavigationMenuPanel = new System.Windows.Forms.Panel();
            this.NavigationVerifyButton = new System.Windows.Forms.Button();
            this.NavigationSignButton = new System.Windows.Forms.Button();
            this.NavigationLogoPanel = new System.Windows.Forms.Panel();
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MaximazeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TitleBarLabel = new System.Windows.Forms.Label();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.NavigationMenuPanel.SuspendLayout();
            this.TitleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationMenuPanel
            // 
            this.NavigationMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.NavigationMenuPanel.Controls.Add(this.NavigationVerifyButton);
            this.NavigationMenuPanel.Controls.Add(this.NavigationSignButton);
            this.NavigationMenuPanel.Controls.Add(this.NavigationLogoPanel);
            this.NavigationMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationMenuPanel.Name = "NavigationMenuPanel";
            this.NavigationMenuPanel.Size = new System.Drawing.Size(200, 521);
            this.NavigationMenuPanel.TabIndex = 19;
            // 
            // NavigationVerifyButton
            // 
            this.NavigationVerifyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationVerifyButton.FlatAppearance.BorderSize = 0;
            this.NavigationVerifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavigationVerifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.NavigationVerifyButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.NavigationVerifyButton.Location = new System.Drawing.Point(0, 140);
            this.NavigationVerifyButton.Name = "NavigationVerifyButton";
            this.NavigationVerifyButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.NavigationVerifyButton.Size = new System.Drawing.Size(200, 60);
            this.NavigationVerifyButton.TabIndex = 1;
            this.NavigationVerifyButton.Text = "Patikrinti";
            this.NavigationVerifyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NavigationVerifyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NavigationVerifyButton.UseVisualStyleBackColor = true;
            this.NavigationVerifyButton.Click += new System.EventHandler(this.NavigationVerifyButton_Click);
            // 
            // NavigationSignButton
            // 
            this.NavigationSignButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationSignButton.FlatAppearance.BorderSize = 0;
            this.NavigationSignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavigationSignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.NavigationSignButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.NavigationSignButton.Location = new System.Drawing.Point(0, 80);
            this.NavigationSignButton.Name = "NavigationSignButton";
            this.NavigationSignButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.NavigationSignButton.Size = new System.Drawing.Size(200, 60);
            this.NavigationSignButton.TabIndex = 0;
            this.NavigationSignButton.Text = "Pasirašyti";
            this.NavigationSignButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NavigationSignButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NavigationSignButton.UseVisualStyleBackColor = true;
            this.NavigationSignButton.Click += new System.EventHandler(this.NavigationSignButton_Click);
            // 
            // NavigationLogoPanel
            // 
            this.NavigationLogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.NavigationLogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationLogoPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationLogoPanel.Name = "NavigationLogoPanel";
            this.NavigationLogoPanel.Size = new System.Drawing.Size(200, 80);
            this.NavigationLogoPanel.TabIndex = 3;
            this.NavigationLogoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavigationLogoPanel_MouseMove);
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.TitleBarPanel.Controls.Add(this.MinimizeButton);
            this.TitleBarPanel.Controls.Add(this.MaximazeButton);
            this.TitleBarPanel.Controls.Add(this.CloseButton);
            this.TitleBarPanel.Controls.Add(this.TitleBarLabel);
            this.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBarPanel.Location = new System.Drawing.Point(200, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(424, 80);
            this.TitleBarPanel.TabIndex = 14;
            this.TitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarPanel_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(322, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "O";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximazeButton
            // 
            this.MaximazeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximazeButton.FlatAppearance.BorderSize = 0;
            this.MaximazeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximazeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.MaximazeButton.ForeColor = System.Drawing.Color.White;
            this.MaximazeButton.Location = new System.Drawing.Point(358, 0);
            this.MaximazeButton.Name = "MaximazeButton";
            this.MaximazeButton.Size = new System.Drawing.Size(30, 30);
            this.MaximazeButton.TabIndex = 2;
            this.MaximazeButton.Text = "O";
            this.MaximazeButton.UseVisualStyleBackColor = true;
            this.MaximazeButton.Click += new System.EventHandler(this.MaximazeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(394, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "O";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TitleBarLabel
            // 
            this.TitleBarLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleBarLabel.AutoSize = true;
            this.TitleBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TitleBarLabel.ForeColor = System.Drawing.Color.White;
            this.TitleBarLabel.Location = new System.Drawing.Point(6, 23);
            this.TitleBarLabel.Name = "TitleBarLabel";
            this.TitleBarLabel.Size = new System.Drawing.Size(78, 26);
            this.TitleBarLabel.TabIndex = 0;
            this.TitleBarLabel.Text = "HOME";
            this.TitleBarLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBarLabel_MouseMove);
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(200, 80);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(424, 441);
            this.DesktopPanel.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 521);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.TitleBarPanel);
            this.Controls.Add(this.NavigationMenuPanel);
            this.MinimumSize = new System.Drawing.Size(640, 560);
            this.Name = "Form1";
            this.Text = "Elektroninio parašo pasirašytojas";
            this.NavigationMenuPanel.ResumeLayout(false);
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel NavigationMenuPanel;
        private System.Windows.Forms.Button NavigationVerifyButton;
        private System.Windows.Forms.Button NavigationSignButton;
        private System.Windows.Forms.Panel NavigationLogoPanel;
        private System.Windows.Forms.Panel TitleBarPanel;
        private System.Windows.Forms.Label TitleBarLabel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button MaximazeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel DesktopPanel;
    }
}

