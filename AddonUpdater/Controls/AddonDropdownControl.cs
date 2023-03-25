using AddonUpdater.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddonUpdater.Controls
{
    public partial class AddonDropdownControl : UserControl
    {
        private GitHub addon;
        private AddonFormControl form;
        private AddonControl addonControls;
        private DownloadAddonGitHub downloadAddonGitHub = new DownloadAddonGitHub();
        public AddonDropdownControl()
        {
            InitializeComponent();
        }

        #region Click
        private async void ReinstallButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (form.AllUpdate == false)
            {
                Visible = false;
                await addonControls.DownloadAddon();
            }
            else
            {
                MessageBox.Show("Дождитесь обновления аддонов");
            }
        }

        private void TrackButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            addonControls.FollowUpdate();
            trackButton.BackColor = downloadAddonGitHub.GetAddonUpdate(addon.Name) ? Color.FromArgb(44, 177, 128) : Color.FromArgb(191, 48, 48);
        }

        private void BugReportButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (addon.BugReport != "")
                Process.Start(addon.BugReport);
        }

        private void ForumButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (addon.Forum != "")
                Process.Start(addon.Forum);
        }

        private void GitHubButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (addon.GithubLink != "")
                Process.Start(addon.GithubLink);
        }
        private void DeleteSettingsButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (FormMainMenu.activity == null)
            {             
                form.deleteSettings.SetAddon(addon);
                Visible= false;
                form.lastAddon= null;
            }
            else
            {
                MessageBox.Show("Дождитесь обновления аддонов");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            addonControls.DeleteAddon();
        }

        #endregion

        private void PanelAddonReset()
        {
            reinstallButton.BackColor = Color.FromArgb(37, 35, 47);
            bugReportButton.BackColor = Color.FromArgb(37, 35, 47);
            forumButton.BackColor = Color.FromArgb(37, 35, 47);
            gitHubButton.BackColor = Color.FromArgb(37, 35, 47);
            deleteSettingsButton.BackColor = Color.FromArgb(37, 35, 47);
            deleteButton.BackColor = Color.FromArgb(37, 35, 47);
            trackButton.BackColor = Color.FromArgb(37, 35, 47);
            bugReportButton.Enabled = true;
            forumButton.Enabled = true;
            gitHubButton.Enabled = true;
            reinstallButton.Enabled = true;
        }

        private void PanelAddonButtonSet()
        {
            if (addon.MyVersion != null)
            {
                reinstallButton.Text = $"Переустановить\n{addon.Name}";
            }
            else
            {
                reinstallButton.Text = $"Установить\n{addon.Name}";
            }

            trackButton.BackColor = downloadAddonGitHub.GetAddonUpdate(addon.Name) ? Color.FromArgb(44, 177, 128) : Color.FromArgb(191, 48, 48);

            if (addon.BugReport == "")
            {
                bugReportButton.Enabled = false;
            }
            if (addon.Forum == "")
            {
                forumButton.Enabled = false;
            }
            if (addon.GithubLink == "")
            {
                gitHubButton.Enabled = false;
            }
        }

        #region Set
        public void SetMyAddons()
        {
            Height = 300;
            reinstallButton.Visible = true;
            trackButton.Visible = true;
            bugReportButton.Visible = true;
            forumButton.Visible = true;
            gitHubButton.Visible = true;
            deleteSettingsButton.Visible = true;
            deleteButton.Visible = true;

        }

        public void SetAllAddons()
        {
            Height = 120;
            reinstallButton.Visible = true;
            trackButton.Visible = false;
            bugReportButton.Visible = false;
            forumButton.Visible = true;
            gitHubButton.Visible = true;
            deleteSettingsButton.Visible = false;
            deleteButton.Visible = false;


        }

        public void SetAddon(GitHub addon, AddonControl addonControls, AddonFormControl form)
        {
            this.addon = addon;
            this.addonControls = addonControls;
            this.form = form;
            PanelAddonReset();

            PanelAddonButtonSet();
        }
        #endregion
    }
}
