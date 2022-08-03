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
using Microsoft.Win32;

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
            checkBoxDescription.Checked = Properties.Settings.Default.DescriptionBool;
            checkBoxLauncher.Checked = Properties.Settings.Default.LauncherOpen;
            labelPathGame.Text = "Папка с игрой: " + Properties.Settings.Default.PathWow;
        }

        private void CheckBoxAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoUpdateBool = checkBoxAutoUpdate.Checked;
            Properties.Settings.Default.Save();
        }

        private void SavePathGame_Click(object sender, EventArgs e)
        {
            string path = GetPath();
            if (path != null)
            {
                List<string> Directories = new List<string>(Directory.GetDirectories(path));

                for (int i = 0; i < Directories.Count; i++)
                {
                    Directories[i] = Directories[i].ToLower();
                }

                if (Directories.FindIndex(dir => dir.Contains("interface")) > -1 && Directories.FindIndex(dir => dir.Contains("wtf")) > -1)
                {
                    Properties.Settings.Default.PathWow = path;
                    if (Properties.Settings.Default.PathsWow.Contains(path) == false)
                    {
                        Properties.Settings.Default.PathsWow.Add(path);
                        DownloadAddonGitHub.UpdateInfo = true;
                        DownloadAddonGitHub.ForcedUpdate = true;
                    }
                   
                    Properties.Settings.Default.Save();
                    labelPathGame.Text = "Папка с игрой: " + path;
                }
                else
                {
                    MessageBox.Show("Ошибка в пути или нет файла WTF или AddOns");
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

        private void CheckBoxDescription_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DescriptionBool = checkBoxDescription.Checked;
            Properties.Settings.Default.Save();
        }

        private void CheckBoxLauncher_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LauncherOpen = checkBoxLauncher.Checked;
            Properties.Settings.Default.Save();
        }

        bool isShowContextMenuStripPaths = false;
        private void ButtonPathsShow_MouseClick(object sender, MouseEventArgs e)
        {
            if (isShowContextMenuStripPaths == false)
            {
                ContextMenuStripPaths.Items.Clear();
                foreach (string text in Properties.Settings.Default.PathsWow)
                {

                    ContextMenuStripPaths.Items.Add(text);
                    if (text.Contains(Properties.Settings.Default.PathWow))
                    {
                        ContextMenuStripPaths.Items[ContextMenuStripPaths.Items.Count - 1].BackColor = Color.FromArgb(44, 177, 128);
                        ContextMenuStripPaths.Items[ContextMenuStripPaths.Items.Count - 1].ForeColor = Color.White;

                    }
                }

                ContextMenuStripPaths.Show(ButtonPathsShow, new Point(0, -ButtonPathsShow.Height));
                isShowContextMenuStripPaths = true;
            }
            else
            {
                ContextMenuStripPaths.Hide();
                isShowContextMenuStripPaths = false;
            }
        }

        private void ContextMenuStripPaths_MouseLeave(object sender, EventArgs e)
        {
            ContextMenuStripPaths.Hide();
            isShowContextMenuStripPaths = false;
        }

        private void ContextMenuStripPaths_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Properties.Settings.Default.PathWow = e.ClickedItem.Text;
            Properties.Settings.Default.Save();
            labelPathGame.Text = e.ClickedItem.Text;
            DownloadAddonGitHub.UpdateInfo = true;
            DownloadAddonGitHub.ForcedUpdate = true;
        }

        private void DeletePathGame_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PathWow != null)
            {
                if (Properties.Settings.Default.PathsWow.Count > 1)
                {
                    Properties.Settings.Default.PathsWow.Remove(Properties.Settings.Default.PathWow);
                    Properties.Settings.Default.PathWow = Properties.Settings.Default.PathsWow[0];
                    Properties.Settings.Default.Save();
                    labelPathGame.Text = "Папка с игрой: " + Properties.Settings.Default.PathWow;
                    DownloadAddonGitHub.UpdateInfo = true;
                    DownloadAddonGitHub.ForcedUpdate = true;
                }
                else
                {
                    MessageBox.Show("Вы не можете удалить единственный путь к игре.");
                }
            }
            else
            {
                MessageBox.Show("Путь к игре пустой.");
            }
        }
    }
}
