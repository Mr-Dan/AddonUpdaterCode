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
        List<GitHub> GitHubs { get; set;}
        FormMainMenu FormMainMenu;
        public FormAddons(List<GitHub> _gitHubs, FormMainMenu owner)
        {
            FormMainMenu = owner;
            GitHubs = new List<GitHub>(_gitHubs);
            InitializeComponent();         
        }
            
        private void FormAddons_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PathWow.Length > 0)
            {
                if(FormMainMenu.progressBar1.Visible== false)
                {
                    FormMainMenu.progressBar1.Visible = true;
                    FormMainMenu.labelInfo.Visible = true;
                }
                updateDataGridViewAddonsFirst();     
            }
            else
            {
                MessageBox.Show("Укажите путь к игре в настройках", "Предупреждение");
            }           
        }
   
        public async Task DownloadAddon(string flag)
        {
            try
            {
                FormMainMenu.progressBar1.Value = 0;
                DownloadAddonGitHub.NeedUpdate.Clear();
                if(flag == "Download") DownloadAddonGitHub.NeedUpdate = DownloadAddonGitHub.GitHubs.FindAll(find => find.Download == true);
                else if(flag == "AutoDownload") DownloadAddonGitHub.NeedUpdate = DownloadAddonGitHub.GitHubs.FindAll(find => find.NeedUpdate == true);

                FormMainMenu.progressBar1.Maximum = DownloadAddonGitHub.NeedUpdate.Count;
                for (int i = 0; i < DownloadAddonGitHub.NeedUpdate.Count; i++)
                {
                    FormMainMenu.labelInfo.Text = DownloadAddonGitHub.NeedUpdate[i].Name;
                    await downloadAddonGitHub.DownloadAddonGitHubTask(DownloadAddonGitHub.NeedUpdate[i].link, DownloadAddonGitHub.NeedUpdate[i].Name, DownloadAddonGitHub.NeedUpdate[i].Directory, DownloadAddonGitHub.NeedUpdate[i].Branches);
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
   
        private void dataGridViewAddons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FormMainMenu.activity == null)
            {
                if (e.ColumnIndex == 3 && e.RowIndex != -1)
                {
                    int index = DownloadAddonGitHub.GitHubs.FindIndex(find => find.Name == dataGridViewAddons.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (index != -1)
                    if ((bool)dataGridViewAddons.Rows[e.RowIndex].Cells[3].Value == true)
                    {
                        dataGridViewAddons.Rows[e.RowIndex].Cells[3].Value = false;
                        DownloadAddonGitHub.GitHubs[index].Download = false;
                    }
                    else
                    {
                        dataGridViewAddons.Rows[e.RowIndex].Cells[3].Value = true;
                        DownloadAddonGitHub.GitHubs[index].Download = true;
                    }                        
                }
                else if (e.ColumnIndex == 4 && e.RowIndex != -1)
                {
                    int index = DownloadAddonGitHub.GitHubs.FindIndex(find => find.Name == dataGridViewAddons.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (index != -1)
                    if ((bool)dataGridViewAddons.Rows[e.RowIndex].Cells[4].Value == true)
                    {
                        dataGridViewAddons.Rows[e.RowIndex].Cells[4].Value = false;
                        DownloadAddonGitHub.GitHubs[index].Delete = false;
                    }
                    else
                    {
                        dataGridViewAddons.Rows[e.RowIndex].Cells[4].Value = true;
                        DownloadAddonGitHub.GitHubs[index].Delete = true;
                    }
                }

            }
           
        }

        public void updateDataGridViewAddonsFirst()
        {       
            if (dataGridViewAddons.Rows.Count != 0)dataGridViewAddons.Rows.Clear();
            for (int i = 0; i < GitHubs.Count; i++)
            {
                if (GitHubs[i].MyVersion != null)
                {
                    if (dataGridViewAddons.Columns.Count > 0)
                    {
                    
                        dataGridViewAddons.Rows.Add(
                            new object[]
                            {
                                GitHubs[i].Name,
                                GitHubs[i].Version,
                                GitHubs[i].MyVersion,
                                GitHubs[i].Download,
                                false
                            }
                        );    
                        
                        if (GitHubs[i].NeedUpdate)
                        {
                            dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[0].Style.ForeColor = Color.FromArgb(166, 0, 0);
                            dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[0].Style.SelectionForeColor = Color.FromArgb(166, 0, 0);
                            dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[2].Style.ForeColor = Color.FromArgb(166, 0, 0);
                            dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[2].Style.SelectionForeColor = Color.FromArgb(166, 0, 0);
                        }                                               
                    }
                }
            }
 
            if (Properties.Settings.Default.AutoUpdateBool == true && FormMainMenu.UpdateCount > 0)
            {
                FormMainMenu.ButtonOff();
                AddonDownload("AutoDownload");
               
            }
           
        }

        public async void updateDataGridViewAddons()
        {
           FormMainMenu.labelInfo.Text = "Обновление";
           FormMainMenu.activity = "обновления";
           button_Delete.Enabled = false;
           button_Dowload.Enabled = false;
           button_update.Enabled = false;

           FormMainMenu.progressBar1.Value = 0;
           FormMainMenu.progressBar1.Maximum = 2;
           FormMainMenu.progressBar1.Value++;

           await downloadAddonGitHub.Aupdatecheck();
           
            if (dataGridViewAddons.Rows.Count !=0 )
            dataGridViewAddons.Rows.Clear();
            for (int i = 0; i < DownloadAddonGitHub.GitHubs.Count; i++)
            {
                if (DownloadAddonGitHub.GitHubs[i].MyVersion !=null)
                    if (dataGridViewAddons.Columns.Count >0)
                        dataGridViewAddons.Rows.Add(
                    new object[]
                    {
                                DownloadAddonGitHub.GitHubs[i].Name,
                                DownloadAddonGitHub.GitHubs[i].Version,
                                DownloadAddonGitHub.GitHubs[i].MyVersion,
                                DownloadAddonGitHub.GitHubs[i].Download,
                                false
                    }
                );

                if (DownloadAddonGitHub.GitHubs[i].NeedUpdate)
                {
                    if (dataGridViewAddons.Rows.Count != 0)
                    {
                        dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[0].Style.ForeColor = Color.FromArgb(166, 0, 0);
                        dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[0].Style.SelectionForeColor = Color.FromArgb(166, 0, 0);
                        dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[2].Style.ForeColor = Color.FromArgb(166, 0, 0);
                        dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[2].Style.SelectionForeColor = Color.FromArgb(166, 0, 0);
                    }
                }
            }

            FormMainMenu.GitHubs = new List<GitHub>(DownloadAddonGitHub.GitHubs);
            FormMainMenu.progressBar1.Value++;
            FormMainMenu.progressBar1.Value = 0;
            FormMainMenu.labelInfo.Text = "";
            FormMainMenu.activity = null;
            button_Delete.Enabled = true;
            button_Dowload.Enabled = true;
            button_update.Enabled = true;

            if (Properties.Settings.Default.AutoUpdateBool == true && FormMainMenu.UpdateCount > 0)
            {
                FormMainMenu.ButtonOff();
                AddonDownload("AutoDownload");
               
            }
            FormMainMenu.ButtonOn();
        }
        
        private void button_Dowload_Click(object sender, EventArgs e)
        {
           
            if (DownloadAddonGitHub.GitHubs.FindAll(find => find.Download == true).Count > 0)
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
            FormMainMenu.activity = "Cкачивания";
            button_Delete.Enabled = false;
            button_Dowload.Enabled = false;
            button_update.Enabled = false;
            await DownloadAddon(flag);
            updateDataGridViewAddons();
            FormMainMenu.activity = null;
            button_Delete.Enabled = true;
            button_Dowload.Enabled = true;
            button_update.Enabled = true;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (DownloadAddonGitHub.GitHubs.FindAll(find => find.Delete == true).Count > 0)
            {
                FormMainMenu.ButtonOff();
                downloadAddonGitHub.DeleteAddon();
                updateDataGridViewAddons();
            }
            else
            {
                MessageBox.Show("Выберите аддоны для удаления", "Ошибка");
            }                 
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            FormMainMenu.ButtonOff();
            updateDataGridViewAddons();
           
        }

        private void buttonLauncher_Click(object sender, EventArgs e)
        {
            string pathLauncher = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Programs\\sirus-open-launcher\\Sirus Launcher.exe";        
            Process[] proc = Process.GetProcessesByName("Sirus Launcher");
            if (proc.Length == 0)
            {
                if (File.Exists(pathLauncher))
                    Process.Start(pathLauncher);
            }
            else
            {
                for (int i = 0; i < proc.Length; i++)
                    proc[i].Kill();
                if (File.Exists(pathLauncher))
                    Process.Start(pathLauncher);
            }
        }

 
    }
}
