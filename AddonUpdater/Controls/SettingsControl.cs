using AddonUpdater.Controlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddonUpdater.Controls
{
    public partial class SettingsControl : UserControl
    {
        DownloadAddonGitHub downloadAddonGitHub = new ();
        private FormMainMenu formMainMenu;
        public SettingsControl(FormMainMenu formMainMenu)
        {
            InitializeComponent();
            this.formMainMenu = formMainMenu;
            checkBoxAutoUpdate.Checked = AddonUpdaterSettingApp.SettingsApp.AutoUpdateBool;
            checkBoxDescription.Checked = AddonUpdaterSettingApp.SettingsApp.DescriptionBool;
            checkBoxLauncher.Checked = AddonUpdaterSettingApp.SettingsApp.LauncherOpen;
            labelPathGame.Text = AddonUpdaterSettingApp.SettingsApp.PathWow;
        }


        #region CheckedChanged
        private void CheckBoxAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            AddonUpdaterSettingApp.SettingsApp.AutoUpdateBool = checkBoxAutoUpdate.Checked;
            AddonUpdaterSettingApp.Save();
        }

        private void CheckBoxDescription_CheckedChanged(object sender, EventArgs e)
        {
            AddonUpdaterSettingApp.SettingsApp.DescriptionBool = checkBoxDescription.Checked;
            AddonUpdaterSettingApp.Save();
        }

        private void CheckBoxLauncher_CheckedChanged(object sender, EventArgs e)
        {
            AddonUpdaterSettingApp.SettingsApp.LauncherOpen = checkBoxLauncher.Checked;
            AddonUpdaterSettingApp.Save();
        }
        #endregion

        #region Click
        private void SavePathGame_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (FormMainMenu.activity == null)
            {
                string path = GetPath();
                if (path != null)
                {
                    List<string> Directories = new(Directory.GetDirectories(path));

                    if (Directories.FindIndex(dir => dir.ToLower().Contains("interface")) > -1 && Directories.FindIndex(dir => dir.ToLower().Contains("wtf")) > -1)
                    {
                        AddonUpdaterSettingApp.SettingsApp.PathWow = path;
                        if (AddonUpdaterSettingApp.SettingsApp.PathsWow.Contains(path) == false)
                        {
                            AddonUpdaterSettingApp.SettingsApp.PathsWow.Add(path);
                            UpdateInfo();
                        }

                        AddonUpdaterSettingApp.Save();
                        labelPathGame.Text = path;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка в пути или нет файла WTF или AddOns");
                    }
                }
            }
        }
        bool isShowContextMenuStripPaths = false;
        private void ButtonPathsShow_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (FormMainMenu.activity == null)
            {
                if (isShowContextMenuStripPaths == false)
                {
                    ContextMenuStripPaths.Items.Clear();
                    foreach (string text in AddonUpdaterSettingApp.SettingsApp.PathsWow)
                    {
                        if (text != null)
                        {
                            ContextMenuStripPaths.Items.Add(text);
                            if (text == AddonUpdaterSettingApp.SettingsApp.PathWow)
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
        }

        private void DeletePathGame_Click(object sender, EventArgs e)
        {
            if (FormMainMenu.activity == null)
            {
                if (AddonUpdaterSettingApp.SettingsApp.PathWow != null)
                {
                    if (AddonUpdaterSettingApp.SettingsApp.PathsWow.Count > 1)
                    {
                        AddonUpdaterSettingApp.SettingsApp.PathsWow.Remove(AddonUpdaterSettingApp.SettingsApp.PathWow);
                        AddonUpdaterSettingApp.SettingsApp.PathWow = AddonUpdaterSettingApp.SettingsApp.PathsWow[0];
                        AddonUpdaterSettingApp.Save();
                        labelPathGame.Text = AddonUpdaterSettingApp.SettingsApp.PathWow;
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
        }
        #endregion

        #region ContextMenuStripPaths
        private void ContextMenuStripPaths_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            AddonUpdaterSettingApp.SettingsApp.PathWow = e.ClickedItem.Text;
            AddonUpdaterSettingApp.Save();
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
            using FolderBrowserDialog fbd = new ();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            return null;
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
                await downloadAddonGitHub.AupdatecheckAsync();
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

        private void LabelPathGame_Click(object sender, EventArgs e)
        {
            if (AddonUpdaterSettingApp.SettingsApp.PathWow != null)
            {
                Process.Start(new ProcessStartInfo("explorer.exe", AddonUpdaterSettingApp.SettingsApp.PathWow) { UseShellExecute = true });
            }
        }
    }
}
