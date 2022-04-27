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
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace AddonUpdater.Forms
{
    public partial class FormAddons : Form
    {
        DownloadAddonGitHub downloadAddonGitHub = new DownloadAddonGitHub();
        FormMainMenu FormMainMenu;

        public FormAddons(FormMainMenu owner)
        {
            FormMainMenu = owner;
            InitializeComponent();
        }

        private void FormAddons_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PathWow.Length > 0)
            {
                if (FormMainMenu.progressBar1.Visible == false)
                {
                    FormMainMenu.progressBar1.Visible = true;
                    FormMainMenu.labelInfo.Visible = true;
                }
                panelAddonsView.HorizontalScroll.Enabled = false;
                panelAddonsView.HorizontalScroll.Visible = false;
                panelAddonsView.AutoScroll = true;
                updatePanelAddonsView(false);
            }
            else
            {
                MessageBox.Show("Укажите путь к игре в настройках", "Предупреждение");
            }
        }
        List<PanelAddon> panelAddons = new List<PanelAddon>();
        private async void updatePanelAddonsView(bool flagGetNewInfo)
        {
            FormMainMenu.ButtonOff();
            ButtonOff();
            if (flagGetNewInfo == false)
            {
                List<GitHub> git = DownloadAddonGitHub.GitHubs.FindAll(find => find.NeedUpdate == true);
                for (int i = 0; i < git.Count; i++)
                {
                    int index = DownloadAddonGitHub.GitHubs.FindIndex(indx => indx.Name == git[i].Name);
                    if (index != -1)
                    {
                        DownloadAddonGitHub.GitHubs[index].MyVersion = downloadAddonGitHub.GetMyVersion(DownloadAddonGitHub.GitHubs[index].Directory, DownloadAddonGitHub.GitHubs[index].Regex, DownloadAddonGitHub.GitHubs[index].Replace);
                        DownloadAddonGitHub.GitHubs[index].NeedUpdate = downloadAddonGitHub.GetNeedUpdate(DownloadAddonGitHub.GitHubs[index].Version, DownloadAddonGitHub.GitHubs[index].MyVersion, DownloadAddonGitHub.GitHubs[index].Blacklist);
                        DownloadAddonGitHub.GitHubs[index].DownloadMyAddon = downloadAddonGitHub.GetNeedUpdate(DownloadAddonGitHub.GitHubs[index].Version, DownloadAddonGitHub.GitHubs[index].MyVersion, DownloadAddonGitHub.GitHubs[index].Blacklist);
                        DownloadAddonGitHub.GitHubs[index].SavedVariables = downloadAddonGitHub.GetSavedVariables(DownloadAddonGitHub.GitHubs[index].Directory);
                        DownloadAddonGitHub.GitHubs[index].SavedVariablesPerCharacter = downloadAddonGitHub.GetSavedVariablesPerCharacter(DownloadAddonGitHub.GitHubs[index].Directory);
                    }
                }
            }
            else
            {
                FormMainMenu.labelInfo.Text = "Обновление";
                FormMainMenu.activity = "обновления";
                FormMainMenu.progressBar1.Value = 0;
                FormMainMenu.progressBar1.Maximum = 2;
                FormMainMenu.progressBar1.Value++;
                await downloadAddonGitHub.Aupdatecheck();
            }

            panelAddonsView.Controls.Clear();
            panelAddons.Clear();
            for (int i = 0; i < DownloadAddonGitHub.GitHubs.Count; i++)
            {
                if (DownloadAddonGitHub.GitHubs[i].MyVersion != null)
                {
                    panelAddons.Add(new PanelAddon(DownloadAddonGitHub.GitHubs[i], panelAddons.Count, panelAddonsView) { });
                    panelAddonsView.Controls.Add(panelAddons[panelAddons.Count - 1].AddonPanel);

                    panelAddons[panelAddons.Count - 1].AddonName.MouseLeave += new EventHandler(AddonName_MouseLeave);
                    panelAddons[panelAddons.Count - 1].AddonName.MouseMove += new MouseEventHandler(AddonName_MouseMove);
                    panelAddons[panelAddons.Count - 1].AddonName.MouseClick += new MouseEventHandler(AddonName_MouseClick);
                    panelAddons[panelAddons.Count - 1].AddonVersion.Click += new EventHandler(AddonVersion_Click);
                    panelAddons[panelAddons.Count - 1].AddonPanel.BringToFront();
                }
            }

            if (flagGetNewInfo == true)
            {
                FormMainMenu.progressBar1.Value++;
                FormMainMenu.progressBar1.Value = 0;
                FormMainMenu.labelInfo.Text = "";
                FormMainMenu.activity = null;
            }

            if (Properties.Settings.Default.AutoUpdateBool == true && FormMainMenu.UpdateCount > 0)
            {
                FormMainMenu.ButtonOff();
                AddonDownload("AutoDownload");
            }
            ButtonOn();
            FormMainMenu.ButtonOn();
        }

        private void AddonName_MouseLeave(object sender, EventArgs e)
        {           
            PanelDescription.Visible = false;
            LabelDescription.Text = null;
        }

        private void AddonName_MouseMove(object sender, MouseEventArgs e)
        {

            if (panelAddon.Visible == false)
            {
                ActiveControl = null;
                if (Properties.Settings.Default.DescriptionBool)
                {
                   
                    Label label = new Label();
                    label = (Label)sender;

                    string nameAddon = Regex.Match(label.Name, @"LabelName_(\w)+_row").Value.Replace("LabelName_", "").Replace("_row", "");
                    int row = int.Parse(Regex.Match(label.Name, @"_row_\d*").Value.Replace("_row_", ""));

                    int index = DownloadAddonGitHub.GitHubs.FindIndex(find => find.Name == nameAddon);
                    if (index != -1)
                    {
                        if (DownloadAddonGitHub.GitHubs[index].Description != String.Empty)
                        if (PanelDescription.Visible == false)
                        {
                            LabelDescription.Text = DownloadAddonGitHub.GitHubs[index].Description;
                            Size len = TextRenderer.MeasureText(DownloadAddonGitHub.GitHubs[index].Description, LabelDescription.Font);
                            int size = len.Width * len.Height;
                            PanelDescription.Size = new Size(780, (size / 800) + 20);
                            Point pos = new Point();
                            pos.Y = label.Parent.Location.Y;
                            if (pos.Y + PanelDescription.Height + 40 > panelAddonsView.Height)
                            {
                                PanelDescription.Location = new Point(0, pos.Y - PanelDescription.Height + 50);
                            }
                            else if (pos.Y + PanelDescription.Height < panelAddonsView.Height)
                            {
                                PanelDescription.Location = new Point(0, pos.Y + 80);
                            }
                            PanelDescription.Visible = true;
                            PanelDescription.BringToFront();
                        }
                    }
                }
            }
        }

        private async Task DownloadAddon(string flag)
        {
            try
            {
                FormMainMenu.progressBar1.Value = 0;
                DownloadAddonGitHub.NeedUpdate.Clear();
                if (flag == "Download") DownloadAddonGitHub.NeedUpdate = DownloadAddonGitHub.GitHubs.FindAll(find => find.DownloadMyAddon == true);
                else if (flag == "AutoDownload") DownloadAddonGitHub.NeedUpdate = DownloadAddonGitHub.GitHubs.FindAll(find => find.NeedUpdate == true);

                FormMainMenu.progressBar1.Maximum = DownloadAddonGitHub.NeedUpdate.Count;
                for (int i = 0; i < DownloadAddonGitHub.NeedUpdate.Count; i++)
                {
                    FormMainMenu.labelInfo.Text = DownloadAddonGitHub.NeedUpdate[i].Name;
                    await downloadAddonGitHub.DownloadAddonGitHubTask( DownloadAddonGitHub.NeedUpdate[i].Name, DownloadAddonGitHub.NeedUpdate[i].GithubLink, DownloadAddonGitHub.NeedUpdate[i].Branches);
                    FormMainMenu.progressBar1.Value++;
                }
                FormMainMenu.labelInfo.Text = "Распаковка Аддонов";
                await downloadAddonGitHub.GetAddon();
                FormMainMenu.progressBar1.Value = 0;
                FormMainMenu.labelInfo.Text = "";
                FormMainMenu.UpdateCount = 0;
            }
            catch
            {
                FormMainMenu.progressBar1.Value = 0;
                FormMainMenu.labelInfo.Text = "Ошибка подключения";
            }
        }

        private bool AllUpdate = false;
        private void button_Dowload_Click(object sender, EventArgs e)
        {

            ActiveControl = null;
            if (DownloadAddonGitHub.GitHubs.FindAll(find => find.DownloadMyAddon == true).Count > 0)
            {
                FormMainMenu.ButtonOff();
                AddonDownload("Download");
            }
            else
            {
                MessageBox.Show("Выберите аддоны для скачивания", "Ошибка");
            }
        }

        private async void AddonDownload(string flag)
        {
            AllUpdate = true;
            FormMainMenu.activity = "Cкачивания";
            ButtonOff();
            await DownloadAddon(flag);
            updatePanelAddonsView(false);
            FormMainMenu.activity = null;
            ButtonOn();
            AllUpdate = false;
        }   

        private void button_update_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            FormMainMenu.ButtonOff();
            ButtonOff();
            updatePanelAddonsView(true);
        }

        private void buttonLauncher_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            string pathLauncher = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Programs\\sirus-open-launcher\\Sirus Launcher.exe";
            string pathPlayExe = Properties.Settings.Default.PathWow + "\\run.exe";
            Process[] proc = Process.GetProcessesByName("Sirus Launcher");
            Process[] proc2 = Process.GetProcessesByName("run");
            if (proc.Length == 0)
            {
                if (File.Exists(pathLauncher))
                    Process.Start(pathLauncher);
            }
            else
            {
                if (proc2.Length == 0)
                {
                    if (File.Exists(pathPlayExe))
                        Process.Start(pathPlayExe);
                }
                else
                {
                    MessageBox.Show("Игра уже запущена");
                }
            }
        }

        #region панель аддона
        int RowIndex = 0;
        int ClickIndex = 0;

        private void AddonName_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveControl = null;
            panelDeleteSettings.Visible = false;
            if (panelAddon.Visible == true)
            {
                panelAddon.Visible = false;
                RowIndex = -1;
                ClickIndex = -1;
            }
            else
            {
                Label label = new Label();
                label = (Label)sender;
                string nameAddon = Regex.Match(label.Name, @"LabelName_(\w)+_row").Value.Replace("LabelName_", "").Replace("_row", "");
                int row = int.Parse(Regex.Match(label.Name, @"_row_\d*").Value.Replace("_row_", ""));//!!
                panelAddonReset();
                int index = DownloadAddonGitHub.GitHubs.FindIndex(find => find.Name == nameAddon);
                if (index != -1)
                {
                                    
                    buttonReinstall.Text = $"Переустановить\n{DownloadAddonGitHub.GitHubs[index].Name}";
                    ClickIndex = index;
                    RowIndex = row;        
                    Point pos = new Point();
                    pos.Y = label.Parent.Location.Y;
                    if (pos.Y + panelAddon.Height > panelAddonsView.Height && pos.Y + panelAddon.Height - 120 < panelAddonsView.Height)
                    {
                        panelAddon.Location = new Point(220, pos.Y - 80);
                    }
                    else if (pos.Y + panelAddon.Height > panelAddonsView.Height)
                    {
                        panelAddon.Location = new Point(220, pos.Y - panelAddon.Height + 80);
                    }
                    else if (pos.Y + panelAddon.Height < panelAddonsView.Height)
                    {
                        panelAddon.Location = new Point(220, pos.Y + 40);
                    }
                    PanelDescription.Visible = false;
                    panelAddonButtonSet(DownloadAddonGitHub.GitHubs[index].Blacklist);
                    panelAddon.Visible = true;
                    panelAddon.BringToFront();
                }

            }

        }

        private void panelAddonReset()
        {
            buttonReinstall.BackColor = Color.FromArgb(37, 35, 47);
            buttonIgnore.BackColor = Color.FromArgb(37, 35, 47);
            buttonReportBug.BackColor = Color.FromArgb(37, 35, 47);
            buttonForum.BackColor = Color.FromArgb(37, 35, 47);
            buttonGitHub.BackColor = Color.FromArgb(37, 35, 47);
            buttonDeleteSettings.BackColor = Color.FromArgb(37, 35, 47);
            buttonDelete.BackColor = Color.FromArgb(37, 35, 47);
            buttonReportBug.Enabled = true;
            buttonForum.Enabled = true;
            buttonGitHub.Enabled = true;
        }
        private void panelAddonButtonSet(bool ignor)
        {

            buttonIgnore.BackColor = ignor ? Color.FromArgb(191, 48, 48) : Color.FromArgb(37, 35, 47);
            if (DownloadAddonGitHub.GitHubs[ClickIndex].BugReport == "")
            {
                buttonReportBug.Enabled = false;
            }
            if (DownloadAddonGitHub.GitHubs[ClickIndex].Forum == "")
            {
                buttonForum.Enabled = false;
            }
            if (DownloadAddonGitHub.GitHubs[ClickIndex].GithubLink == "")
            {
                buttonGitHub.Enabled = false;
            }
        }

        private async void buttonReinstall_Click(object sender, EventArgs e)
        {
            if (AllUpdate == false)
            {
                panelAddon.Visible = false;
                await DownloadAddon3(DownloadAddonGitHub.GitHubs[ClickIndex], ClickIndex, RowIndex);
            }
            else
            {
                MessageBox.Show("Дождитесь обновления аддонов");
            }
        }

        private async void AddonVersion_Click(object sender, EventArgs e)
        {
            Button Button = new Button();
            Button = (Button)sender;

            string nameAddon = Regex.Match(Button.Name, @"Button_(\w)+_row").Value.Replace("Button_", "").Replace("_row", "");
            int row = int.Parse(Regex.Match(Button.Name, @"_row_\d*").Value.Replace("_row_", ""));
            if (AllUpdate == false)
            {
                int index = DownloadAddonGitHub.GitHubs.FindIndex(find => find.Name == nameAddon);
                if (index != -1)
                {
                    panelAddon.Visible = false;
                    await DownloadAddon3(DownloadAddonGitHub.GitHubs[index], index, row);
                }
            }
            else
            {
                MessageBox.Show("Дождитесь обновления аддонов");
            }
        }
        private void buttonIgnore_Click(object sender, EventArgs e)
        {
            if (ClickIndex != -1)
            {
                int index = ClickIndex;
                if (DownloadAddonGitHub.GitHubs[index].Blacklist)
                {
                    DownloadAddonGitHub.GitHubs[index].Blacklist = false;

                    DownloadAddonGitHub.GitHubs[index].NeedUpdate = downloadAddonGitHub.GetNeedUpdate(DownloadAddonGitHub.GitHubs[index].Version, DownloadAddonGitHub.GitHubs[index].MyVersion, DownloadAddonGitHub.GitHubs[index].Blacklist);
                    DownloadAddonGitHub.GitHubs[index].DownloadMyAddon = DownloadAddonGitHub.GitHubs[index].NeedUpdate;
                    if (DownloadAddonGitHub.GitHubs[index].NeedUpdate)
                    {
                        panelAddons[RowIndex].AddonName.ForeColor = Color.FromArgb(166, 0, 0);
                        panelAddons[RowIndex].AddonVersion.ForeColor = Color.FromArgb(166, 0, 0);

                        DownloadAddonGitHub.UpdateInfo = true;
                    }
                    while (Properties.Settings.Default.AddonBlacklist.Contains(DownloadAddonGitHub.GitHubs[index].Name))
                    {
                        Properties.Settings.Default.AddonBlacklist.Remove(DownloadAddonGitHub.GitHubs[index].Name);
                    }
                    Properties.Settings.Default.Save();
                }
                else
                {

                    DownloadAddonGitHub.GitHubs[index].NeedUpdate = false;
                    DownloadAddonGitHub.GitHubs[index].DownloadMyAddon = false;
                    DownloadAddonGitHub.GitHubs[index].Blacklist = true;
                    panelAddons[RowIndex].AddonName.ForeColor = Color.FromArgb(44, 42, 63);
                    panelAddons[RowIndex].AddonVersion.ForeColor = Color.FromArgb(44, 42, 63);

                    Properties.Settings.Default.AddonBlacklist.Add(DownloadAddonGitHub.GitHubs[index].Name);
                    Properties.Settings.Default.Save();

                    if (downloadAddonGitHub.GetNeedUpdate(DownloadAddonGitHub.GitHubs[index].Version, DownloadAddonGitHub.GitHubs[index].MyVersion, false))
                    {
                        FormMainMenu.UpdateCount--;
                    }
                }

                buttonIgnore.BackColor = DownloadAddonGitHub.GitHubs[index].Blacklist ? Color.FromArgb(191, 48, 48) : Color.FromArgb(37, 35, 47);
            }
        }

        private void buttonReportBug_Click(object sender, EventArgs e)
        {
            if (DownloadAddonGitHub.GitHubs[ClickIndex].BugReport != "")
                Process.Start(DownloadAddonGitHub.GitHubs[ClickIndex].BugReport);
        }

        private void buttonForum_Click(object sender, EventArgs e)
        {
            if (DownloadAddonGitHub.GitHubs[ClickIndex].Forum != "")
                Process.Start(DownloadAddonGitHub.GitHubs[ClickIndex].Forum);
        }

        private void buttonGitHub_Click(object sender, EventArgs e)
        {
            if (DownloadAddonGitHub.GitHubs[ClickIndex].GithubLink != "")
                Process.Start(DownloadAddonGitHub.GitHubs[ClickIndex].GithubLink);
        }

        private void buttonDeleteSettings_Click(object sender, EventArgs e)
        {
            if (FormMainMenu.activity == null)
            {
                labelAddonName.Text = DownloadAddonGitHub.GitHubs[ClickIndex].Name;
                panelDeleteSettings.Visible = true;
                clearComboBox();
                foreach (WTF wTF in DownloadAddonGitHub.WTF)
                {
                    comboBoxAccount.Items.Add(wTF.Account.Replace(Properties.Settings.Default.PathWow + "\\WTF\\Account\\", ""));
                }
            }
            else
            {
                MessageBox.Show("Дождитесь обновления аддонов");
            }

        }

        private void comboBoxAccount_TextChanged(object sender, EventArgs e)
        {

            comboBoxRealm.Items.Clear();
            comboBoxRealm.ResetText();
            int index = comboBoxAccount.SelectedIndex;
            if (index != -1)
            {

                foreach (Realms realms in DownloadAddonGitHub.WTF[index].Realms)
                {
                    comboBoxRealm.Items.Add(realms.Realm.Replace(DownloadAddonGitHub.WTF[index].Account + "\\", ""));
                }
            }
        }

        private void comboBoxRealm_TextChanged(object sender, EventArgs e)
        {
            comboBoxPersons.Items.Clear();
            comboBoxPersons.ResetText();
            comboBoxSettings.Items.Clear();
            comboBoxSettings.ResetText();
            int indexAccount = comboBoxAccount.SelectedIndex;
            int indexRealm = comboBoxRealm.SelectedIndex;
            if (indexAccount != -1 && indexRealm != -1)
            {

                foreach (string person in DownloadAddonGitHub.WTF[indexAccount].Realms[indexRealm].Persons)
                {
                    comboBoxPersons.Items.Add(person.Replace(DownloadAddonGitHub.WTF[indexAccount].Realms[indexRealm].Realm + "\\", ""));
                }
                if (DownloadAddonGitHub.GitHubs[ClickIndex].SavedVariables == true)
                {
                    comboBoxSettings.Items.Add("Глобальные");
                }
            }

        }

        private void comboBoxPersons_TextChanged(object sender, EventArgs e)
        {
            labelAddonName.Text = DownloadAddonGitHub.GitHubs[ClickIndex].Name;
            comboBoxSettings.Items.Clear();
            comboBoxSettings.ResetText();
            if (DownloadAddonGitHub.GitHubs[ClickIndex].SavedVariables == true)
            {
                comboBoxSettings.Items.Add("Глобальные");
            }
            if (DownloadAddonGitHub.GitHubs[ClickIndex].SavedVariablesPerCharacter == true)
            {
                comboBoxSettings.Items.Add("Персональные");
            }
        }

        private void clearComboBox()
        {
            comboBoxAccount.Items.Clear();
            comboBoxAccount.ResetText();
            comboBoxRealm.Items.Clear();
            comboBoxRealm.ResetText();
            comboBoxPersons.Items.Clear();
            comboBoxPersons.ResetText();
            comboBoxSettings.Items.Clear();
            comboBoxSettings.ResetText();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            panelDeleteSettings.Visible = false;
        }

        private void buttonpanelDeleteSettings_Click(object sender, EventArgs e)
        {
            string account = null;
            string realm = null;
            string person = null;
            string setting = null;
            if (comboBoxAccount.SelectedItem != null)
            {
                account = comboBoxAccount.SelectedItem.ToString();
            }
            if (comboBoxRealm.SelectedItem != null)
            {
                realm = comboBoxRealm.SelectedItem.ToString();
            }
            if (comboBoxPersons.SelectedItem != null)
            {
                person = comboBoxPersons.SelectedItem.ToString();
            }
            if (comboBoxSettings.SelectedItem != null)
            {
                setting = comboBoxSettings.SelectedItem.ToString();
            }
            
            if (account != null && realm != null && setting != null)
            {
                if (setting == "Персональные")
                {
                    int index = DownloadAddonGitHub.WTF.FindIndex(name => name.Account.Replace(Properties.Settings.Default.PathWow + "\\WTF\\Account\\", "") == account);
                    if (index != -1)
                    {
                        int index2 = DownloadAddonGitHub.WTF[index].Realms.FindIndex(name => name.Realm.Replace(DownloadAddonGitHub.WTF[index].Account + "\\", "") == realm);
                        if (index2 != -1)
                        {

                            int index3 = DownloadAddonGitHub.WTF[index].Realms[index2].Persons.FindIndex(name => name.Replace(DownloadAddonGitHub.WTF[index].Realms[index2].Realm + "\\", "") == person);
                            if (index3 != -1)
                            {
                                string path = DownloadAddonGitHub.WTF[index].Realms[index2].Persons[index3] + "\\SavedVariables";
                                string[] getFiles = Directory.GetFiles(path);
                                foreach (string file in getFiles)
                                {
                                    string filenew = file.Replace(path + "\\", "");

                                    filenew = filenew.Replace(".lua.bak", "");
                                    filenew = filenew.Replace(".lua", "");

                                    if (DownloadAddonGitHub.GitHubs[ClickIndex].Files.FindIndex(addon => addon == filenew) > -1)
                                    {
                                        if (File.Exists(file)) File.Delete(file);
                                    }
                                }
                            }
                        }
                    }
                }
                else if (setting == "Глобальные")
                {

                    int index = DownloadAddonGitHub.WTF.FindIndex(name => name.Account.Replace(Properties.Settings.Default.PathWow + "\\WTF\\Account\\", "") == account);
                    if (index != -1)
                    {
                        string path = DownloadAddonGitHub.WTF[index].Account + "\\SavedVariables";
                        string[] getFiles = Directory.GetFiles(path);
                        foreach (string file in getFiles)
                        {
                            string filenew = file.Replace(path + "\\", "");

                            filenew = filenew.Replace(".lua.bak", "");
                            filenew = filenew.Replace(".lua", "");

                            if (DownloadAddonGitHub.GitHubs[ClickIndex].Files.FindIndex(addon => addon == filenew) > -1)
                            { 
                                if (File.Exists(file)) File.Delete(file);
                            }
                        }
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (FormMainMenu.activity == null)
            {
                downloadAddonGitHub.DeleteOneAddon(DownloadAddonGitHub.GitHubs[ClickIndex]);
                DownloadAddonGitHub.GitHubs[ClickIndex].MyVersion = downloadAddonGitHub.GetMyVersion(DownloadAddonGitHub.GitHubs[ClickIndex].Directory, DownloadAddonGitHub.GitHubs[ClickIndex].Regex, DownloadAddonGitHub.GitHubs[ClickIndex].Replace);
                updatePanelAddonsView(false);
                panelAddon.Visible = false;
            }
        }
        #endregion

        int NumberDownloadableAddons = 0;
        private async Task DownloadAddon3(GitHub gitHub, int index, int rowIndex)
        {
            try
            {
                panelAddons[rowIndex].progressBar.Maximum = 2;
                panelAddons[rowIndex].progressBar.Value = 0;
                panelAddons[rowIndex].progressBar.Visible = true;
                FormMainMenu.activity = "Cкачивания";
                NumberDownloadableAddons++;
                FormMainMenu.ButtonOff();
                ButtonOff();
                ActiveControl = null;
                panelAddons[rowIndex].AddonName.Text = $"Скачиваем {gitHub.Name}";
                panelAddons[rowIndex].progressBar.Value++;
                await downloadAddonGitHub.DownloadAddonGitHubTask(gitHub.Name, gitHub.GithubLink, gitHub.Branches);
                panelAddons[rowIndex].AddonName.Text = $"Распаковываем {gitHub.Name}";
                panelAddons[rowIndex].progressBar.Value++;
                await downloadAddonGitHub.GetAddon2(gitHub);
                DownloadAddonGitHub.GitHubs[index].MyVersion = downloadAddonGitHub.GetMyVersion(DownloadAddonGitHub.GitHubs[index].Directory, DownloadAddonGitHub.GitHubs[index].Regex, DownloadAddonGitHub.GitHubs[index].Replace);
                DownloadAddonGitHub.GitHubs[index].NeedUpdate = downloadAddonGitHub.GetNeedUpdate(DownloadAddonGitHub.GitHubs[index].Version, DownloadAddonGitHub.GitHubs[index].MyVersion, DownloadAddonGitHub.GitHubs[index].Blacklist);
                DownloadAddonGitHub.GitHubs[index].DownloadMyAddon = downloadAddonGitHub.GetNeedUpdate(DownloadAddonGitHub.GitHubs[index].Version, DownloadAddonGitHub.GitHubs[index].MyVersion, DownloadAddonGitHub.GitHubs[index].Blacklist);
                DownloadAddonGitHub.GitHubs[index].SavedVariables = downloadAddonGitHub.GetSavedVariables(DownloadAddonGitHub.GitHubs[index].Directory);
                DownloadAddonGitHub.GitHubs[index].SavedVariablesPerCharacter = downloadAddonGitHub.GetSavedVariablesPerCharacter(DownloadAddonGitHub.GitHubs[index].Directory);
                panelAddons[rowIndex].progressBar.Value = 0;
                panelAddons[rowIndex].progressBar.Visible = false;
                panelAddons[rowIndex].AddonName.Text = DownloadAddonGitHub.GitHubs[index].Name;
                panelAddons[rowIndex].AddonVersion.Text = "Актуальная: " + DownloadAddonGitHub.GitHubs[index].Version + "\n" + "У Вас: " + DownloadAddonGitHub.GitHubs[index].MyVersion;
                DataGridViewAddonsRowsForeColorUpdate(rowIndex, DownloadAddonGitHub.GitHubs[index].NeedUpdate);
                NumberDownloadableAddons--;
                if (NumberDownloadableAddons == 0)
                {
                    FormMainMenu.activity = null;
                    FormMainMenu.ButtonOn();
                    ButtonOn();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                FormMainMenu.labelInfo.Text = "Ошибка подключения";
            }
        }

        private void ButtonOn()
        {          
            button_Dowload.Enabled = true;
            button_update.Enabled = true;
        }

        private void ButtonOff()
        {         
            button_Dowload.Enabled = false;
            button_update.Enabled = false;
        }

        private void DataGridViewAddonsRowsForeColorUpdate(int index, bool needUpdate)
        {
            if (needUpdate == false)
            {
                panelAddons[index].AddonName.ForeColor = Color.FromArgb(44, 42, 63);
                panelAddons[index].AddonVersion.ForeColor = Color.FromArgb(44, 42, 63);
            }
        }


    }
    class PanelAddon
    {
        public GitHub GitHub { get; set; }
       
        public Panel AddonPanel { get; set; }
        public Label AddonName { get; set; }
        public Button AddonVersion { get; set; }
        public Label AddonAuthor { get; set; }
        public Label AddonCategory { get; set; }
        public ProgressBar progressBar { get; set; }
        
        private int Row = -1;

        public PanelAddon(GitHub gitHub, int row, Panel panelParent)
        {
            GitHub = gitHub;
            Row = row;
            setAddonPanel(panelParent);
            setAddonName();
            setAddonVersion();
            setAddonAuthor();
            setAddonCategory();
            setProgreddBar();
            ControlsAdd(AddonName);
            ControlsAdd(AddonVersion);
            ControlsAdd(AddonAuthor);
            ControlsAdd(AddonCategory);
            ControlsAdd(progressBar);
        }
        void ControlsAdd(Control control)
        {
            AddonPanel.Controls.Add(control);
            control.BringToFront();
        }
        void setAddonPanel(Panel panelParent)
        {
            AddonPanel = new Panel();
            AddonPanel.Name = "Panel" + GitHub.Name + "row" + Row;
            AddonPanel.Width = 800;
            AddonPanel.Height = 40;

            if (Row % 2 == 0)
                AddonPanel.BackColor = Color.FromArgb(223, 225, 229);
            else
                AddonPanel.BackColor = Color.FromArgb(239, 240, 242);
            AddonPanel.Parent = panelParent.Parent;
            AddonPanel.Location = new Point(0, Row * 40);

        }
        void setAddonName()
        {
            AddonName = new Label();
            AddonName.Name = "LabelName_" + GitHub.Name + "_row_" + Row;
            AddonName.Text = GitHub.Name;
            AddonName.Width = 280;
            AddonName.Height = 40;
            AddonName.Parent = AddonPanel.Parent;
            AddonName.Location = new Point(0, 0);
            AddonName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            if (GitHub.NeedUpdate == true) AddonName.ForeColor = Color.FromArgb(166, 0, 0);
            else AddonName.ForeColor = Color.FromArgb(44, 42, 63);
            AddonName.TextAlign = ContentAlignment.MiddleLeft;
            AddonName.Cursor = Cursors.Hand;
        }
        void setAddonVersion()
        {
            AddonVersion = new Button();
            AddonVersion.Name = "Button_" + GitHub.Name + "_row_" + Row;
            if (GitHub.MyVersion != null)
                AddonVersion.Text = "Актуальная: " + GitHub.Version + "\n" + "У Вас: " + GitHub.MyVersion;
            else if (GitHub.MyVersion == null) AddonVersion.Text = "Актуальная: " + GitHub.Version + "\n";
            AddonVersion.Width = 140;
            AddonVersion.Height = 40;
            AddonVersion.Parent = AddonPanel.Parent;
            AddonVersion.Location = new Point(280, 0);
            AddonVersion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            if (GitHub.NeedUpdate == true) AddonVersion.ForeColor = Color.FromArgb(166, 0, 0);
            else AddonVersion.ForeColor = Color.FromArgb(44, 42, 63);
            AddonVersion.FlatAppearance.BorderSize = 0;
            AddonVersion.FlatStyle = FlatStyle.Flat;
            AddonVersion.TabStop = false;
        }

        void setAddonCategory()
        {
            AddonCategory = new Label();
            AddonCategory.Name = "LabelAuthor" + GitHub.Name + "row" + Row;
            AddonCategory.Text =GitHub.Category;
            AddonCategory.Width = 180;
            AddonCategory.Height = 40;
            AddonCategory.Parent = AddonPanel.Parent;
            AddonCategory.Location = new Point(420, 0);
            AddonCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddonCategory.ForeColor = Color.FromArgb(44, 42, 63);
            AddonCategory.TextAlign = ContentAlignment.MiddleLeft;
        }
        void setAddonAuthor()
        {
            AddonAuthor = new Label();
            AddonAuthor.Name = "LabelAuthor" + GitHub.Name + "row" + Row;
            AddonAuthor.Text = GitHub.Author;
            AddonAuthor.Width = 200;
            AddonAuthor.Height = 40;
            AddonAuthor.Parent = AddonPanel.Parent;
            AddonAuthor.Location = new Point(600, 0);
            AddonAuthor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddonAuthor.ForeColor = Color.FromArgb(44, 42, 63);
            AddonAuthor.TextAlign = ContentAlignment.MiddleLeft;
        }

        void setProgreddBar()
        {
            progressBar = new ProgressBar();
            progressBar.Name = $"progressBar{GitHub.Name}" + "row" + Row;
            progressBar.Width = 200;
            progressBar.Height = 10;
            progressBar.Parent = AddonPanel.Parent;
            progressBar.Location = new Point(0, 30);
            progressBar.Visible = false;
        }
    }
}

