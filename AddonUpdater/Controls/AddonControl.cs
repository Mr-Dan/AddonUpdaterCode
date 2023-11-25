using AddonUpdater.Controlers;
using AddonUpdater.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddonUpdater.Controls
{
    public partial class AddonControl : UserControl
    {
        public GitHub addon;
        public int row = 0;

        private PanelAddonSetings setings;
        private AddonFormControl addonForm;
        private DownloadAddonGitHub downloadAddonGitHub = new ();
       

        public AddonControl(GitHub addon, PanelAddonSetings setings, AddonFormControl addonForm, int row)
        {
            InitializeComponent();
            this.addon = addon;
            this.setings = setings;
            this.addonForm = addonForm;
            this.row = row;
            SetControls();

            SetStyle(ControlStyles.Selectable, false);
        }

        private void AddonsRowsForeColorUpdate()
        {
            if (addon.NeedUpdate == false)
            {
                nameAddon.ForeColor = Color.FromArgb(44, 42, 63);
                versionButton.ForeColor = Color.FromArgb(44, 42, 63);
            }
        }

        #region Click
        private void NameAddon_Click(object sender, EventArgs e)
        {
            addonForm.AddonName_MouseClick(addon, Location, this);
        }

        bool download = false;
        private async void VersionButton_Click(object sender, EventArgs e)
        {
            if (addonForm.AllUpdate == false)
            {
                addonForm.addonDropdown.Visible = false;

                if (addonForm.myAddon)
                {
                    if (!download)
                    {
                        download = true;
                        await DownloadAddon();
                        download = false;
                    }
                    else
                    {
                        MessageBox.Show("Аддон устанавливается");
                    }
                }
                else
                {
                    if (!download)
                    {
                        download = true;
                        await DownloadAddon();
                        if (!AddonUpdaterSettingApp.SettingsApp.UpdateAddon.Contains(addon.Name))
                        {
                            FollowUpdate();

                        }
                        addonForm.UpdatePanelAddons();
                        download = false;
                    }
                    else
                    {
                        MessageBox.Show("Аддон устанавливается");
                    }
                }

            }
            else
            {
                MessageBox.Show("Дождитесь обновления аддонов");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteAddon();
        }

        private void TrackImage_Click(object sender, EventArgs e)
        {
            FollowUpdate();
        }
        #endregion

        public async Task DownloadAddon()
        {
            try
            {
                addonProgressBar.Maximum = 2;
                addonProgressBar.Value = 0;
                addonProgressBar.Visible = true;
                FormMainMenu.activity = "Cкачивания";
                addonForm.NumberDownloadableAddons++;
                addonForm.FormMainMenu.ButtonOff();
                addonForm.ButtonOff();
                ActiveControl = null;
                addonProgressBar.Value++;
                await downloadAddonGitHub.DownloadAddonGitHubTask(addon.Name, addon.GithubLink, addon.Branches);
                addonProgressBar.Value++;
                await downloadAddonGitHub.GetAddonAsync(addon);
                addon.MyVersion = downloadAddonGitHub.GetMyVersion(addon.Directory, addon.Regex);
                addon.NeedUpdate = downloadAddonGitHub.GetNeedUpdate(addon.Version, addon.MyVersion, downloadAddonGitHub.GetAddonUpdate(addon.Name));
                addon.SavedVariables = downloadAddonGitHub.GetSavedVariables(addon.Directory);
                addon.SavedVariablesPerCharacter = downloadAddonGitHub.GetSavedVariablesPerCharacter(addon.Directory);

                /*int index = DownloadAddonGitHub.GitHubs.FindIndex(fAddon => fAddon.Name == addon.Name);

                if (index >= 0)
                {
                    DownloadAddonGitHub.GitHubs[index].MyVersion = addon.MyVersion;
                    DownloadAddonGitHub.GitHubs[index].NeedUpdate = addon.NeedUpdate;
                    DownloadAddonGitHub.GitHubs[index].SavedVariables = addon.SavedVariables;
                    DownloadAddonGitHub.GitHubs[index].SavedVariablesPerCharacter = addon.SavedVariablesPerCharacter;
                }*/
                addonProgressBar.Value = 0;
                addonProgressBar.Visible = false;
                SetVersion();
                AddonsRowsForeColorUpdate();
                versionButton.Enabled = true;
                addonForm.NumberDownloadableAddons--;
                if (addonForm.NumberDownloadableAddons == 0)
                {
                    addonForm.FormMainMenu.SetNotificationsAddons();
                    FormMainMenu.activity = null;
                    addonForm.FormMainMenu.ButtonOn();
                    addonForm.ButtonOn();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                addonForm.FormMainMenu.labelInfo.Text = "Ошибка подключения";
                FormMainMenu.activity = null;
                addonForm.FormMainMenu.ButtonOn();
                addonForm.ButtonOn();
            }
        }

        public void DeleteAddon()
        {
            if (FormMainMenu.activity == null)
            {
                DialogResult dialogResult = MessageBox.Show(
                    $"Вы точно хотите удалить {addon.Name}?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    downloadAddonGitHub.DeleteAddon(addon);
                    addon.MyVersion = downloadAddonGitHub.GetMyVersion(addon.Directory, addon.Regex);
                    addon.NeedUpdate = false;
                    DownloadAddonGitHub.UpdateInfo = true;
                    UnFollowUpdate();
                    addonForm.UpdatePanelAddons();
                    Visible = false;
                }
            }
        }

        public void UnFollowUpdate()
        {
            if (AddonUpdaterSettingApp.SettingsApp.UpdateAddon.Contains(addon.Name))
            {
                while (AddonUpdaterSettingApp.SettingsApp.UpdateAddon.Contains(addon.Name))
                {
                    AddonUpdaterSettingApp.SettingsApp.UpdateAddon.Remove(addon.Name);
                }
            }
            AddonUpdaterSettingApp.Save();

            trackImage.BackgroundImage = downloadAddonGitHub.GetAddonUpdate(addon.Name) ? Properties.Resources.eyes_open : Properties.Resources.eyes_closed;
            addonForm.SetPictureBoxFollowUpdate();
            addonForm.FormMainMenu.SetNotificationsAddons();
        }
        public void FollowUpdate()
        {
            if (AddonUpdaterSettingApp.SettingsApp.UpdateAddon.Contains(addon.Name))
            {
                while (AddonUpdaterSettingApp.SettingsApp.UpdateAddon.Contains(addon.Name))
                {
                    AddonUpdaterSettingApp.SettingsApp.UpdateAddon.Remove(addon.Name);
                }
            }
            else
            {
                AddonUpdaterSettingApp.SettingsApp.UpdateAddon.Add(addon.Name);
            }
            AddonUpdaterSettingApp.Save();

            addon.NeedUpdate = downloadAddonGitHub.GetNeedUpdate(addon.Version, addon.MyVersion, downloadAddonGitHub.GetAddonUpdate(addon.Name));

            SetForeColor();
            SetVersion();

            trackImage.BackgroundImage = downloadAddonGitHub.GetAddonUpdate(addon.Name) ? Properties.Resources.eyes_open : Properties.Resources.eyes_closed;
            addonForm.SetPictureBoxFollowUpdate();
            addonForm.FormMainMenu.SetNotificationsAddons();

        }

        #region MouseHover
        private void DeleteButton_MouseHover(object sender, EventArgs e)
        {
            ActiveControl = null;
            addonForm.ToolTip.Show("Нажмите для удаления данного аддона", (Button)sender);
        }

        private void TrackImage_MouseHover(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (downloadAddonGitHub.GetAddonUpdate(addon.Name))
            {
                addonForm.ToolTip.Show("Программа следит за обновлениями данного аддона.", (PictureBox)sender);
            }
            else
            {
                addonForm.ToolTip.Show("Программа НЕ следит за обновлениями данного аддона.", (PictureBox)sender);
            }

        }

        private void VersionButton_MouseHover(object sender, EventArgs e)
        {
            addonForm.ToolTip.Show("Нажмите для обновления аддона", (Button)sender);
        }

        private void NameAddon_MouseHover(object sender, EventArgs e)
        {
            addonForm.NameAddon_MouseHover(addon, Location);
        }
        private void NameAddon_MouseLeave(object sender, EventArgs e)
        {
            addonForm.NameAddon_MouseLeave();
        }
        #endregion


        public void Remove()
        {

            //addon.MyVersion = downloadAddonGitHub.GetMyVersion(addon.Directory, addon.Regex);
            //addon.NeedUpdate = downloadAddonGitHub.GetNeedUpdate(addon.Version, addon.MyVersion, downloadAddonGitHub.GetAddonUpdate(addon.Name));
        }

        #region Set
        private void SetControls()
        {
            nameAddon.Text = addon.Name;
            categoryAddon.Text = addon.Category;
            authorAddon.Text = addon.Author;

            nameAddon.Width = setings.Name.Width;
            addonProgressBar.Width = setings.Name.Width;
            versionButton.Width = setings.Version.Width;
            categoryAddon.Width = setings.Category.Width;
            authorAddon.Width = setings.Author.Width;
            Width = setings.Width;

            nameAddon.Visible = setings.Name.Visible;
            versionButton.Visible = setings.Version.Visible;
            categoryAddon.Visible = setings.Category.Visible;
            authorAddon.Visible = setings.Author.Visible;
            trackImage.Visible = setings.Track.Visible;
            deleteButton.Visible = setings.Delete.Visible;

            SetBackColor();
            SetForeColor();
            SetVersion();

            trackImage.BackgroundImage = downloadAddonGitHub.GetAddonUpdate(addon.Name) ? Properties.Resources.eyes_open : Properties.Resources.eyes_closed;
        }

        public void UpdateControl(int row)
        {

            nameAddon.Text = addon.Name;
            categoryAddon.Text = addon.Category;
            authorAddon.Text = addon.Author;
            this.row = row;
            SetBackColor();
            SetForeColor();
            SetVersion();

            trackImage.BackgroundImage = downloadAddonGitHub.GetAddonUpdate(addon.Name) ? Properties.Resources.eyes_open : Properties.Resources.eyes_closed;
        }

        private void SetBackColor()
        {
            if (row % 2 == 0)
            {
                BackColor = Color.FromArgb(223, 225, 229);
                trackImage.BackColor = Color.FromArgb(223, 225, 229);
            }
            else
            {
                BackColor = Color.FromArgb(239, 240, 242);
                trackImage.BackColor = Color.FromArgb(239, 240, 242);

            }
        }

        private void SetForeColor()
        {
            if (addon.NeedUpdate == true)
            {
                nameAddon.ForeColor = Color.FromArgb(166, 0, 0);
                versionButton.ForeColor = Color.FromArgb(166, 0, 0);
            }
            else
            {
                nameAddon.ForeColor = Color.FromArgb(44, 42, 63);
                versionButton.ForeColor = Color.FromArgb(44, 42, 63);
            }
        }

        private void SetVersion()
        {
            if (addon.MyVersion != null)
            {
                if (addon.NeedUpdate)
                {
                    versionButton.Text = "Актуальная: " + addon.Version + "\n" + "У Вас: " + addon.MyVersion;
                    versionButton.Enabled = true;
                }
                else
                {
                    if (downloadAddonGitHub.GetAddonUpdate(addon.Name))
                    {
                        if (AddonUpdaterSettingApp.SettingsApp.LastUpdate.FindIndex(f => f.AddonName == addon.Name) > -1) versionButton.Text = "Актуальная: " + addon.Version + "\n" + AddonUpdaterSettingApp.SettingsApp.LastUpdate[AddonUpdaterSettingApp.SettingsApp.LastUpdate.FindIndex(f => f.AddonName == addon.Name)].LastUpdate;
                        else versionButton.Text = "Актуальная: " + addon.Version;
                        versionButton.Enabled = true;
                    }
                    else
                    {
                        versionButton.Text = "Не слежу за обновлениями этого аддона";
                        versionButton.Enabled = false;
                    }
                }
            }
            else
            {
                versionButton.Text = "Актуальная: " + addon.Version;
                versionButton.Enabled = true;
            }

            #endregion

        }

    }
}
