using AddonUpdater.Controlers;
using AddonUpdater.Models;
using Newtonsoft.Json;
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
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddonUpdater.Controls
{
    public partial class ModificationsControl : UserControl
    {
        private FormMainMenu formMainMenu;
        public ModificationsControl(FormMainMenu owner)
        {
            formMainMenu = owner;
            InitializeComponent();
            ComboBoxWTF.Text = AddonUpdaterSettingApp.SettingsApp.BackupWTF;
        }


        private async void BtnBackupWTF_Click(object sender, EventArgs e)
        {
            btnBackupWTF.Enabled = false;
            await BackupWTF.CreateFileBackupTask();
            btnBackupWTF.Enabled = true;
        }

        private async void BtnRestoreWTF_Click(object sender, EventArgs e)
        {
            btnRestoreWTF.Enabled = false;
            await BackupWTF.BackupWtfTask();
            btnRestoreWTF.Enabled = true;
        }

        private void ComboBoxWTF_TextChanged(object sender, EventArgs e)
        {
            AddonUpdaterSettingApp.SettingsApp.BackupWTF = ComboBoxWTF.Text;
            AddonUpdaterSettingApp.Save();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Directory.GetCurrentDirectory() + "\\BackupWTF"))
            {
                Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\BackupWTF");
            }
            else
            {
                MessageBox.Show("Не найдена папка с WTF");
            }
        }
    }
}
