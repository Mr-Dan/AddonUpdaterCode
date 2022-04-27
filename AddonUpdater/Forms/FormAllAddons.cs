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

namespace AddonUpdater.Forms
{
    public partial class FormAllAddons : Form
    {
        DownloadAddonGitHub downloadAddonGitHub = new DownloadAddonGitHub();
        FormMainMenu FormMainMenu;

        public FormAllAddons(FormMainMenu owner)
        {
            FormMainMenu = owner;

            InitializeComponent();
        }

        private void FormAllAddons_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PathWow.Length > 0)
            {
                if (FormMainMenu.progressBar1.Visible == false)
                {
                    FormMainMenu.progressBar1.Visible = true;
                    FormMainMenu.labelInfo.Visible = true;
                }
                panelAddonsView.HorizontalScroll.Enabled = false;
                panelAddonsView.HorizontalScroll.Visible = false;
                panelAddonsView.AutoScroll = true;
                updatePanelAddonsView(false);
            }
            else
            {
                MessageBox.Show("Укажите путь к игре в настройках", "Предупреждение");
            }
        }

        List<PanelAddon> panelAddons = new List<PanelAddon>();
        public async void updatePanelAddonsView(bool flagGetNewInfo)
        {
            FormMainMenu.ButtonOff();
            ButtonOff();
            if (flagGetNewInfo == false)
            {
                List<GitHub> git = DownloadAddonGitHub.GitHubs.FindAll(find => find.NeedUpdate == true);
                for (int i = 0; i < git.Count; i++)
                {
                    int index = DownloadAddonGitHub.GitHubs.FindIndex(indx => indx.Name == git[i].Name);
                    if (index != -1)
                    {
                        DownloadAddonGitHub.GitHubs[index].MyVersion = downloadAddonGitHub.GetMyVersion(DownloadAddonGitHub.GitHubs[index].Directory, DownloadAddonGitHub.GitHubs[index].Regex, DownloadAddonGitHub.GitHubs[index].Replace);
                        DownloadAddonGitHub.GitHubs[index].NeedUpdate = downloadAddonGitHub.GetNeedUpdate(DownloadAddonGitHub.GitHubs[index].Version, DownloadAddonGitHub.GitHubs[index].MyVersion, DownloadAddonGitHub.GitHubs[index].Blacklist);
                        DownloadAddonGitHub.GitHubs[index].DownloadMyAddon = downloadAddonGitHub.GetNeedUpdate(DownloadAddonGitHub.GitHubs[index].Version, DownloadAddonGitHub.GitHubs[index].MyVersion, DownloadAddonGitHub.GitHubs[index].Blacklist);
                        DownloadAddonGitHub.GitHubs[index].SavedVariables = downloadAddonGitHub.GetSavedVariables(DownloadAddonGitHub.GitHubs[index].Directory);
                        DownloadAddonGitHub.GitHubs[index].SavedVariablesPerCharacter = downloadAddonGitHub.GetSavedVariablesPerCharacter(DownloadAddonGitHub.GitHubs[index].Directory);
                    }
                }
            }
            else
            {
                FormMainMenu.labelInfo.Text = "Обновление";
                FormMainMenu.activity = "обновления";
                FormMainMenu.progressBar1.Value = 0;
                FormMainMenu.progressBar1.Maximum = 2;
                FormMainMenu.progressBar1.Value++;
                await downloadAddonGitHub.Aupdatecheck();
            }

            panelAddonsView.Controls.Clear();
            panelAddons.Clear();
            for (int i = 0; i < DownloadAddonGitHub.GitHubs.Count; i++)
            {
                if (DownloadAddonGitHub.GitHubs[i].MyVersion == null)
                {
                    panelAddons.Add(new PanelAddon(DownloadAddonGitHub.GitHubs[i], panelAddons.Count, panelAddonsView) { });
                    panelAddonsView.Controls.Add(panelAddons[panelAddons.Count - 1].AddonPanel);

                    panelAddons[panelAddons.Count - 1].AddonName.MouseLeave += new EventHandler(AddonName_MouseLeave);
                    panelAddons[panelAddons.Count - 1].AddonName.MouseMove += new MouseEventHandler(AddonName_MouseMove);
                    panelAddons[panelAddons.Count - 1].AddonName.MouseClick += new MouseEventHandler(AddonName_MouseClick);
                     panelAddons[panelAddons.Count - 1].AddonVersion.Click += new EventHandler(AddonVersion_Click);
                    panelAddons[panelAddons.Count - 1].AddonPanel.BringToFront();
                }
            }

            if (flagGetNewInfo == true)
            {
                FormMainMenu.progressBar1.Value++;
                FormMainMenu.progressBar1.Value = 0;
                FormMainMenu.labelInfo.Text = "";
                FormMainMenu.activity = null;
            }

            if (Properties.Settings.Default.AutoUpdateBool == true && FormMainMenu.UpdateCount > 0)
            {
                FormMainMenu.ButtonOff();
                AddonDownload("AutoDownload");
            }
            ButtonOn();
            FormMainMenu.ButtonOn();
        }
        public void AddonName_MouseLeave(object sender, EventArgs e)
        {         
            PanelDescription.Visible = false;
            LabelDescription.Text = null;         
        }
      
        public void AddonName_MouseMove(object sender, MouseEventArgs e)
        {
            ActiveControl = null;
            if (Properties.Settings.Default.DescriptionBool)
            {
                Label label = new Label();
                label = (Label)sender;

                string nameAddon = Regex.Match(label.Name, @"LabelName_(\w)+_row").Value.Replace("LabelName_", "").Replace("_row", "");
                int row = int.Parse(Regex.Match(label.Name, @"_row_\d*").Value.Replace("_row_", ""));//!!

                if (panelAddon.Visible == false)
                {
                    int index = DownloadAddonGitHub.GitHubs.FindIndex(find => find.Name == nameAddon);
                    if (index != -1)
                    {
                        if (DownloadAddonGitHub.GitHubs[index].Description != String.Empty)
                        if (PanelDescription.Visible == false)
                        {
                            LabelDescription.Text = DownloadAddonGitHub.GitHubs[index].Description;
                            Size len = TextRenderer.MeasureText(DownloadAddonGitHub.GitHubs[index].Description, LabelDescription.Font);
                            int size = len.Width * len.Height;
                            PanelDescription.Size = new Size(780, (size / 800) + 20);
                            Point pos = new Point();
                            pos.Y = label.Parent.Location.Y;
                            if (pos.Y + PanelDescription.Height + 40 > panelAddonsView.Height)
                            {
                                PanelDescription.Location = new Point(0, pos.Y - PanelDescription.Height + 50);
                            }
                            else if (pos.Y + PanelDescription.Height < panelAddonsView.Height)
                            {
                                PanelDescription.Location = new Point(0, pos.Y + 80);
                            }
                            PanelDescription.Visible = true;
                            PanelDescription.BringToFront();
                        }
                    }
                }

            }
        }
    
        public async Task DownloadAddon(string flag)
        {
            try
            {
                FormMainMenu.progressBar1.Value = 0;
                DownloadAddonGitHub.NeedUpdate.Clear();
                if (flag == "Download") DownloadAddonGitHub.NeedUpdate = DownloadAddonGitHub.GitHubs.FindAll(find => find.DownloadMyAddon == true);
                else if (flag == "AutoDownload") DownloadAddonGitHub.NeedUpdate = DownloadAddonGitHub.GitHubs.FindAll(find => find.NeedUpdate == true);

                FormMainMenu.progressBar1.Maximum = DownloadAddonGitHub.NeedUpdate.Count;
                for (int i = 0; i < DownloadAddonGitHub.NeedUpdate.Count; i++)
                {
                    FormMainMenu.labelInfo.Text = DownloadAddonGitHub.NeedUpdate[i].Name;
                    await downloadAddonGitHub.DownloadAddonGitHubTask( DownloadAddonGitHub.NeedUpdate[i].Name, DownloadAddonGitHub.NeedUpdate[i].GithubLink, DownloadAddonGitHub.NeedUpdate[i].Branches);
                    FormMainMenu.progressBar1.Value++;
                }
                FormMainMenu.labelInfo.Text = "Распаковка Аддонов";
                await downloadAddonGitHub.GetAddon();
                FormMainMenu.progressBar1.Value = 0;
                FormMainMenu.labelInfo.Text = "";
                FormMainMenu.UpdateCount = 0;
            }
            catch(Exception ex)
            {
                 //MessageBox.Show(ex.Message);
                FormMainMenu.progressBar1.Value = 0;
                FormMainMenu.labelInfo.Text = "Ошибка подключения";
            }
        }

        private async void AddonDownload(string flag)
        {           
            FormMainMenu.activity = "Cкачивания";
            ButtonOff();
            await DownloadAddon(flag);
            updatePanelAddonsView(false);
            FormMainMenu.activity = null;
            ButtonOn();  
        }   

        private void button_update_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            FormMainMenu.ButtonOff();
            ButtonOff();
            updatePanelAddonsView(true);
        }

        private void buttonLauncher_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            string pathLauncher = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Programs\\sirus-open-launcher\\Sirus Launcher.exe";
            string pathPlayExe = Properties.Settings.Default.PathWow + "\\run.exe";
            Process[] proc = Process.GetProcessesByName("Sirus Launcher");
            Process[] proc2 = Process.GetProcessesByName("run");
            if (proc.Length == 0)
            {
                if (File.Exists(pathLauncher))
                    Process.Start(pathLauncher);
            }
            else
            {
                if (proc2.Length == 0)
                {
                    if (File.Exists(pathPlayExe))
                        Process.Start(pathPlayExe);
                }
                else
                {
                    MessageBox.Show("Игра уже запущена");
                }
            }
        }
    

        int RowIndex = 0;
        int ClickIndex = 0;

        public void AddonName_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveControl = null;
            if (panelAddon.Visible == true)
            {
                panelAddon.Visible = false;
                RowIndex = -1;
                ClickIndex = -1;
            }
            else
            {
                Label label = new Label();
                label = (Label)sender;
                string nameAddon = Regex.Match(label.Name, @"LabelName_(\w)+_row").Value.Replace("LabelName_", "").Replace("_row", "");
                int row = int.Parse(Regex.Match(label.Name, @"_row_\d*").Value.Replace("_row_", ""));//!!
                panelAddonReset();
                int index = DownloadAddonGitHub.GitHubs.FindIndex(find => find.Name == nameAddon);
                if (index != -1)
                {
                    
                  
                    buttonInstall.Text = $"Скачать\n{DownloadAddonGitHub.GitHubs[index].Name}";
                    ClickIndex = index;
                    RowIndex = row;
                    Point pos = new Point();
                    pos.Y = label.Parent.Location.Y;
                    if (pos.Y + panelAddon.Height > panelAddonsView.Height && pos.Y + panelAddon.Height - 120 < panelAddonsView.Height)
                    {
                        panelAddon.Location = new Point(220, pos.Y - 80);
                    }
                    else if (pos.Y + panelAddon.Height > panelAddonsView.Height)
                    {
                        panelAddon.Location = new Point(220, pos.Y - panelAddon.Height + 80);
                    }
                    else if (pos.Y + panelAddon.Height < panelAddonsView.Height)
                    {
                        panelAddon.Location = new Point(220, pos.Y + 40);
                    }
                    PanelDescription.Visible = false;
                    panelAddonButtonSet();
                    panelAddon.Visible = true;
                    panelAddon.BringToFront();
                }
            }
        }

        private void panelAddonButtonSet()
        {          
            if (DownloadAddonGitHub.GitHubs[ClickIndex].BugReport == "")
            {
                buttonReportBug.Enabled = false;
            }
            if (DownloadAddonGitHub.GitHubs[ClickIndex].Forum == "")
            {
                buttonForum.Enabled = false;
            }
            if (DownloadAddonGitHub.GitHubs[ClickIndex].GithubLink == "")
            {
                buttonGitHub.Enabled = false;
            }
        }
        private void panelAddonReset()
        {
            buttonReportBug.BackColor = Color.FromArgb(37, 35, 47);
            buttonForum.BackColor = Color.FromArgb(37, 35, 47);
            buttonGitHub.BackColor = Color.FromArgb(37, 35, 47);
            buttonReportBug.Enabled = true;
            buttonForum.Enabled = true;
            buttonGitHub.Enabled = true;
        }

        private async void buttonInstall_Click(object sender, EventArgs e)
        {
            panelAddon.Visible = false;
            await DownloadAddon3(DownloadAddonGitHub.GitHubs[ClickIndex], ClickIndex, RowIndex);
           
        }

        private void buttonReportBug_Click(object sender, EventArgs e)
        {
             if (DownloadAddonGitHub.GitHubs[ClickIndex].BugReport != "")
                Process.Start(DownloadAddonGitHub.GitHubs[ClickIndex].BugReport);
        }

        private void buttonForum_Click(object sender, EventArgs e)
        {
            if (DownloadAddonGitHub.GitHubs[ClickIndex].Forum != "")
              Process.Start(DownloadAddonGitHub.GitHubs[ClickIndex].Forum);
        }

        private void buttonGitHub_Click(object sender, EventArgs e)
        {
            if (DownloadAddonGitHub.GitHubs[ClickIndex].GithubLink != "")
               Process.Start(DownloadAddonGitHub.GitHubs[ClickIndex].GithubLink);

        }
      
        public async void AddonVersion_Click(object sender, EventArgs e)
        {
            Button Button = new Button();
            Button = (Button)sender;

            string nameAddon = Regex.Match(Button.Name, @"Button_(\w)+_row").Value.Replace("Button_", "").Replace("_row", "");
            int row = int.Parse(Regex.Match(Button.Name, @"_row_\d*").Value.Replace("_row_", ""));//??

            int index = DownloadAddonGitHub.GitHubs.FindIndex(find => find.Name == nameAddon);
            if (index != -1)
            {
                panelAddon.Visible = false;
                await DownloadAddon3(DownloadAddonGitHub.GitHubs[index], index, row);
            }
          
        }
        int NumberDownloadableAddons = 0;
        public async Task DownloadAddon3(GitHub gitHub, int index, int rowIndex)
        {
            try
            {
                panelAddons[rowIndex].progressBar.Maximum = 2;
                panelAddons[rowIndex].progressBar.Value = 0;
                panelAddons[rowIndex].progressBar.Visible = true;
                FormMainMenu.activity = "Cкачивания";
                NumberDownloadableAddons++;
                FormMainMenu.ButtonOff();
                ButtonOff();
                ActiveControl = null;
                panelAddons[rowIndex].AddonName.Text = $"Скачиваем {gitHub.Name}";
                panelAddons[rowIndex].progressBar.Value++;
                await downloadAddonGitHub.DownloadAddonGitHubTask(gitHub.Name, gitHub.GithubLink, gitHub.Branches);
                panelAddons[rowIndex].AddonName.Text = $"Распаковываем {gitHub.Name}";
                panelAddons[rowIndex].progressBar.Value++;
                await downloadAddonGitHub.GetAddon2(gitHub);
                DownloadAddonGitHub.GitHubs[index].MyVersion = downloadAddonGitHub.GetMyVersion(DownloadAddonGitHub.GitHubs[index].Directory, DownloadAddonGitHub.GitHubs[index].Regex, DownloadAddonGitHub.GitHubs[index].Replace);
                DownloadAddonGitHub.GitHubs[index].NeedUpdate = downloadAddonGitHub.GetNeedUpdate(DownloadAddonGitHub.GitHubs[index].Version, DownloadAddonGitHub.GitHubs[index].MyVersion, DownloadAddonGitHub.GitHubs[index].Blacklist);
                DownloadAddonGitHub.GitHubs[index].DownloadMyAddon = downloadAddonGitHub.GetNeedUpdate(DownloadAddonGitHub.GitHubs[index].Version, DownloadAddonGitHub.GitHubs[index].MyVersion, DownloadAddonGitHub.GitHubs[index].Blacklist);
                DownloadAddonGitHub.GitHubs[index].SavedVariables = downloadAddonGitHub.GetSavedVariables(DownloadAddonGitHub.GitHubs[index].Directory);
                DownloadAddonGitHub.GitHubs[index].SavedVariablesPerCharacter = downloadAddonGitHub.GetSavedVariablesPerCharacter(DownloadAddonGitHub.GitHubs[index].Directory);
                panelAddons[rowIndex].progressBar.Value = 0;
                panelAddons[rowIndex].progressBar.Visible = false;
                panelAddons[rowIndex].AddonName.Text = DownloadAddonGitHub.GitHubs[index].Name;
                panelAddons[rowIndex].AddonVersion.Text = "Актуальная: " + DownloadAddonGitHub.GitHubs[index].Version + "\n" + "У Вас: " + DownloadAddonGitHub.GitHubs[index].MyVersion;
               
                NumberDownloadableAddons--;
                if (NumberDownloadableAddons == 0)
                {
                    FormMainMenu.activity = null;
                    FormMainMenu.ButtonOn();
                    ButtonOn();
                    updatePanelAddonsView(false);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                FormMainMenu.labelInfo.Text = "Ошибка подключения";
            }
        }
        private void ButtonOn()
        {          
            button_update.Enabled = true;
        }

        private void ButtonOff()
        {        
            button_update.Enabled = false;
        }

       
    }
}
