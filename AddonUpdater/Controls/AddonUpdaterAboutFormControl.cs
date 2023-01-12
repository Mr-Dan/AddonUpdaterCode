﻿using System;
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
    public partial class AddonUpdaterAboutFormControl : UserControl
    {
        public AddonUpdaterAboutFormControl()
        {
            InitializeComponent();
            labelVersion.Text = Properties.Settings.Default.Version;
        }

        private void ButtonDonate_Click(object sender, EventArgs e)
        {
            Process.Start("https://qiwi.com/n/MISTERDAN");
        }

        private void ButtonDiscord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/7cjU9xvcQY");
        }

        private void Button_GitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Mr-Dan/AddonUpdater");
        }
    }
}