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

        private PanelAddonSetings setings;
        private AddonFormControl addonForm;
        private DownloadAddonGitHub downloadAddonGitHub = new DownloadAddonGitHub();
        private int row = 0;

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

        private async void VersionButton_Click(object sender, EventArgs e)
        {
            if (addonForm.AllUpdate == false)
            {
                addonForm.addonDropdown.Visible = false;
                await DownloadAddon();
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
                await downloadAddonGitHub.GetAddon(addon);
                addon.MyVersion = downloadAddonGitHub.GetMyVersion(addon.Directory, addon.Regex);
                addon.NeedUpdate = downloadAddonGitHub.GetNeedUpdate(addon.Version, addon.MyVersion, downloadAddonGitHub.GetAddonUpdate(addon.Name));
                addon.SavedVariables = downloadAddonGitHub.GetSavedVariables(addon.Directory);
                addon.SavedVariablesPerCharacter = downloadAddonGitHub.GetSavedVariablesPerCharacter(addon.Directory);
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
                    DownloadAddonGitHub.UpdateInfo = true;
                    addonForm.UpdatePanelAddonsView();
                    Visible = false;
                }
            }
        }

        public void FollowUpdate()
        {
            if (Properties.Settings.Default.UpdateAddon.Contains(addon.Name))
            {
                while (Properties.Settings.Default.UpdateAddon.Contains(addon.Name))
                {
                    Properties.Settings.Default.UpdateAddon.Remove(addon.Name);
                }
            }
            else
            {
                Properties.Settings.Default.UpdateAddon.Add(addon.Name);
            }
            Properties.Settings.Default.Save();

            addon.NeedUpdate = downloadAddonGitHub.GetNeedUpdate(addon.Version, addon.MyVersion, downloadAddonGitHub.GetAddonUpdate(addon.Name));
            if (addon.NeedUpdate)
            {
                nameAddon.ForeColor = Color.FromArgb(166, 0, 0);
                versionButton.ForeColor = Color.FromArgb(166, 0, 0);
                DownloadAddonGitHub.UpdateInfo = true;
                versionButton.Text = "Актуальная: " + addon.Version + "\n" + "У Вас: " + addon.MyVersion;
            }
            else
            {
                nameAddon.ForeColor = Color.FromArgb(44, 42, 63);
                versionButton.ForeColor = Color.FromArgb(44, 42, 63);
                SetVersion();
            }
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
                }
                else
                {
                    if (downloadAddonGitHub.GetAddonUpdate(addon.Name))
                    {
                        if (DownloadAddonGitHub.lastUpdateAddon.FindIndex(f => f.AddonName == addon.Name) > -1) versionButton.Text = "Актуальная: " + addon.Version + "\n" + DownloadAddonGitHub.lastUpdateAddon[DownloadAddonGitHub.lastUpdateAddon.FindIndex(f => f.AddonName == addon.Name)].LastUpdate;
                        else versionButton.Text = "Актуальная: " + addon.Version;
                    }
                    else
                    {
                        versionButton.Text = "Не слежу" ;
                    }
                }
            }
            else
            {
                versionButton.Text = "Актуальная: " + addon.Version;
            }
        }
        #endregion

    }
}
