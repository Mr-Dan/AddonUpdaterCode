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
using AddonUpdater.Forms;
//using System.Net.NetworkInformation;

namespace AddonUpdater
{
    public partial class FormMainMenu : Form
    {
        private Form activeform;     
        private Button currentButton = new Button();
        public static string activity = null;
        public static int UpdateCount = 0;
        bool openFormAddons = false;
        bool openingForm = false;
        DownloadAddonGitHub downloadAddonGitHub = new DownloadAddonGitHub();
       
        Color standardButton = Color.FromArgb(37, 35, 47);
        Color activeButton = Color.FromArgb(123, 119, 159);

        public FormMainMenu()
        {                    
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeform != null)
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
            timer1.Start();
            timerKill.Start();
            OpenChildForm(new Forms.FormAddons(this), buttonAddons);
            openFormAddons = true;
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
            progressBar1.Visible = true;
            labelInfo.Visible = true;
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
                result = streamReader.ReadToEnd().Replace("\n", "").Trim();
                labelVersion.Text = "v." + Application.ProductVersion;
                if (Application.ProductVersion != result)
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
            catch (Exception ex)
            {
                if (ex.Message != "Операция была отменена пользователем")
                {
                    MessageBox.Show("Ошибка подключения, повторите попытку позже", "Ошибка");
                }
            }
        }

        private void buttonAddons_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (activity != null)
                MessageBox.Show($"Дождитесь окончания {activity}");
            else
            {
                OpenChildForm(new FormAddons(this), sender);
                openFormAddons = true;
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (activity != null)
                MessageBox.Show($"Дождитесь окончания {activity}");
            else
            {
                if (progressBar1.Visible == true)
                {
                    progressBar1.Visible = false;
                    labelInfo.Visible = false;
                }
                OpenChildForm(new FormSetting(), sender);
                openFormAddons = false;
            }
        }

        private void buttonAllAddons_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (activity != null)
                MessageBox.Show($"Дождитесь окончания {activity}");
            else
            {
                OpenChildForm(new FormAllAddons(this), sender);
                openFormAddons = true;
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (activity != null)
                MessageBox.Show($"Дождитесь окончания {activity}");
            else
            {
                if (progressBar1.Visible == true)
                {
                    progressBar1.Visible = false;
                    labelInfo.Visible = false;
                }
                OpenChildForm(new FormAbout(), sender);
                openFormAddons = false;
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (activity != null)
                MessageBox.Show($"Дождитесь окончания {activity}");
            else
            {
                notifyIcon1.Visible = false;
                Application.Exit();
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (activity != null)
                MessageBox.Show($"Дождитесь окончания {activity}");
            else
            {
                notifyIcon1.Visible = false;
                Application.Exit();
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (activity == null)
            {
                openingForm = false;
                await downloadAddonGitHub.Aupdatecheck();

                if (DownloadAddonGitHub.GitHubs.Count > 0)
                if (DownloadAddonGitHub.UpdateInfo == true)
                {
                       
                    foreach (Form form in Application.OpenForms)
                    {
                            
                       OpenForm(form.Name);
                            if (openingForm == true) break;
                    }
                    
                    if (Properties.Settings.Default.AutoUpdateBool == true && UpdateCount > 0 && openingForm == false)
                    {
                        activity = "Cкачивания";
                        await DownloadAddonAuto();
                        activity = null;
                    }
                }
            }
        }

        private void OpenForm(string name)
        {
            if (DownloadAddonGitHub.UpdateInfo == true)
            if (name == "FormAddons")
            {
                OpenChildForm(new FormAddons(this), buttonAddons);
                openingForm = true;
                DownloadAddonGitHub.UpdateInfo = false;

            }
            else if (name == "FormAllAddons")
            {
                OpenChildForm(new FormAllAddons(this), buttonAllAddons);
                openingForm = true;
                DownloadAddonGitHub.UpdateInfo = false;

            }       
        }
       
        public async Task DownloadAddonAuto()
        {
            ButtonOff();
            try
            {
                if (progressBar1.Visible == false)
                {
                    progressBar1.Visible = true;
                    labelInfo.Visible = true;
                }
                progressBar1.Value = 0;
                DownloadAddonGitHub.NeedUpdate.Clear();
                DownloadAddonGitHub.NeedUpdate = DownloadAddonGitHub.GitHubs.FindAll(find => find.NeedUpdate == true);
                progressBar1.Maximum = DownloadAddonGitHub.NeedUpdate.Count;
                for (int i = 0; i < DownloadAddonGitHub.NeedUpdate.Count; i++)
                {
                    labelInfo.Text = DownloadAddonGitHub.NeedUpdate[i].Name;
                    await downloadAddonGitHub.DownloadAddonGitHubTask(DownloadAddonGitHub.NeedUpdate[i].link, DownloadAddonGitHub.NeedUpdate[i].Name, DownloadAddonGitHub.NeedUpdate[i].Directory, DownloadAddonGitHub.NeedUpdate[i].Branches);
                    progressBar1.Value++;
                }
                labelInfo.Text = "Распаковка Аддонов";
                await downloadAddonGitHub.GetAddon();
                UpdateCount = 0;
                labelInfo.Text = "Обновление";
                activity = "обновления";
                progressBar1.Value = 0;
                progressBar1.Maximum = 2;
                progressBar1.Value++;
                await downloadAddonGitHub.Aupdatecheck();
                progressBar1.Value++;
                progressBar1.Value = 0;
                labelInfo.Text = "";
                activity = null;
                if (openFormAddons == false)
                {
                    progressBar1.Visible = false;
                    labelInfo.Visible = false;
                }
            }
            catch
            {
                progressBar1.Value = 0;
                labelInfo.Text = "Ошибка подключения";
            }
            ButtonOn();
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

                    OpenForm(activeform.Name);
                }

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
            ActiveControl = null;
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
            OpenForm(activeform.Name);
        }

        private void timerKill_Tick(object sender, EventArgs e)
        {
            string proc = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(proc);
            if (processes.Length > 1)
            {
                foreach (Process process in processes)
                {
                    if (process.Id != Process.GetCurrentProcess().Id)
                        process.Kill();
                }
                ShowInTaskbar = true;
                WindowState = FormWindowState.Normal;
                OpenForm(activeform.Name);
            }
        }

        public void ButtonOff()
        {
            buttonAbout.Enabled = false;
            buttonAddons.Enabled = false;
            buttonAllAddons.Enabled = false;
            buttonSettings.Enabled = false;
            button_Close.Enabled = false;
        }

        public void ButtonOn()
        {
            buttonAbout.Enabled = true;
            buttonAddons.Enabled = true;
            buttonAllAddons.Enabled = true;
            buttonSettings.Enabled = true;
            button_Close.Enabled = true;
        }
     
    }
}
