using AddonUpdater.Models;
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
    public partial class AddonDeleteSettingsControl : UserControl
    {
        GitHub addon;
        public AddonDeleteSettingsControl()
        {         
            InitializeComponent();
        }

        private void ClearComboBox()
        {
            accountComboBox.Items.Clear();
            accountComboBox.ResetText();
            realmComboBox.Items.Clear();
            realmComboBox.ResetText();
            personsComboBox.Items.Clear();
            personsComboBox.ResetText();
            settingsComboBox.Items.Clear();
            settingsComboBox.ResetText();
        }
        
        #region Click
        private void DeleteSettingsButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                   $"Вы точно хотите удалить {settingsComboBox.SelectedItem} настройки для {addon.Name}?",
                   "Подтверждение",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                string account = null;
                string realm = null;
                string person = null;
                string setting = null;
                if (accountComboBox.SelectedItem != null)
                {
                    account = accountComboBox.SelectedItem.ToString();
                }
                if (realmComboBox.SelectedItem != null)
                {
                    realm = realmComboBox.SelectedItem.ToString();
                }
                if (personsComboBox.SelectedItem != null)
                {
                    person = personsComboBox.SelectedItem.ToString();
                }
                if (settingsComboBox.SelectedItem != null)
                {
                    setting = settingsComboBox.SelectedItem.ToString();
                }

                if (account != null && realm != null && setting != null)
                {
                    if (setting == "Персональные")
                    {
                        int index = DownloadAddonGitHub.WTF.FindIndex(name => name.Account.Replace(Properties.Settings.Default.PathWow + "\\WTF\\Account\\", "") == account);
                        if (index != -1)
                        {
                            int index2 = DownloadAddonGitHub.WTF[index].Realms.FindIndex(name => name.Name.Replace(DownloadAddonGitHub.WTF[index].Account + "\\", "") == realm);
                            if (index2 != -1)
                            {

                                int index3 = DownloadAddonGitHub.WTF[index].Realms[index2].Persons.FindIndex(name => name.Replace(DownloadAddonGitHub.WTF[index].Realms[index2].Name + "\\", "") == person);
                                if (index3 != -1)
                                {
                                    string path = DownloadAddonGitHub.WTF[index].Realms[index2].Persons[index3] + "\\SavedVariables";
                                    if (Directory.Exists(path))
                                    {
                                        string[] getFiles = Directory.GetFiles(path);
                                        foreach (string file in getFiles)
                                        {
                                            string filenew = file.Replace(path + "\\", "");

                                            filenew = filenew.Replace(".lua.bak", "");
                                            filenew = filenew.Replace(".lua", "");

                                            if (addon.Files.FindIndex(addon => addon == filenew) > -1)
                                            {
                                                if (File.Exists(file)) File.Delete(file);

                                            }
                                        }
                                        MessageBox.Show("Персональные настройки удалены");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Папка не найдена");
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

                                if (addon.Files.FindIndex(addon => addon == filenew) > -1)
                                {
                                    if (File.Exists(file)) File.Delete(file);

                                }
                            }
                            MessageBox.Show("Глобальные настройки удалены");
                        }
                    }
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
        #endregion

        public void SetAddon(GitHub addon)
        {
            this.addon = addon;

            addonNameLabel.Text = addon.Name;
            if (Visible == false)
            {
                Visible = true;
                BringToFront();
                ClearComboBox();
                foreach (WTF wTF in DownloadAddonGitHub.WTF)
                {
                    accountComboBox.Items.Add(wTF.Account.Replace(Properties.Settings.Default.PathWow + "\\WTF\\Account\\", ""));
                }
            }
            else
            {
                Visible = false;
            }
        }

        #region TextChanged
        private void AccountComboBox_TextChanged(object sender, EventArgs e)
        {
            realmComboBox.Items.Clear();
            realmComboBox.ResetText();
            int index = accountComboBox.SelectedIndex;
            if (index != -1)
            {

                foreach (Realms realms in DownloadAddonGitHub.WTF[index].Realms)
                {
                    realmComboBox.Items.Add(realms.Name.Replace(DownloadAddonGitHub.WTF[index].Account + "\\", ""));
                }
            }
        }

        private void RealmComboBox_TextChanged(object sender, EventArgs e)
        {
            personsComboBox.Items.Clear();
            personsComboBox.ResetText();
            settingsComboBox.Items.Clear();
            settingsComboBox.ResetText();
            int indexAccount = accountComboBox.SelectedIndex;
            int indexRealm = realmComboBox.SelectedIndex;
            if (indexAccount != -1 && indexRealm != -1)
            {

                foreach (string person in DownloadAddonGitHub.WTF[indexAccount].Realms[indexRealm].Persons)
                {
                    personsComboBox.Items.Add(person.Replace(DownloadAddonGitHub.WTF[indexAccount].Realms[indexRealm].Name + "\\", ""));
                }
                if (addon.SavedVariables == true)
                {
                    settingsComboBox.Items.Add("Глобальные");
                }
            }
        }

        private void PersonsComboBox_TextChanged(object sender, EventArgs e)
        {
            settingsComboBox.Items.Clear();
            settingsComboBox.ResetText();
            if (addon.SavedVariables == true)
            {
                settingsComboBox.Items.Add("Глобальные");
            }
            if (addon.SavedVariablesPerCharacter == true)
            {
                settingsComboBox.Items.Add("Персональные");
            }
        }
        #endregion
       
    }
}
