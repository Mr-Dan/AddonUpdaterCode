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
                if(flag == "Download") DownloadAddonGitHub.NeedUpdate = DownloadAddonGitHub.GitHubs.FindAll(find => find.DownloadMyAddon == true);
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
                        DownloadAddonGitHub.GitHubs[index].DownloadMyAddon = false;
                    }
                    else
                    {
                        dataGridViewAddons.Rows[e.RowIndex].Cells[3].Value = true;
                        DownloadAddonGitHub.GitHubs[index].DownloadMyAddon = true;
                    }                        
                }
                else if (e.ColumnIndex == 5 && e.RowIndex != -1)
                {
                    int index = DownloadAddonGitHub.GitHubs.FindIndex(find => find.Name == dataGridViewAddons.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (index != -1)
                    if ((bool)dataGridViewAddons.Rows[e.RowIndex].Cells[5].Value == true)
                    {
                        dataGridViewAddons.Rows[e.RowIndex].Cells[5].Value = false;
                        DownloadAddonGitHub.GitHubs[index].Delete = false;
                    }
                    else
                    {
                        dataGridViewAddons.Rows[e.RowIndex].Cells[5].Value = true;
                        DownloadAddonGitHub.GitHubs[index].Delete = true;
                    }
                }
                else if (e.ColumnIndex == 4 && e.RowIndex != -1)
                {
                    int index = DownloadAddonGitHub.GitHubs.FindIndex(find => find.Name == dataGridViewAddons.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (index != -1)
                    if ((bool)dataGridViewAddons.Rows[e.RowIndex].Cells[4].Value == true)
                    {
                        dataGridViewAddons.Rows[e.RowIndex].Cells[4].Value = false;
                        DownloadAddonGitHub.GitHubs[index].Blacklist = false;
                        if(DownloadAddonGitHub.GitHubs[index].Version != DownloadAddonGitHub.GitHubs[index].MyVersion)
                        {
                            DownloadAddonGitHub.GitHubs[index].NeedUpdate = true;
                            DownloadAddonGitHub.GitHubs[index].DownloadMyAddon = true;
                            dataGridViewAddons.Rows[e.RowIndex].Cells[3].Value = true;
                            dataGridViewAddons.Rows[e.RowIndex].Cells[0].Style.ForeColor = Color.FromArgb(166, 0, 0);
                            dataGridViewAddons.Rows[e.RowIndex].Cells[0].Style.SelectionForeColor = Color.FromArgb(166, 0, 0);
                            dataGridViewAddons.Rows[e.RowIndex].Cells[2].Style.ForeColor = Color.FromArgb(166, 0, 0);
                            dataGridViewAddons.Rows[e.RowIndex].Cells[2].Style.SelectionForeColor = Color.FromArgb(166, 0, 0);
                            FormMainMenu.UpdateCount++;
                            DownloadAddonGitHub.UpdateInfo = true;
                        }
                        
                            while(Properties.Settings.Default.AddonBlacklist.Contains(DownloadAddonGitHub.GitHubs[index].Name))
                            {
                                Properties.Settings.Default.AddonBlacklist.Remove(DownloadAddonGitHub.GitHubs[index].Name);
                            }
                        Properties.Settings.Default.Save();

                      
                    }
                    else
                    {
                        dataGridViewAddons.Rows[e.RowIndex].Cells[4].Value = true;
                        dataGridViewAddons.Rows[e.RowIndex].Cells[3].Value = false;
                        DownloadAddonGitHub.GitHubs[index].NeedUpdate = false;
                        DownloadAddonGitHub.GitHubs[index].DownloadMyAddon = false;
                        DownloadAddonGitHub.GitHubs[index].Blacklist = true;
                        dataGridViewAddons.Rows[e.RowIndex].Cells[0].Style.ForeColor = Color.FromArgb(44, 42, 63);
                        dataGridViewAddons.Rows[e.RowIndex].Cells[0].Style.SelectionForeColor = Color.FromArgb(44, 42, 63);
                        dataGridViewAddons.Rows[e.RowIndex].Cells[2].Style.ForeColor = Color.FromArgb(44, 42, 63);
                        dataGridViewAddons.Rows[e.RowIndex].Cells[2].Style.SelectionForeColor = Color.FromArgb(44, 42, 63);
                        Properties.Settings.Default.AddonBlacklist.Add(DownloadAddonGitHub.GitHubs[index].Name);
                        Properties.Settings.Default.Save();

                        if (DownloadAddonGitHub.GitHubs[index].Version != DownloadAddonGitHub.GitHubs[index].MyVersion)
                        {
                            FormMainMenu.UpdateCount--; 
                        }
                    }                  
                }
            }      
        }

        Point Point;
        private void dataGridViewAddons_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (PanelDescription.Visible == true)
            {
                PanelDescription.Visible = false;
                LabelDescription.Text = null;
            }
        }

        private void dataGridViewAddons_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(Properties.Settings.Default.DescriptionBool)
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                int index = DownloadAddonGitHub.GitHubs.FindIndex(find => find.Name == dataGridViewAddons.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (index != -1)
                {
                    if (DownloadAddonGitHub.GitHubs[index].Description != String.Empty)
                    if (PanelDescription.Visible == false)
                    {
                        LabelDescription.Text = DownloadAddonGitHub.GitHubs[index].Description;
                     
                        Size len = TextRenderer.MeasureText(DownloadAddonGitHub.GitHubs[index].Description, LabelDescription.Font);
                        int size = len.Width * len.Height;
                        PanelDescription.Size = new Size(800, (size / 800) + 20);

                        if (Point.Y + PanelDescription.Height + 25 > dataGridViewAddons.Height)
                             PanelDescription.Location = new Point(0, Point.Y - e.Y - PanelDescription.Height);
                        else
                            PanelDescription.Location = new Point(0, Point.Y - e.Y + 25);

                        PanelDescription.Visible = true;

                    }
                }
            }
        }

        private void dataGridViewAddons_MouseMove(object sender, MouseEventArgs e)
        {
            Point = new Point(e.X, e.Y);   
        }
              
        public void updateDataGridViewAddonsFirst()
        {
    
           /* dataGridViewAddons.RowsDefaultCellStyle.BackColor = Color.FromArgb(223, 225, 229);
            dataGridViewAddons.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(223, 225, 229);
            dataGridViewAddons.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 240, 242);
            dataGridViewAddons.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(239, 240, 242);*/

            if (dataGridViewAddons.Rows.Count != 0)dataGridViewAddons.Rows.Clear();
            for (int i = 0; i < DownloadAddonGitHub.GitHubs.Count; i++)
            {
                if (DownloadAddonGitHub.GitHubs[i].MyVersion != null)
                {
                    if (dataGridViewAddons.Columns.Count > 0)
                    {
                    
                        dataGridViewAddons.Rows.Add(
                            new object[]
                            {
                                DownloadAddonGitHub.GitHubs[i].Name,
                                DownloadAddonGitHub.GitHubs[i].Version,
                                DownloadAddonGitHub.GitHubs[i].MyVersion,
                                DownloadAddonGitHub.GitHubs[i].DownloadMyAddon,                              
                                DownloadAddonGitHub.GitHubs[i].Blacklist,
                                false
                            }
                        );
                        
                        if (DownloadAddonGitHub.GitHubs[i].NeedUpdate) 
                            DataGridViewAddonsRowsForeColor();

                       /* if (dataGridViewAddons.Rows.Count % 2 == 0)
                            DataGridViewAddonsRowsBackColor(Color.FromArgb(239, 240, 242));
                        else
                            DataGridViewAddonsRowsBackColor(Color.FromArgb(223, 225, 229));*/
                    }
                }
            }
 
            if (Properties.Settings.Default.AutoUpdateBool == true && FormMainMenu.UpdateCount > 0)
            {
                FormMainMenu.ButtonOff();
                AddonDownload("AutoDownload");
               
            }       
        }
        
        private async void updateDataGridViewAddons()
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
                        DownloadAddonGitHub.GitHubs[i].DownloadMyAddon,                     
                        DownloadAddonGitHub.GitHubs[i].Blacklist,
                        false
                    }
                );

                if (DownloadAddonGitHub.GitHubs[i].NeedUpdate)
                    DataGridViewAddonsRowsForeColor();

            /*    if (dataGridViewAddons.Rows.Count % 2 == 0)
                    DataGridViewAddonsRowsBackColor(Color.FromArgb(239, 240, 242));
                else
                    DataGridViewAddonsRowsBackColor(Color.FromArgb(223, 225, 229));*/
            }
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

        private void DataGridViewAddonsRowsForeColor()
        {
            if (dataGridViewAddons.Rows.Count != 0)
            {
                dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[0].Style.ForeColor = Color.FromArgb(166, 0, 0);
                dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[0].Style.SelectionForeColor = Color.FromArgb(166, 0, 0);
                dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[2].Style.ForeColor = Color.FromArgb(166, 0, 0);
                dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].Cells[2].Style.SelectionForeColor = Color.FromArgb(166, 0, 0);
            }
        }

      /*  private void DataGridViewAddonsRowsBackColor(Color color)
        {
            if (dataGridViewAddons.Rows.Count != 0)
            {
                dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].DefaultCellStyle.BackColor = color;
                dataGridViewAddons.Rows[dataGridViewAddons.Rows.Count - 1].DefaultCellStyle.SelectionBackColor = color;

            }
        }*/
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
            ActiveControl = null;
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
            ActiveControl = null;
            FormMainMenu.ButtonOff();
            updateDataGridViewAddons();         
        }

        private void buttonLauncher_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
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
