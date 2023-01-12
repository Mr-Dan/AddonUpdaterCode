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
using AddonUpdater.Controls;
using System.Security.Policy;

namespace AddonUpdater
{
    public partial class FormMainMenu : Form
    {
        private Control activeform;
        private string formName;
        private Button currentButton = new Button();
        public static string activity = null;

        bool openFormAddons = false;
        bool openingForm = false;
        DownloadAddonGitHub downloadAddonGitHub = new DownloadAddonGitHub();

        Color standardButton = Color.FromArgb(37, 35, 47);
        Color activeButton = Color.FromArgb(123, 119, 159);

        public FormMainMenu()
        {
            InitializeComponent();
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
                LabelVersion.Text = "v." + Properties.Settings.Default.Version.Trim();
                if (Properties.Settings.Default.Version != result)
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

        #region Click
        private void ButtonAddons_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (activity != null)
                MessageBox.Show($"Дождитесь окончания {activity}");
            else
            {
                OpenChildForm(new AddonFormControl(this, true), sender);
                formName = "FormAddons";
                openFormAddons = true;

            }
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
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
                OpenChildForm(new AddonUpdaterSettingsControl(this), sender);
                formName = "";
                openFormAddons = false;

            }
        }

        private void ButtonAllAddons_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (activity != null)
                MessageBox.Show($"Дождитесь окончания {activity}");
            else
            {
                OpenChildForm(new AddonFormControl(this, false), sender);
                formName = "FormAllAddons";
                openFormAddons = true;

            }
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
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
                OpenChildForm(new AddonUpdaterAboutFormControl(), sender);
                formName = "";
                openFormAddons = false;

            }
        }

        private void Button_Close_Click(object sender, EventArgs e)
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

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
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

                    OpenForm(formName);
                }

            }
        }

        private void Button_Resize_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            HideFromAltTab(this.Handle);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            OpenForm(formName);
        }

        private void LabelVersion_Click(object sender, EventArgs e)
        {
            if (DownloadAddonGitHub.AddonUpdaterSettings.LinkLastUpdate != null)
                Process.Start(DownloadAddonGitHub.AddonUpdaterSettings.LinkLastUpdate);
        }

        #endregion

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

                DownloadAddonGitHub.NeedUpdate.Clear();
                DownloadAddonGitHub.NeedUpdate = DownloadAddonGitHub.GitHubs.FindAll(find => find.NeedUpdate == true);
                if (DownloadAddonGitHub.NeedUpdate.Count > 0)
                {
                    progressBar1.Value = 0;
                    progressBar1.Maximum = DownloadAddonGitHub.NeedUpdate.Count;
                    for (int i = 0; i < DownloadAddonGitHub.NeedUpdate.Count; i++)
                    {
                        labelInfo.Text = DownloadAddonGitHub.NeedUpdate[i].Name;
                        await downloadAddonGitHub.DownloadAddonGitHubTask(DownloadAddonGitHub.NeedUpdate[i].Name, DownloadAddonGitHub.NeedUpdate[i].GithubLink, DownloadAddonGitHub.NeedUpdate[i].Branches);
                        progressBar1.Value++;
                    }
                    labelInfo.Text = "Распаковка Аддонов";
                    await downloadAddonGitHub.GetAddon();
                    labelInfo.Text = "Обновление";
                    activity = "обновления";
                    progressBar1.Value = 0;
                    progressBar1.Maximum = 2;
                    progressBar1.Value++;
                    await downloadAddonGitHub.Aupdatecheck();
                    SetNotificationsAddons();
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
            }
            catch
            {
                progressBar1.Value = 0;
                labelInfo.Text = "Ошибка подключения";
            }
            ButtonOn();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            CheckVersion();
            PathCheck();
            if (File.Exists("Updater.exe") == false)
            {
                MessageBox.Show("Не найден файл Updater.exe. Попробуйте переустановить приложение", "Ошибка");
                Application.Exit();
            }
            await downloadAddonGitHub.Aupdatecheck();
            VisibleOn();
            SetNotificationsAddons();
            timer1.Start();
            timerKill.Start();
            formName = "FormAddons";
            OpenChildForm(new AddonFormControl(this, true), buttonAddons);
            openFormAddons = true;
            labelNeedUpdateMyAddon.Location = new Point(0, 16);
        }

        #region MoveForm
        private void MoveForm(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }

        private void LabelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }

        private void LabelTitleName_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]

        public static extern bool ReleaseCapture();
        #endregion

        #region OpenChildForm
        private void OpenChildForm(Control childForm, object btnSender)
        {
            if (activeform != null)
            {
                activeform.Dispose();
            }
            panelDesktopPane.Controls.Clear();
            ActivateButton(btnSender);
            activeform = childForm;
            OffPanel();
            childForm.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(childForm);
            panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
            OnPanel();
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
                    if (currentButton.Name == "buttonAddons")
                        labelNeedUpdateMyAddon.BackColor = activeButton;
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
                    if (currentButton.Name == "buttonAddons")
                        labelNeedUpdateMyAddon.BackColor = standardButton;
                }
            }
        }

        #endregion 

        private void OpenForm(string name)
        {
            if (DownloadAddonGitHub.UpdateInfo == true)
                if (name == "FormAddons")
                {
                    OpenChildForm(new AddonFormControl(this, true), buttonAddons);
                    openingForm = true;
                }
                else if (name == "FormAllAddons")
                {
                    OpenChildForm(new AddonFormControl(this, false), buttonAllAddons);
                    openingForm = true;
                }
        }

        private void LabelVersion_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Нажмите для просмотра списка нововведения", LabelVersion);
        }

        #region  Timer
        private void TimerKill_Tick(object sender, EventArgs e)
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
                OpenForm(formName);
            }
        }

        private async void Timer1_Tick(object sender, EventArgs e)
        {
            if (activity == null)
            {
                openingForm = false;
                await downloadAddonGitHub.Aupdatecheck();
                SetNotificationsAddons();
                if (DownloadAddonGitHub.GitHubs.Count > 0)
                    if (DownloadAddonGitHub.UpdateInfo)
                    {

                        foreach (Form form in Application.OpenForms)
                        {
                            OpenForm(form.Name);
                            if (openingForm == true) break;
                        }

                        if (Properties.Settings.Default.AutoUpdateBool == true && DownloadAddonGitHub.Update == true && openingForm == false)
                        {
                            if (Directory.Exists(Properties.Settings.Default.PathWow))
                            {
                                activity = "Cкачивания";
                                await DownloadAddonAuto();
                                activity = null;
                            }
                            else
                            {
                                labelNeedUpdateMyAddon.Visible = false;
                            }
                        }
                    }
            }
        }

        #endregion

        #region Set/Off/on
        public void SetNotificationsAddons()
        {

            int count = DownloadAddonGitHub.GitHubs.FindAll(addon => addon.NeedUpdate == true).Count;
            if (count > 0)
            {
                labelNeedUpdateMyAddon.Visible = true;
                labelNeedUpdateMyAddon.Text = count.ToString();
            }
            else
            {
                labelNeedUpdateMyAddon.Visible = false;
            }
        }

        public void PathCheck()
        {
            System.Collections.IList list = Properties.Settings.Default.PathsWow;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != null)
                {
                    string path = list[i].ToString();
                    if (!Directory.Exists(path))
                    {
                        Properties.Settings.Default.PathsWow.Remove(path);
                        i--;
                    }
                }
                else
                {
                    Properties.Settings.Default.PathsWow.Remove(null);
                    i--;
                }
            }

            if (!Properties.Settings.Default.PathsWow.Contains(Properties.Settings.Default.PathWow))
            {
                if (Properties.Settings.Default.PathsWow.Count >= 1)
                {
                    Properties.Settings.Default.PathWow = Properties.Settings.Default.PathsWow[0];
                }
                else
                {
                    Properties.Settings.Default.PathWow = null;
                }
            }
            Properties.Settings.Default.Save();
        }

        private void OffPanel()
        {
            activeform.Visible = false;
            panelDesktopPane.Visible = false;
        }

        private void OnPanel()
        {
            activeform.Visible = true;
            panelDesktopPane.Visible = true;
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

        private void VisibleOn()
        {
            buttonAbout.Visible = true;
            buttonAddons.Visible = true;
            buttonSettings.Visible = true;
            buttonAllAddons.Visible = true;
            labelTitleName.Visible = true;
            labelTitle.Visible = true;
            LabelVersion.Visible = true;
            button_Close.Visible = true;
            button_Resize.Visible = true;
            progressBar1.Visible = true;
            labelInfo.Visible = true;
        }

        #endregion

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
    }
}
