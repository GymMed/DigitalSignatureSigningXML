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
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace DigitalSignatureSigningXML
{
    public enum ApplicationFileFormats
    {
        XML,
        PFX,
        CER
    }

    public partial class MainNavigationForm : Form
    {
        public static readonly string[] fileFormats = new string[]
        {
            "XML dokumentai (*.xml)|*.xml",
            "Sertifikato dokumentai (*.pfx)|*.pfx",
            "Sertifikato dokumentai (*.cer)|*.cer"
        };

        public static readonly string[] fileFormatsExtensions = new string[]
        {
            ".xml",
            ".pfx",
            ".cer"
        };

        private Button currentButton;
        private Form activeForm;

        public MainNavigationForm()
        {
            InitializeComponent();
            //paslepia default minimizavimą, sumažinimą ir išjungimą
            this.Text = string.Empty;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Padding = new Padding(1);
            this.BackColor = Color.Black;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Mažiau painios naudotoja
            OpenChildForm(new Forms.DigitalSignerForm(), this.NavigationSignButton);
        }

        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        //Del dizaino panaikinau default rėmelius, todėl
        //sukuriamas taškas leidžiantis keisti formos dydį
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //------------------------Dokumentų pasirinkimai---------------------------------//
        public static void SelectDirectoryPath(TextBox pathPrintTextBox, string description = "Pasirinkite lokaciją.")
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = description })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    pathPrintTextBox.Text = fbd.SelectedPath;
            }
        }

        public static void SelectFilePath(TextBox pathPrintTextBox, ApplicationFileFormats format = ApplicationFileFormats.XML)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = fileFormats[(int)format] })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    pathPrintTextBox.Text = ofd.FileName;
            }
        }

        //------------------------Navigacija---------------------------------//
        private void NavigationSignButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DigitalSignerForm(), sender);
        }

        private void NavigationVerifyButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DigitalSignatureVerifierForm(), sender);
        }

        //tempent juda visas langas
        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            DragWholeWindow();
        }


        private void TitleBarLabel_MouseMove(object sender, MouseEventArgs e)
        {
            DragWholeWindow();
        }


        private void NavigationLogoPanel_MouseMove(object sender, MouseEventArgs e)
        {
            DragWholeWindow();
        }

        private void DragWholeWindow()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form childForm, object BtnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            ActiveButton(BtnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TitleBarLabel.Text = childForm.Text;
        }

        //------------------------top bar mygtukai----------------------------//
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximazeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //------------------------dizaino efektai----------------------------//
        private void ActiveButton(object BtnSender)
        {
            if(BtnSender != null)
            {
                if(currentButton != (Button)BtnSender)
                {
                    DisableButton();

                    Color color = Color.FromArgb(67, 88, 253);
                    currentButton = (Button)BtnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
                    TitleBarPanel.BackColor = color;
                    NavigationLogoPanel.BackColor = ThemeDesigner.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in NavigationMenuPanel.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
                }
            }
        }
    }
}
