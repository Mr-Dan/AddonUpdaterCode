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

namespace AddonUpdater.Forms
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            labelVersion.Text = Application.ProductVersion;
        }

        private void Button_GitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Mr-Dan/AddonUpdater");
        }

        private void ButtonDonate_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.donationalerts.com/r/mr_dan_");
        }

        private void ButtonDiscord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/7cjU9xvcQY");
        }
    }
}
