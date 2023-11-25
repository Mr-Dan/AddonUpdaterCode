using AddonUpdater.Controlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddonUpdater.Controls
{
    public partial class AboutFormControl : UserControl
    {
        public AboutFormControl()
        {
            InitializeComponent();
            lblVersion.Text = $"Версия программы: {Application.ProductVersion}";
            lblContacts.Text = $"Контакты: {AddonUpdaterSetting.Setting.Contact}";
            lblThx.Text = $"Благодарность за аддоны: {AddonUpdaterSetting.Setting.Thx}";
        }

        private void ButtonDonate_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(AddonUpdaterSetting.Setting.DonateLink) { UseShellExecute = true });
        }

        private void ButtonDiscord_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(AddonUpdaterSetting.Setting.DiscordLink) { UseShellExecute = true });
        }

        private void ButtonForum_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(AddonUpdaterSetting.Setting.ForumLink) { UseShellExecute = true });
        }

        private void ButtonGitHub_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo(AddonUpdaterSetting.Setting.GitHubLink) { UseShellExecute = true });
        }

    }
}
