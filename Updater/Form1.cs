using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }    
        
        public void DirectoryDelete(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            try
            {
                if (Directory.Exists(path))
                    directory.Delete(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Предупреждение");
            }
        }
        
        private Task DownloadAppTask(string link )
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            using (WebClient webClient = new WebClient())
            {
                return webClient.DownloadFileTaskAsync(link, "AddonUpdater.zip");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
           
        }

        private async void buttonYes_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
         
            buttonNo.Visible = false;
            buttonYes.Visible = false;
            button_Close.Enabled = false;
            label1.Text = "Идет обновление";

            Process[] proc = Process.GetProcessesByName("AddonUpdater");
            if (proc.Length > 0) proc[0].Kill();

            DirectoryDelete("Backup");
            Directory.CreateDirectory("Backup");
            if (File.Exists("AddonUpdater.exe")) File.Move("AddonUpdater.exe", "Backup\\AddonUpdater.exe");

            try
            {
                await DownloadAppTask("https://github.com/Mr-Dan/AddonUpdaterExe/archive/refs/heads/main.zip");

            }
            catch 
            {
               
                if (File.Exists("AddonUpdater.exe")) File.Delete("AddonUpdater.exe");

                if(File.Exists("Backup\\AddonUpdater.exe"))
                {
                    File.Move("Backup\\AddonUpdater.exe", "AddonUpdater.exe");
                    DirectoryDelete("Backup");
                    MessageBox.Show("Ошибка подключения, повторите попытку позже", "Ошибка Addon Updater");                 
                }
                Application.Exit();
            }

            try
            {            
                ZipFile.ExtractToDirectory("AddonUpdater.zip", Directory.GetCurrentDirectory());
                File.Move("AddonUpdaterExe-main\\AddonUpdater.exe", Directory.GetCurrentDirectory() + "\\AddonUpdater.exe");
                Process.Start("AddonUpdater.exe");
                File.Delete("AddonUpdater.zip");
                DirectoryDelete("AddonUpdaterExe-main");
                DirectoryDelete("Backup");            

            }
            catch 
            {
                
            }
            Application.Exit();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button_Resize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
