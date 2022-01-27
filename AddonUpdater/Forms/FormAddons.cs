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

        public FormAddons(List<GitHub> _gitHubs)
        {
            GitHubs = new List<GitHub>(_gitHubs);
            InitializeComponent();         
        }
            
        private void FormAddons_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PathWow.Length > 0)
            {
                updateDataGridViewAddonsFirst();     
            }
            else
            {
                MessageBox.Show("Укажите путь к игре в настройках", "Предупреждение");

            }           
        }
   
        public async Task DownloadAddon()
        {
            progressBar1.Value = 0;
            DownloadAddonGitHub.NeedUpdate.Clear();
            DownloadAddonGitHub.NeedUpdate = DownloadAddonGitHub.GitHubs.FindAll(find => find.Download == true);
            progressBar1.Maximum = DownloadAddonGitHub.NeedUpdate.Count;
            for (int i = 0; i < DownloadAddonGitHub.NeedUpdate.Count; i++)
            {
                labelInfo.Text = DownloadAddonGitHub.NeedUpdate[i].Name;            
               
                await downloadAddonGitHub.DownloadAddonGitHubTask(DownloadAddonGitHub.NeedUpdate[i].link, DownloadAddonGitHub.NeedUpdate[i].Name, DownloadAddonGitHub.NeedUpdate[i].Directory, DownloadAddonGitHub.NeedUpdate[i].Branches);
                progressBar1.Value++;
            }
            labelInfo.Text = "Распаковка Аддонов";
            await downloadAddonGitHub.GetAddon();        
            progressBar1.Value = 0;
            labelInfo.Text = "";
        }
        public async Task DownloadAddonAuto()
        {
            progressBar1.Value = 0;
            DownloadAddonGitHub.NeedUpdate.Clear();
            DownloadAddonGitHub.NeedUpdate = DownloadAddonGitHub.GitHubs.FindAll(find => find.NeedUpdate == true);
            progressBar1.Maximum = DownloadAddonGitHub.NeedUpdate.Count;
            for (int i = 0; i < DownloadAddonGitHub.NeedUpdate.Count; i++)
            {
                labelInfo.Text = DownloadAddonGitHub.NeedUpdate[i].Name;

                await downloadAddonGitHub.DownloadAddonGitHubTask(DownloadAddonGitHub.NeedUpdate[i].link, DownloadAddonGitHub.NeedUpdate[i].Name, DownloadAddonGitHub.NeedUpdate[i].Directory, DownloadAddonGitHub.NeedUpdate[i].Branches);
                progressBar1.Value++;
            }
            labelInfo.Text = "Распаковка Аддонов";
            await downloadAddonGitHub.GetAddon();         
            progressBar1.Value = 0;
            labelInfo.Text = "";
        }
        private void dataGridViewAddons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Properties.Settings.Default.download == null)
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

        public async void updateDataGridViewAddonsFirst()
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
                            dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[2].Style.BackColor = Color.Red;
                            dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[2].Style.SelectionBackColor = Color.Red;
                        }
                                                 
                    }
                }
            }
 
            if (Properties.Settings.Default.AutoUpdateBool == true && Properties.Settings.Default.AutoUpdateCount > 0)
            {
                Properties.Settings.Default.download = "Скачивание";
                button_Delete.Enabled = false;
                button_Dowload.Enabled = false;
                button_update.Enabled = false;
                await DownloadAddonAuto();
                updateDataGridViewAddons();
                Properties.Settings.Default.AutoUpdateCount = 0;
                Properties.Settings.Default.download = null;
                button_Delete.Enabled = true;
                button_Dowload.Enabled = true;
                button_update.Enabled = true;
            }

        }

        public async void updateDataGridViewAddons()
        {

           labelInfo.Text = "Обновление";
           Properties.Settings.Default.download = "Обновление";
           button_Delete.Enabled = false;
           button_Dowload.Enabled = false;
           button_update.Enabled = false;

           progressBar1.Value = 0;
           progressBar1.Maximum = 2;
           progressBar1.Value++;
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
                    dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[2].Style.BackColor = Color.Red;
                    dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[2].Style.SelectionBackColor = Color.Red;
                }
            }

            FormMainMenu.GitHubs = new List<GitHub>(DownloadAddonGitHub.GitHubs);
            progressBar1.Value++;
        
            progressBar1.Value = 0;
            labelInfo.Text = "";
            Properties.Settings.Default.download = null;
            button_Delete.Enabled = true;
            button_Dowload.Enabled = true;
            button_update.Enabled = true;

            if (Properties.Settings.Default.AutoUpdateBool == true && Properties.Settings.Default.AutoUpdateCount>0)
            {
                Properties.Settings.Default.download = "Скачивание";
                button_Delete.Enabled = false;
                button_Dowload.Enabled = false;
                button_update.Enabled = false;
                await DownloadAddonAuto();
                updateDataGridViewAddons();
                Properties.Settings.Default.AutoUpdateCount = 0;
                Properties.Settings.Default.download = null;
                button_Delete.Enabled = true;
                button_Dowload.Enabled = true;
                button_update.Enabled = true;
            }
        }
        private async void button_Dowload_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.download = "Скачивание";
            button_Delete.Enabled = false;
            button_Dowload.Enabled = false;
            button_update.Enabled = false;
            await DownloadAddon();
            updateDataGridViewAddons();
            Properties.Settings.Default.download = null;
            button_Delete.Enabled = true;
            button_Dowload.Enabled = true;
            button_update.Enabled = true;
        }
   

        private void button_Delete_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.download = "Удаления";
            // await downloadAddonGitHub.DeleteAddonAsync();
            downloadAddonGitHub.DeleteAddon();
            updateDataGridViewAddons();
            //Properties.Settings.Default.download = null;
        }

        private void button_update_Click(object sender, EventArgs e)
        {  
            updateDataGridViewAddons();                 
        }
    }

}
