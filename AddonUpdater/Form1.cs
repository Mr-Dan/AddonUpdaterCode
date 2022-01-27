using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace AddonUpdater
{
    public partial class FormMainMenu : Form
    {
        private Form activeform;
        private Button currentButton = new Button();
        public static List<GitHub> GitHubs = new List<GitHub>();
        DownloadAddonGitHub downloadAddonGitHub = new DownloadAddonGitHub();

         Color standardButton = Color.FromArgb(37, 35, 47);
         Color activeButton = Color.FromArgb(123, 119, 159);
        
        // [DllImport("user32.dll")]
        //static extern int SetParent(int hWndChild, int hWndNewParent);
        //Process p = Process.Start(Properties.Settings.Default.link_launcher);
        //Thread.Sleep(500);
        //SetParent(p.MainWindowHandle.ToInt32(), this.Handle.ToInt32());
        public FormMainMenu()
        {
            InitializeComponent();
        }
     
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeform != null)
            {
                activeform.Close();
            }
            ActivateButton(btnSender);
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;       
            childForm.BringToFront();
            childForm.Show();      
            labelTitle.Text = childForm.Text;
        }
    
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();          
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = activeButton;
                    currentButton.ForeColor = Color.White;          
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = standardButton;
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }
        
        private async void Form1_Load(object sender, EventArgs e)
        {
            
            CheckVersion();

            if (File.Exists("Updater.exe") == false)
            {
                MessageBox.Show("Не найден файл Updater.exe. Попробуйте переустановить приложение", "Ошибка");
                Application.Exit();
            }

            await downloadAddonGitHub.Aupdatecheck();
            VisibleOn();
            if (GitHubs.Count == 0) GitHubs = new List<GitHub>(DownloadAddonGitHub.GitHubs);
            Properties.Settings.Default.download = null;
            timer1.Start();
            timerKill.Start();
            OpenChildForm(new Forms.FormAddons(GitHubs), buttonAddons);
            if (Properties.Settings.Default.PathLauncherBool == true)
            {
                Process[] proc = Process.GetProcessesByName("Sirus Launcher");
                
                if (proc.Length == 0)
                {
                    if (File.Exists(Properties.Settings.Default.PathLauncher))                       
                            Process.Start(Properties.Settings.Default.PathLauncher);                           
                }
                else
                {
                    for (int i = 0; i < proc.Length; i++)
                        proc[i].Kill();

                    if (File.Exists(Properties.Settings.Default.PathLauncher))
                                Process.Start(Properties.Settings.Default.PathLauncher);
                }
            }
            
        }

        private void VisibleOn()
        {
            buttonAbout.Visible = true;
            buttonAddons.Visible = true;
            buttonSettings.Visible = true;
            buttonAllAddons.Visible = true;      
            labelTitleName.Visible = true;
            labelTitle.Visible = true;
            labelVersion.Visible = true;
            button_Close.Visible = true;
            button_Resize.Visible = true;
        }

        private void CheckVersion()
        {
           
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            string result; 
            WebClient webClient = new WebClient();
            try
            {
                Stream stream = webClient.OpenRead("https://raw.githubusercontent.com/Mr-Dan/AddonUpdaterSettings/main/AddonUpdaterVersion");
                StreamReader streamReader = new StreamReader(stream);
                result = streamReader.ReadToEnd().Replace("\n","").Trim();
                labelVersion.Text ="v." + Application.ProductVersion;
                if(Application.ProductVersion != result)
                {
                    if (File.Exists("Updater.exe"))
                    {
                        Process p = Process.Start("Updater.exe");
                        Thread.Sleep(5000);
                    }
                    else
                    {
                        MessageBox.Show("Не найден файл Updater.exe. Попробуйте переустановить приложение", "Ошибка");
                        Application.Exit();
                    }
                 
                }
            }
            catch(Exception ex)
            {
                if (ex.Message != "Операция была отменена пользователем")
                // MessageBox.Show(ex.ToString(), ex.Message);
                {
                    MessageBox.Show("Ошибка подключения, повторите попытку позже", "Ошибка");
                    Application.Exit();
                }

            }
        }

        private void buttonAddons_Click(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.download != null)
                MessageBox.Show($"Дождитесь окончания {Properties.Settings.Default.download}");
            else
                OpenChildForm(new Forms.FormAddons(GitHubs), sender);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.download != null)
                MessageBox.Show($"Дождитесь окончания {Properties.Settings.Default.download}");
            else
                OpenChildForm(new Forms.FormSetting(), sender);
        }

        private void buttonAllAddons_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.download != null)
                MessageBox.Show($"Дождитесь окончания {Properties.Settings.Default.download}");
            else
                OpenChildForm(new Forms.FormAllAddons(GitHubs), sender);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.download != null)
                MessageBox.Show($"Дождитесь окончания {Properties.Settings.Default.download}");
            else
                OpenChildForm(new Forms.FormAbout(), sender);
        }
        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.download == null)
            {
                bool openingForm = false;
                await downloadAddonGitHub.Aupdatecheck();
                if (GitHubs.Count == 0) GitHubs = new List<GitHub>(DownloadAddonGitHub.GitHubs);

                if (GitHubs.Count > 0)
                    if (downloadAddonGitHub.ListCheck(GitHubs, DownloadAddonGitHub.GitHubs) == false)
                    {
                     
                        GitHubs = new List<GitHub>(DownloadAddonGitHub.GitHubs);
                        foreach (Form form in Application.OpenForms)
                        {
                            if (form.Name == "FormAddons")
                            {
                                OpenChildForm(new Forms.FormAddons(GitHubs), buttonAddons);
                                openingForm = true;
                                break;
                            }
                            else if (form.Name == "FormAllAddons")
                            {
                                OpenChildForm(new Forms.FormAllAddons(GitHubs), buttonAllAddons);
                                openingForm = true;
                                break;
                            }
                        }

                        if (Properties.Settings.Default.AutoUpdateBool == true && Properties.Settings.Default.AutoUpdateCount > 0 && openingForm == false)
                        {
                            Properties.Settings.Default.download = "Скачивание";
                          
                            await DownloadAddonAuto();
                            Properties.Settings.Default.download = null;
                        }
                    }               
            }
        }

        public async Task DownloadAddonAuto()
        {
            DownloadAddonGitHub.NeedUpdate.Clear();
            DownloadAddonGitHub.NeedUpdate = DownloadAddonGitHub.GitHubs.FindAll(find => find.NeedUpdate == true);
            for (int i = 0; i < DownloadAddonGitHub.NeedUpdate.Count; i++)
            {
                await downloadAddonGitHub.DownloadAddonGitHubTask(DownloadAddonGitHub.NeedUpdate[i].link, DownloadAddonGitHub.NeedUpdate[i].Name, DownloadAddonGitHub.NeedUpdate[i].Directory, DownloadAddonGitHub.NeedUpdate[i].Branches);
            }
            await downloadAddonGitHub.GetAddon();
            
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Normal)
                {
                    WindowState = FormWindowState.Minimized;
                    ShowInTaskbar = false;                    
                }
                else
                {
                    ShowInTaskbar = true;
                    WindowState = FormWindowState.Normal;
                }
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.download != null)
                MessageBox.Show($"Дождитесь окончания {Properties.Settings.Default.download}");
            else
            {
                notifyIcon1.Visible = false;
                Application.Exit();
            }
        }

        #region Убрать из atl+tab
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr window, int index, int value);

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr window, int index);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_TOOLWINDOW = 0x00000080;

        public static void HideFromAltTab(IntPtr Handle)
        {
            SetWindowLong(Handle, GWL_EXSTYLE, GetWindowLong(Handle,
                GWL_EXSTYLE) | WS_EX_TOOLWINDOW);
        }
        #endregion
        private void button_Resize_Click(object sender, EventArgs e)
        {           
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;        
            HideFromAltTab(this.Handle);
        }
       

        #region перемещяем форму по зажатой мышки
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
     
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }
        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }
        private void labelTitleName_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }
        private void MoveForm(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.download != null)
                MessageBox.Show($"Дождитесь окончания {Properties.Settings.Default.download}");
            else
            {
                notifyIcon1.Visible = false;
                Application.Exit();
            }
        }

     
        #region открыть/свернуть из панели задач
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }
        #endregion

        private void timerKill_Tick(object sender, EventArgs e)
        {
            string proc = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(proc);
            if (processes.Length > 1)
            { 
              foreach (Process process in processes)
              {
                if(process.Id != Process.GetCurrentProcess().Id)
                     process.Kill();
              }
                    ShowInTaskbar = true;
                    WindowState = FormWindowState.Normal;                                 
            }
            
        }
   
    }
}
