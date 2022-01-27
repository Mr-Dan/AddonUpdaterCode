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
    public partial class FormAllAddons : Form
    {
        DownloadAddonGitHub downloadAddonGitHub = new DownloadAddonGitHub();
        List<GitHub> GitHubs { get; set; }
        public FormAllAddons(List<GitHub> _gitHubs)
        {
            GitHubs = new List<GitHub>(_gitHubs); 
            InitializeComponent();        
        }

        private void FormAllAddons_Load(object sender, EventArgs e)
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
       
        private void dataGridViewAddons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Properties.Settings.Default.download == null)
            {
                if (e.ColumnIndex == 2)
                {
                    int index = DownloadAddonGitHub.GitHubs.FindIndex(find => find.Name == dataGridViewAddons.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (index > -1)
                        if ((bool)dataGridViewAddons.Rows[e.RowIndex].Cells[2].Value == true)
                        {
                            dataGridViewAddons.Rows[e.RowIndex].Cells[2].Value = false;
                            DownloadAddonGitHub.GitHubs[index].Download = false;
                        }
                        else
                        {
                            dataGridViewAddons.Rows[e.RowIndex].Cells[2].Value = true;
                            DownloadAddonGitHub.GitHubs[index].Download = true;
                        }

                    //MessageBox.Show("Нажата кнопка на строке " + e.RowIndex.ToString());                          
                    // await downloadAddonGitHub.DownloadAddon(dataGridViewAddons.Rows[e.RowIndex].Cells[0].Value.ToString());
                    // updateDataGridViewAddons();
                }
            }
        }
        public void updateDataGridViewAddonsFirst()
        {
            //await downloadAddonGitHub.Aupdatecheck();
            if(dataGridViewAddons.Rows.Count != 0)dataGridViewAddons.Rows.Clear();
            for (int i = 0; i < GitHubs.Count; i++)
            {
                if (dataGridViewAddons.Columns.Count > 0)
                    dataGridViewAddons.Rows.Add(
                    new object[]
                    {
                                GitHubs[i].Name,
                                GitHubs[i].Version,
                                GitHubs[i].Download
                    }
                );
            }
        }
        private async void updateDataGridViewAddons()
        {
            labelInfo.Text = "Обновление";
            Properties.Settings.Default.download = "Обновление";
            button_Dowload.Enabled = false;
            button_update.Enabled = false;

            progressBar1.Value = 0;
            progressBar1.Maximum = 2;
            progressBar1.Value++;
            await downloadAddonGitHub.Aupdatecheck();
            if(dataGridViewAddons.Rows.Count != 0)dataGridViewAddons.Rows.Clear();
            for (int i = 0; i < DownloadAddonGitHub.GitHubs.Count; i++)
            {
                if (dataGridViewAddons.Columns.Count > 0)
                    dataGridViewAddons.Rows.Add(
                    new object[]
                    {
                                DownloadAddonGitHub.GitHubs[i].Name,
                                DownloadAddonGitHub.GitHubs[i].Version,
                                DownloadAddonGitHub.GitHubs[i].Download
                    }
                );
            }
            FormMainMenu.GitHubs = new List<GitHub>(DownloadAddonGitHub.GitHubs);
            progressBar1.Value++;
           
            progressBar1.Value = 0;
            labelInfo.Text = "";
            Properties.Settings.Default.download = null;       
            button_Dowload.Enabled = true;
            button_update.Enabled = true;
        }
    
        private async void button_Dowload_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.download = "Скачивание";
            button_Dowload.Enabled = true;
            button_update.Enabled = true;
            await DownloadAddon();
            updateDataGridViewAddons();
            Properties.Settings.Default.download = null;
            button_Dowload.Enabled = true;
            button_update.Enabled = true;
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

            await downloadAddonGitHub.GetAddon();           
            progressBar1.Value = 0;
            labelInfo.Text = "";
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            updateDataGridViewAddons();
        }
    }
}
