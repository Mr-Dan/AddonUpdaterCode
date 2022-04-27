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

        private void button_GitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Mr-Dan/AddonUpdater");
        }

        private void buttonDonate_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.donationalerts.com/r/mr_dan_");
        }

        private void buttonDiscord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/7cjU9xvcQY");
        }
    }
}
