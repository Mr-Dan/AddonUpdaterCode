using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace AddonUpdater.Forms
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        //C:\Users\Дан\AppData\Local\Programs\sirus-open-launcher\Sirus Launcher.exe
        //D:\wow\World of Warcraft Sirus
        private void FormSetting_Load(object sender, EventArgs e)
        {
            checkBoxAutoUpdate.Checked = Properties.Settings.Default.AutoUpdateBool;
            checkBoxLauncher.Checked = Properties.Settings.Default.PathLauncherBool;
            labelPathGame.Text = "Папка с игрой: "+ Properties.Settings.Default.PathWow;
        }

        private void checkBoxAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoUpdateBool = checkBoxAutoUpdate.Checked;
            Properties.Settings.Default.Save();
        }
        private void checkBoxLauncher_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PathLauncherBool = checkBoxLauncher.Checked;
            Properties.Settings.Default.PathLauncher = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Programs\\sirus-open-launcher\\Sirus Launcher.exe";
            Properties.Settings.Default.Save();
        }
     
        private void SavePathGame_Click(object sender, EventArgs e)
        {
            string path = GetPath();
            if (path != null)
            {
                List<string> Directories = new List<string>(Directory.GetDirectories(path));
   
                if (Directories.FindIndex(dir => dir.IndexOf("Interface") > -1) > -1 && Directories.FindIndex(dir => dir.IndexOf("WTF") > -1) > -1)
                {
                    Properties.Settings.Default.PathWow = path;
                    Properties.Settings.Default.AutoUpdateBool = checkBoxAutoUpdate.Checked;
                    Properties.Settings.Default.Save();
                    labelPathGame.Text = path;
                }
                else
                {
                    MessageBox.Show("Ошибка в пути или файлы игры повреждены");
                }
            }        
        }

        private string GetPath()
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return fbd.SelectedPath;
                }
                return null;
            }
        }

       
    }
}
