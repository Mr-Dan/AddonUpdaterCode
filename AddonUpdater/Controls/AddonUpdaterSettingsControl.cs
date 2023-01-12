using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddonUpdater.Controls
{
    public partial class AddonUpdaterSettingsControl : UserControl
    {
        DownloadAddonGitHub downloadAddonGitHub = new DownloadAddonGitHub();
        private FormMainMenu formMainMenu;
        public AddonUpdaterSettingsControl(FormMainMenu formMainMenu)
        {
            InitializeComponent();
            this.formMainMenu = formMainMenu;
            checkBoxAutoUpdate.Checked = Properties.Settings.Default.AutoUpdateBool;
            checkBoxDescription.Checked = Properties.Settings.Default.DescriptionBool;
            checkBoxLauncher.Checked = Properties.Settings.Default.LauncherOpen;
            labelPathGame.Text = "Папка с игрой: " + Properties.Settings.Default.PathWow;
        }


        #region CheckedChanged
        private void CheckBoxAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoUpdateBool = checkBoxAutoUpdate.Checked;
            Properties.Settings.Default.Save();
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
        #endregion

        #region Click
        private void SavePathGame_Click(object sender, EventArgs e)
        {
            string path = GetPath();
            if (path != null)
            {
                List<string> Directories = new List<string>(Directory.GetDirectories(path));

                if (Directories.FindIndex(dir => dir.ToLower().Contains("interface")) > -1 && Directories.FindIndex(dir => dir.ToLower().Contains("wtf")) > -1)
                {
                    Properties.Settings.Default.PathWow = path;
                    if (Properties.Settings.Default.PathsWow.Contains(path) == false)
                    {
                        Properties.Settings.Default.PathsWow.Add(path);
                        UpdateInfo();
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
        bool isShowContextMenuStripPaths = false;
        private void ButtonPathsShow_Click(object sender, EventArgs e)
        {
            if (isShowContextMenuStripPaths == false)
            {
                ContextMenuStripPaths.Items.Clear();
                foreach (string text in Properties.Settings.Default.PathsWow)
                {
                    if (text != null)
                    {
                        ContextMenuStripPaths.Items.Add(text);
                        if (text == Properties.Settings.Default.PathWow)
                        {
                            ContextMenuStripPaths.Items[ContextMenuStripPaths.Items.Count - 1].BackColor = Color.FromArgb(44, 177, 128);
                            ContextMenuStripPaths.Items[ContextMenuStripPaths.Items.Count - 1].ForeColor = Color.White;

                        }
                    }
                }

                ContextMenuStripPaths.Show(ButtonPathsShow, new Point(0, -ButtonPathsShow.Height));
                isShowContextMenuStripPaths = true;
            }
            else
            {
                ButtonReset();
                ContextMenuStripPaths.Hide();
                isShowContextMenuStripPaths = false;
            }
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
                    UpdateInfo();
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
        #endregion

        #region ContextMenuStripPaths
        private void ContextMenuStripPaths_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Properties.Settings.Default.PathWow = e.ClickedItem.Text;
            Properties.Settings.Default.Save();
            labelPathGame.Text = e.ClickedItem.Text;
            UpdateInfo();
        }

        private void ContextMenuStripPaths_MouseLeave(object sender, EventArgs e)
        {
            ButtonReset();
            ContextMenuStripPaths.Hide();
            isShowContextMenuStripPaths = false;
        }
        #endregion

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

        #region On/Off/Reset
        private void ButtonOff()
        {
            ButtonPathsShow.Enabled = false;
            SavePathGame.Enabled = false;
            DeletePathGame.Enabled = false;
        }
        private void ButtonOn()
        {
            ButtonPathsShow.Enabled = true;
            SavePathGame.Enabled = true;
            DeletePathGame.Enabled = true;
        }

        private void ButtonReset()
        {
            for (int i = 0; i < ContextMenuStripPaths.Items.Count; i++)
            {
                ContextMenuStripPaths.Items[ContextMenuStripPaths.Items.Count - 1].BackColor = Color.LightGray;
                ContextMenuStripPaths.Items[ContextMenuStripPaths.Items.Count - 1].ForeColor = Color.White;
            }
        }
        #endregion

        private async void UpdateInfo()
        {
            if (FormMainMenu.activity == null)
            {
                ButtonOff();
                formMainMenu.ButtonOff();
                formMainMenu.progressBar1.Visible = true;
                formMainMenu.labelInfo.Visible = true;
                formMainMenu.labelInfo.Text = "Обновление";
                FormMainMenu.activity = "обновления";
                formMainMenu.progressBar1.Value = 0;
                formMainMenu.progressBar1.Maximum = 2;
                formMainMenu.progressBar1.Value++;
                await downloadAddonGitHub.Aupdatecheck();
                formMainMenu.SetNotificationsAddons();
                formMainMenu.progressBar1.Value++;
                formMainMenu.progressBar1.Value = 0;
                formMainMenu.labelInfo.Text = "";
                FormMainMenu.activity = null;
                formMainMenu.progressBar1.Visible = false;
                formMainMenu.labelInfo.Visible = false;
                formMainMenu.ButtonOn();
                ButtonOn();

            }
        }

    }
}
