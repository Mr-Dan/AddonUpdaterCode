using AddonUpdater.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddonUpdater.Controls
{
    public partial class AddonFormControl : UserControl
    {
        public bool AllUpdate = false;
        public int NumberDownloadableAddons = 0;
        public FormMainMenu FormMainMenu;
        public AddonDropdownControl addonDropdown;
        public AddonDeleteSettingsControl deleteSettings;

        private DownloadAddonGitHub downloadAddonGitHub = new DownloadAddonGitHub();
        //private List<PanelAddon> panelAddons = new List<PanelAddon>();
        private PanelAddonSetings panelAddonSetings = new PanelAddonSetings();
        private int myCountAddon = 0;
        private List<AddonControl> addonControls = new List<AddonControl>();
        private bool myAddon;
        private string pictureBoxFollowUpdateState = null;

        public AddonFormControl(FormMainMenu owner, bool myAddon)
        {
            FormMainMenu = owner;
            this.myAddon = myAddon;
            InitializeComponent();

            addonDropdown = new AddonDropdownControl();
            Controls.Add(addonDropdown);
            addonDropdown.Visible = false;

            deleteSettings = new AddonDeleteSettingsControl();
            Controls.Add(deleteSettings);
            deleteSettings.Visible = false;
            deleteSettings.Location = new Point(350, 150);

            if (myAddon)
            {
                SetMyAddon();
                addonDropdown.SetMyAddons();
            }
            else
            {
                SetAllAddon();
                addonDropdown.SetAllAddons();
            }
            if (Properties.Settings.Default.PathWow != null)
            {
                if (Directory.Exists(Properties.Settings.Default.PathWow))
                {
                    if (FormMainMenu.progressBar1.Visible == false)
                    {
                        FormMainMenu.progressBar1.Visible = true;
                        FormMainMenu.labelInfo.Visible = true;
                    }

                    
                    //panelAddonsView.AutoScroll = true;
                    SetSettingsPanelAddon();
                    myCountAddon = DownloadAddonGitHub.GitHubs.FindAll(count => count.MyVersion != null).Count;
                    DownloadAddonGitHub.UpdateInfo = true;
                    UpdatePanelAddonsView();
                }
                else
                {
                    FormMainMenu.labelNeedUpdateMyAddon.Visible = false;
                    MessageBox.Show("Не найдена папка с игрой", "Предупреждение");
                }

            }
            else
            {
                MessageBox.Show("Укажите путь к игре в настройках", "Предупреждение");
            }
        }


        private void AddonFormControls_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PathsWow.Contains(Properties.Settings.Default.PathWow) == false)
            {
                Properties.Settings.Default.PathsWow.Add(Properties.Settings.Default.PathWow);

            }

            if (Properties.Settings.Default.PathsWow.Contains("Dan") && Properties.Settings.Default.PathsWow.Count > 1)
                Properties.Settings.Default.PathsWow.Remove("Dan");
        }

        private async void AddonDownload()
        {
            AllUpdate = true;
            FormMainMenu.activity = "Cкачивания";
            ButtonOff();
            await DownloadAddon();
            DownloadAddonGitHub.UpdateInfo = true;
            UpdatePanelAddonsView();
            FormMainMenu.activity = null;
            ButtonOn();
            AllUpdate = false;
        }

        private async Task DownloadAddon()
        {
            try
            {
                DownloadAddonGitHub.NeedUpdate.Clear();
                DownloadAddonGitHub.NeedUpdate = DownloadAddonGitHub.GitHubs.FindAll(find => find.NeedUpdate == true);
                if (DownloadAddonGitHub.NeedUpdate.Count > 0)
                {
                    FormMainMenu.progressBar1.Value = 0;
                    FormMainMenu.progressBar1.Maximum = DownloadAddonGitHub.NeedUpdate.Count;
                    for (int i = 0; i < DownloadAddonGitHub.NeedUpdate.Count; i++)
                    {
                        FormMainMenu.labelInfo.Text = DownloadAddonGitHub.NeedUpdate[i].Name;
                        await downloadAddonGitHub.DownloadAddonGitHubTask(DownloadAddonGitHub.NeedUpdate[i].Name, DownloadAddonGitHub.NeedUpdate[i].GithubLink, DownloadAddonGitHub.NeedUpdate[i].Branches);
                        FormMainMenu.progressBar1.Value++;
                    }
                    FormMainMenu.labelInfo.Text = "Распаковка Аддонов";
                    await downloadAddonGitHub.GetAddon();
                    FormMainMenu.progressBar1.Value = 0;
                    FormMainMenu.labelInfo.Text = "";
                }
            }
            catch
            {
                FormMainMenu.progressBar1.Value = 0;
                FormMainMenu.labelInfo.Text = "Ошибка подключения";
                FormMainMenu.activity = null;
                FormMainMenu.ButtonOn();
                ButtonOn();
            }
        }

        #region Click
        public string lastAddon = null;
        public void AddonName_MouseClick(GitHub addon, Point location, AddonControl addonControls)
        {
            deleteSettings.Visible = false;
            PanelDescription.Visible = false;
            if (lastAddon == addon.Name)
            {
                addonDropdown.Visible = false;
                lastAddon = null;
            }
            else
            {
                lastAddon = addon.Name;
                Point pos = new Point
                {
                    Y = location.Y
                };
                if (pos.Y + addonDropdown.Height > panelAddonsView.Height && pos.Y + addonDropdown.Height - 120 < panelAddonsView.Height)
                {
                    addonDropdown.Location = new Point(220, pos.Y - 80);
                }
                else if (pos.Y + addonDropdown.Height > panelAddonsView.Height)
                {
                    addonDropdown.Location = new Point(220, pos.Y - addonDropdown.Height + 80);
                }
                else if (pos.Y + addonDropdown.Height < panelAddonsView.Height)
                {
                    addonDropdown.Location = new Point(220, pos.Y + 40);
                }
                addonDropdown.SetAddon(addon, addonControls, this);
                
                addonDropdown.Visible = true;
                addonDropdown.BringToFront();
            }
        }

        private void DowloadButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Properties.Settings.Default.PathWow))
            {
               
                if (DownloadAddonGitHub.GitHubs.FindAll(find => find.NeedUpdate == true).Count > 0)
                {
                    FormMainMenu.ButtonOff();
                    AddonDownload();
                }
                else
                {
                    MessageBox.Show("Вы используете актуальные версии аддонов", "Ошибка");
                }
            }
            else
            {
                FormMainMenu.labelNeedUpdateMyAddon.Visible = false;
                MessageBox.Show("Не найдена папка с игрой", "Предупреждение");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Properties.Settings.Default.PathWow))
            {
                ActiveControl = null;
                FormMainMenu.ButtonOff();
                ButtonOff();
                DownloadAddonGitHub.UpdateInfo = false;
                UpdatePanelAddonsView();
            }
            else
            {
                FormMainMenu.labelNeedUpdateMyAddon.Visible = false;
                MessageBox.Show("Не найдена папка с игрой", "Предупреждение");
            }
        }

        private void LauncherButton_Click(object sender, EventArgs e)
        {
            string pathLauncher = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Programs\\sirus-open-launcher\\Sirus Launcher.exe";
            string pathPlayExe = Properties.Settings.Default.PathWow + "\\run.exe";
            Process[] proc = Process.GetProcessesByName("Sirus Launcher");
            Process[] proc2 = Process.GetProcessesByName("run");
            if (proc.Length == 0 && Properties.Settings.Default.LauncherOpen == true)
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

        private void PictureBoxFollowUpdate_Click(object sender, EventArgs e)
        {
            if (pictureBoxFollowUpdateState.Contains("open"))
            {
                for (int i = 0; i < addonControls.Count; i++)
                {
                    if (Properties.Settings.Default.UpdateAddon.Contains(addonControls[i].addon.Name))
                    {
                        int index = DownloadAddonGitHub.GitHubs.FindIndex(find => find.Name == addonControls[i].addon.Name);
                        if (index != -1)
                        {
                            addonControls[i].FollowUpdate();
                        }
                    }
                }
            }
            else if (pictureBoxFollowUpdateState.Contains("closed") || pictureBoxFollowUpdateState.Contains("mixed"))
            {
                for (int i = 0; i < addonControls.Count; i++)
                {
                    if (Properties.Settings.Default.UpdateAddon.Contains(addonControls[i].addon.Name) == false)
                    {
                        int index = DownloadAddonGitHub.GitHubs.FindIndex(find => find.Name == addonControls[i].addon.Name);
                        if (index != -1)
                        {
                            addonControls[i].FollowUpdate();
                        }
                    }
                }
            }
            SetPictureBoxFollowUpdate();
        }
        bool isShowContextMenuStripPaths = false;
        private void PathsShowButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (isShowContextMenuStripPaths == false)
            {
                ContextMenuStripPaths.Items.Clear();
                foreach (string text in Properties.Settings.Default.PathsWow)
                {
                    if (text != null)
                    {
                        ContextMenuStripPaths.Items.Add(text);
                        if (text == Properties.Settings.Default.PathWow)
                        {
                            ContextMenuStripPaths.Items[ContextMenuStripPaths.Items.Count - 1].BackColor = Color.FromArgb(44, 177, 128);
                            ContextMenuStripPaths.Items[ContextMenuStripPaths.Items.Count - 1].ForeColor = Color.White;

                        }
                    }
                }

                ContextMenuStripPaths.Show(pathsShowButton, new Point(0, -pathsShowButton.Height));
                isShowContextMenuStripPaths = true;
            }
            else
            {
                ContextMenuStripPaths.Hide();
                isShowContextMenuStripPaths = false;
                ButtonReset();
            }
        }


        private void ContextMenuStripPaths_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Properties.Settings.Default.PathWow = e.ClickedItem.Text;
            Properties.Settings.Default.Save();
            ActiveControl = null;
            FormMainMenu.ButtonOff();
            ButtonOff();
            DownloadAddonGitHub.UpdateInfo = false;
            UpdatePanelAddonsView();
        }
        #endregion

        private void FillingAddonsPanel()
        {
            panelAddonsView.Controls.Clear();
            addonControls.Clear();
            List<GitHub> gitHubs;
            if (myAddon)
            {
                gitHubs = new List<GitHub>(DownloadAddonGitHub.GitHubs.FindAll(f => f.MyVersion != null));
            }
            else
            {
                gitHubs = new List<GitHub>(DownloadAddonGitHub.GitHubs.FindAll(f => f.MyVersion == null));

            }
            for (int i = 0; i < gitHubs.Count; i++)
            {
                Point location = new Point(0, i * 40);
                AddonControl AddonControl = new AddonControl(gitHubs[i], panelAddonSetings, this, i)
                {
                    Location = location,
                    Name= gitHubs[i].Name
                };
                panelAddonsView.Controls.Add(AddonControl);
                addonControls.Add(AddonControl);

            }
        }

        #region MouseMove/Leave
        private void ContextMenuStripPaths_MouseLeave(object sender, EventArgs e)
        {
            ButtonReset();
            ContextMenuStripPaths.Hide();
            isShowContextMenuStripPaths = false;
        }

        public void NameAddon_MouseLeave()
        {
            PanelDescription.Visible = false;
            LabelDescription.Text = null;
        }

        public void NameAddon_MouseHover(GitHub addon, Point location)
        {
            
            if (addonDropdown.Visible == false && deleteSettings.Visible == false)
            {
                if (Properties.Settings.Default.DescriptionBool)
                {
                    if (addon.Description != string.Empty)
                        if (PanelDescription.Visible == false)
                        {
                            LabelDescription.Text = addon.Description;
                            Size len = TextRenderer.MeasureText(addon.Description, LabelDescription.Font);
                            int size = len.Width * len.Height;
                            PanelDescription.Size = new Size(780, (size / 800) + 20);
                            Point pos = new Point
                            {
                                Y = location.Y
                            };
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
        #endregion

        #region Set/Reset
        private void ButtonReset()
        {
            for (int i = 0; i < ContextMenuStripPaths.Items.Count; i++)
            {
                ContextMenuStripPaths.Items[ContextMenuStripPaths.Items.Count - 1].BackColor = Color.LightGray;
                ContextMenuStripPaths.Items[ContextMenuStripPaths.Items.Count - 1].ForeColor = Color.White;
            }

        }

        private void SetMyAddon()
        {
            labelName.Visible = true;
            pictureBoxFollowUpdate.Visible = true;
            labelVersion.Visible = true;
            labelCategory.Visible = true;
            labelAuthor.Visible = true;
            labelDelete.Visible = true;
            SetPictureBoxFollowUpdate();
        }

        private void SetAllAddon()
        {
            labelName.Visible = true;
            pictureBoxFollowUpdate.Visible = false;
            labelVersion.Visible = true;
            labelCategory.Visible = true;
            labelAuthor.Visible = true;
            labelDelete.Visible = false;

            dowloadButton.Visible = false;
            pathsShowButton.Visible = false;

            labelName.Width = 320;
            labelVersion.Width = 190;
            labelCategory.Width = 190;
            labelAuthor.Width = 190;

            launcherButton.Location = new Point(790, 445);
            updateButton.Location = new Point(840, 445);    
        }

        private void SetSettingsPanelAddon()
        {

            panelAddonSetings.Name = new Label
            {
                Width = labelName.Width - 40,
                Height = 40,
                Visible = labelName.Visible
            };

            panelAddonSetings.Version = new Button
            {
                Width = labelVersion.Width,
                Height = 40,
                Visible = labelVersion.Visible
            };
            panelAddonSetings.Version.FlatAppearance.BorderSize = 0;

            panelAddonSetings.Category = new Label
            {
                Width = labelCategory.Width,
                Height = 40,
                Visible = labelCategory.Visible
            };

            panelAddonSetings.Author = new Label
            {
                Width = labelAuthor.Width,
                Height = 40,
                Visible = labelAuthor.Visible
            };

            panelAddonSetings.ProgressBar = new ProgressBar
            {
                Width = labelName.Width,
                Height = 10,
                Visible = false
            };

            panelAddonSetings.Delete = new Button
            {
                Width = 40,
                Height = 40,
                Visible = labelDelete.Visible
            };
            panelAddonSetings.Delete.FlatAppearance.BorderSize = 0;

            panelAddonSetings.Track = new PictureBox
            {
                Width = 40,
                Height = 40,
                Visible = pictureBoxFollowUpdate.Visible
            };

            panelAddonSetings.Width = panelAddonsView.Width + 5;

        }

        public void SetPictureBoxFollowUpdate()
        {
            int follow = 0;
            int unFollow = 0;
            int countMyAddon = 0;
            for (int i = 0; i < DownloadAddonGitHub.GitHubs.Count; i++)
            {
                if (DownloadAddonGitHub.GitHubs[i].MyVersion != null)
                {
                    if (Properties.Settings.Default.UpdateAddon.Contains(DownloadAddonGitHub.GitHubs[i].Name))
                    {
                        follow++;
                    }
                    else
                    {
                        unFollow++;
                    }
                    countMyAddon++;
                }
            }
            if (follow == countMyAddon)
            {
                pictureBoxFollowUpdateState = "open";
                pictureBoxFollowUpdate.BackgroundImage = Properties.Resources.eyes_open;
            }
            else if (unFollow == countMyAddon)
            {
                pictureBoxFollowUpdateState = "closed";
                pictureBoxFollowUpdate.BackgroundImage = Properties.Resources.eyes_closed;
            }
            else
            {
                pictureBoxFollowUpdateState = "mixed";
                pictureBoxFollowUpdate.BackgroundImage = Properties.Resources.eyes_mixed;
            }

        }

        public void ButtonOn()
        {
            dowloadButton.Enabled = true;
            updateButton.Enabled = true;
            pictureBoxFollowUpdate.Enabled = true;
            pathsShowButton.Enabled = true;
        }

        public void ButtonOff()
        {
            dowloadButton.Enabled = false;
            updateButton.Enabled = false;
            pictureBoxFollowUpdate.Enabled = false;
            pathsShowButton.Enabled = false;
        }
        #endregion

        #region Update
        public async void UpdatePanelAddonsView()
        {

            FormMainMenu.ButtonOff();
            ButtonOff();
            if (DownloadAddonGitHub.UpdateInfo)
            {
                int myCountAddonGitHub = DownloadAddonGitHub.GitHubs.FindAll(count => count.MyVersion != null).Count;
                if (myCountAddon != myCountAddonGitHub)
                {
                    myCountAddon = myCountAddonGitHub;
                    FillingAddonsPanel();
                }
                else
                {
                    UpdateInfoAddonsPabel();
                    FillingAddonsPanel();
                }
                DownloadAddonGitHub.UpdateInfo = false;
            }
            else
            {
                FormMainMenu.labelInfo.Text = "Обновление";
                FormMainMenu.activity = "обновления";
                FormMainMenu.progressBar1.Value = 0;
                FormMainMenu.progressBar1.Maximum = 2;
                FormMainMenu.progressBar1.Value++;
                await downloadAddonGitHub.Aupdatecheck();
                FillingAddonsPanel();
                FormMainMenu.progressBar1.Value++;
                FormMainMenu.progressBar1.Value = 0;
                FormMainMenu.labelInfo.Text = "";
                FormMainMenu.activity = null;
            }

            if (Properties.Settings.Default.AutoUpdateBool == true && DownloadAddonGitHub.Update == true)
            {
                FormMainMenu.ButtonOff();
                AddonDownload();
            }
            ButtonOn();
            FormMainMenu.ButtonOn();
            FormMainMenu.SetNotificationsAddons();
        }

        private void UpdateInfoAddonsPabel()
        {
            List<GitHub> git = DownloadAddonGitHub.GitHubs.FindAll(find => find.NeedUpdate == true);
            for (int i = 0; i < git.Count; i++)
            {
                int index = DownloadAddonGitHub.GitHubs.FindIndex(indx => indx.Name == git[i].Name);
                if (index != -1)
                {
                    DownloadAddonGitHub.GitHubs[index].MyVersion = downloadAddonGitHub.GetMyVersion(DownloadAddonGitHub.GitHubs[index].Directory, DownloadAddonGitHub.GitHubs[index].Regex);
                    DownloadAddonGitHub.GitHubs[index].NeedUpdate = downloadAddonGitHub.GetNeedUpdate(DownloadAddonGitHub.GitHubs[index].Version, DownloadAddonGitHub.GitHubs[index].MyVersion, downloadAddonGitHub.GetAddonUpdate(DownloadAddonGitHub.GitHubs[index].Name));
                    DownloadAddonGitHub.GitHubs[index].SavedVariables = downloadAddonGitHub.GetSavedVariables(DownloadAddonGitHub.GitHubs[index].Directory);
                    DownloadAddonGitHub.GitHubs[index].SavedVariablesPerCharacter = downloadAddonGitHub.GetSavedVariablesPerCharacter(DownloadAddonGitHub.GitHubs[index].Directory);
                }
            }
        }

        #endregion

    }
}
