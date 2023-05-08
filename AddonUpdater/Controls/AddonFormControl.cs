using AddonUpdater.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
        public bool myAddon;

        private DownloadAddonGitHub downloadAddonGitHub = new DownloadAddonGitHub();
        private PanelAddonSetings panelAddonSetings = new PanelAddonSetings();
        private List<AddonControl> addonControls = new List<AddonControl>();
        private string pictureBoxFollowUpdateState = null;

        public AddonFormControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.Selectable, false);
            UpdateStyles();
        }
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

                    SetSettingsPanelAddon();
                    DownloadAddonGitHub.UpdateInfo = true;
                    FillingAddonsPanel();

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
                    addonDropdown.Location = new Point(220, pos.Y - 90);
                }
                else if (pos.Y + addonDropdown.Height > panelAddonsView.Height)
                {
                    addonDropdown.Location = new Point(220, pos.Y - addonDropdown.Height + 90);
                }
                else if (pos.Y + addonDropdown.Height < panelAddonsView.Height)
                {
                    addonDropdown.Location = new Point(220, pos.Y + 30);
                }
                addonDropdown.SetAddon(addon, addonControls, this);

                addonDropdown.Visible = true;
                addonDropdown.BringToFront();
            }
        }

        private void DowloadButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (FormMainMenu.activity == null)
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
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (FormMainMenu.activity == null)
            {
                if (Directory.Exists(Properties.Settings.Default.PathWow))
                {
                    DownloadAddonGitHub.UpdateInfo = false;
                    UpdatePanelAddonsView();
                }
                else
                {
                    FormMainMenu.labelNeedUpdateMyAddon.Visible = false;
                    MessageBox.Show("Не найдена папка с игрой", "Предупреждение");
                }
            }
        }

        private void LauncherButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
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

                ContextMenuStripPaths.Show(pathsShowDowload, new Point(0, -pathsShowDowload.Height));
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
            DownloadAddonGitHub.UpdateInfo = false;
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
                    Name = gitHubs[i].Name,
                };
                panelAddonsView.Controls.Add(AddonControl);
                addonControls.Add(AddonControl);
            }

            panelAddonsView.AutoScroll = true;
           

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
                            PanelDescription.Size = new Size(PanelDescription.Width, (size / 800) + 20);
                            Point pos = new Point
                            {
                                Y = location.Y
                            };
                            if (pos.Y + PanelDescription.Height + 40 > panelAddonsView.Height)
                            {
                                PanelDescription.Location = new Point(0, pos.Y - PanelDescription.Height + 30);
                            }
                            else if (pos.Y + PanelDescription.Height < panelAddonsView.Height)
                            {
                                PanelDescription.Location = new Point(0, pos.Y + 70);
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
            pathsShowDowload.Visible = false;

            panelRightDowload.Visible = false;

            labelName.Width = 280;
            labelVersion.Width = 190;
            labelCategory.Width = 190;
            labelAuthor.Width = 190;

            launcherButton.Location = new Point(790, 445);
            updateButton.Location = new Point(840, 445);
        }

        private void SetSettingsPanelAddon()
        {
            int height = 50;
            panelAddonSetings.Name = new Label
            {
                Width = labelName.Width,
                Height = height,
                Visible = labelName.Visible
            };

            panelAddonSetings.Version = new Button
            {
                Width = labelVersion.Width,
                Height = height,
                Visible = labelVersion.Visible
            };
            panelAddonSetings.Version.FlatAppearance.BorderSize = 0;

            panelAddonSetings.Category = new Label
            {
                Width = labelCategory.Width,
                Height = height,
                Visible = labelCategory.Visible
            };

            panelAddonSetings.Author = new Label
            {
                Width = labelAuthor.Width,
                Height = height,
                Visible = labelAuthor.Visible
            };

            panelAddonSetings.ProgressBar = new ProgressBar
            {
                Width = labelName.Width,
                Height = height,
                Visible = false
            };

            panelAddonSetings.Delete = new Button
            {
                Width = 40,
                Height = height,
                Visible = labelDelete.Visible
            };
            panelAddonSetings.Delete.FlatAppearance.BorderSize = 0;

            panelAddonSetings.Track = new PictureBox
            {
                Width = 40,
                Height = height,
                Visible = pictureBoxFollowUpdate.Visible
            };

            if (myAddon)
            {
                if (DownloadAddonGitHub.GitHubs.FindAll(adoon => adoon.MyVersion != null).Count < 10)
                {
                    panelAddonSetings.Width = panelAddonsView.Width;
                }
                else
                {
                    panelAddonSetings.Width = panelAddonsView.Width - 20;

                }
            }
            else
            {
                if (DownloadAddonGitHub.GitHubs.Count < 10)
                {
                    panelAddonSetings.Width = panelAddonsView.Width;
                }
                else
                {
                    panelAddonSetings.Width = panelAddonsView.Width - 20;
                }

            }


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
            pathsShowDowload.Enabled = true;
        }

        public void ButtonOff()
        {
            dowloadButton.Enabled = false;
            updateButton.Enabled = false;
            pictureBoxFollowUpdate.Enabled = false;
            pathsShowDowload.Enabled = false;
        }
        #endregion

        #region Update
        public async void UpdatePanelAddonsView()
        {

            FormMainMenu.ButtonOff();
            ButtonOff();
            if (DownloadAddonGitHub.UpdateInfo)
            {
                UpdatePanelAddons();
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
                UpdatePanelAddons();
                FormMainMenu.progressBar1.Value++;
                FormMainMenu.progressBar1.Value = 0;
                FormMainMenu.labelInfo.Text = "";
                FormMainMenu.activity = null;
            }


            ButtonOn();
            FormMainMenu.ButtonOn();
            FormMainMenu.SetNotificationsAddons();

        }

        public void UpdatePanelAddons()
        {
            if (myAddon)
            {
                List<GitHub> gitHubs = DownloadAddonGitHub.GitHubs.FindAll(f => f.MyVersion != null);
                if (gitHubs.Count != addonControls.Count)
                {
                    UpdateControlAddon(gitHubs);
                    PanelDescription.Visible = false;
                    addonDropdown.Visible = false;
                    deleteSettings.Visible = false;
                }
                else
                {
                    for (int i = 0; i < addonControls.Count; i++)
                    {
                        addonControls[i].UpdateControl(i);
                    }
                }

            }
            else
            {
                List<GitHub> gitHubs = DownloadAddonGitHub.GitHubs.FindAll(f => f.MyVersion == null);

                if (gitHubs.Count != addonControls.Count)
                {
                    UpdateControlAddon(gitHubs);

                    PanelDescription.Visible = false;
                    addonDropdown.Visible = false;
                    deleteSettings.Visible = false;
                }
                else
                {
                    for (int i = 0; i < addonControls.Count; i++)
                    {
                        addonControls[i].UpdateControl(i);
                    }
                }

            }
            addonControls.Sort((a, b) => a.Name.CompareTo(b.Name));
            panelAddonsView.AutoScroll = true;
           

        }

        private void UpdateControlAddon(List<GitHub> gitHubs)
        {
            List<AddonControl> gitHubsDelete = new List<AddonControl>();
            for (int i = 0; i < addonControls.Count; i++)
            {
                if (gitHubs.FindIndex(addon => addon.Name == addonControls[i].addon.Name) == -1)
                {
                    gitHubsDelete.Add(addonControls[i]);
                    if (myAddon) addonControls[i].UnFollowUpdate();
                    panelAddonsView.Controls.Remove(addonControls[i]);
                   addonControls.Remove(addonControls[i]);
                    i--;

                }
            }

            List<AddonControl> gitHubsAdd = new List<AddonControl>();

            
            for (int i = 0; i < gitHubs.Count; i++)
            {
                int index = addonControls.FindIndex(control => control.Name == gitHubs[i].Name);
                if (index > -1)
                {

                    int row = gitHubsDelete.FindAll(addon => addon.row < addonControls[index].row).Count();
                    if (row > -1)
                    {
                        addonControls[index].Location = new Point(0, addonControls[index].Location.Y - (row * 40));
                        addonControls[index].UpdateControl(i);
                    }

                    row = gitHubsAdd.FindAll(addon => addon.row < addonControls[index].row).Count();
                    if (row > -1)
                    {
                        addonControls[index].Location = new Point(0, addonControls[index].Location.Y + (row * 40));
                        addonControls[index].UpdateControl(i);
                    }

                }
                else
                {
                    Point location = new Point(0, 0);
                    if (i > 0)
                    {
                        AddonControl control = addonControls.Find(ctrl => ctrl.addon.Name == gitHubs[i - 1].Name);
                        location = new Point(0, control.Location.Y + 40);
                    }

                    AddonControl AddonControl = new AddonControl(gitHubs[i], panelAddonSetings, this, i)
                    {
                        Location = location,
                        Name = gitHubs[i].Name,
                    };
                    if (myAddon == false)
                        AddonControl.UnFollowUpdate();
                    panelAddonsView.Controls.Add(AddonControl);
                    addonControls.Add(AddonControl);
                    gitHubsAdd.Add(AddonControl);
                }
            }


        }

        #endregion

    }
}
