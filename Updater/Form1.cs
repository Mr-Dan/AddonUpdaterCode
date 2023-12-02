using AddonUpdater.Controlers;
using AddonUpdater.Models;
using Newtonsoft.Json;
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
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Policy;
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

        public static void DirectoryDelete(string path)
        {
            DirectoryInfo directory = new(path);
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

        private async Task DownloadAppTask(string link)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            using HttpClient httpClient = new();
            await Task.Run(() =>  httpClient.DownloadFileTaskAsync(new Uri(link), "AddonUpdater.zip"));
        }

        private static void Backup()
        {
                if (Directory.Exists("Backup"))
                {
                    for (int i = 0; i < AddonUpdaterSetting.Setting.Files.Count; i++)
                    {
                        if (File.Exists(AddonUpdaterSetting.Setting.Files[i])) File.Delete(AddonUpdaterSetting.Setting.Files[i]);
                    }

                    for (int i = 0; i < AddonUpdaterSetting.Setting.Files.Count; i++)
                    {
                        if (File.Exists($"Backup\\{AddonUpdaterSetting.Setting.Files[i]}")) File.Move($"Backup\\{AddonUpdaterSetting.Setting.Files[i]}", AddonUpdaterSetting.Setting.Files[i]);
                    }
                    File.Delete("AddonUpdater.zip");
                    DirectoryDelete("AddonUpdater");
                    DirectoryDelete("Backup");
                }
            Application.Exit();
        }

        private static void Extract()
        {
            ZipFile.ExtractToDirectory("AddonUpdater.zip", Directory.GetCurrentDirectory()+ "\\AddonUpdater");

            for (int i = 0; i < AddonUpdaterSetting.Setting.Files.Count; i++)
            {
                if (File.Exists($"AddonUpdater\\{AddonUpdaterSetting.Setting.Files[i]}")) File.Move($"AddonUpdater\\{AddonUpdaterSetting.Setting.Files[i]}", Directory.GetCurrentDirectory() + $"\\{AddonUpdaterSetting.Setting.Files[i]}");
            }
            Process.Start(new ProcessStartInfo
            {
                FileName = "AddonUpdater.exe",
                UseShellExecute = true
            }); 
            File.Delete("AddonUpdater.zip");
            DirectoryDelete("AddonUpdater");
        }

        private static void ErrorMsg(int hResult)
        {
            if (hResult == -2146233079)
            {
                MessageBox.Show("Ошибка подключения, повторите попытку позже.", "Ошибка");

            }
            if (hResult == -2147467259)
            {
                MessageBox.Show("Операция была отменена пользователем.", "Ошибка");
            }
        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Button_Resize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public static async Task<string> GetContent(string url)
        {
            string result = null;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            HttpClient client = new();
            try
            {
                Stream stream = await client.GetStreamAsync(url);
                StreamReader reader = new(stream);
                result = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                ErrorMsg(ex.HResult);
            }
            return result;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {          
            if (File.Exists("Backup"))
            {
                Backup();
            }         
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Process[] proc = Process.GetProcessesByName("AddonUpdater");
            if (proc.Length > 0) proc[0].Kill();

            try
            {
                await AddonUpdaterSetting.GetSettingsTask();

                if (File.Exists("AddonUpdater.zip")) File.Delete("AddonUpdater.zip");
                await DownloadAppTask(AddonUpdaterSetting.Setting.AddonUpdaterLink);

                if (File.Exists("Backup")) DirectoryDelete("Backup");
                Directory.CreateDirectory("Backup");

                for (int i = 0; i < AddonUpdaterSetting.Setting.Files.Count; i++)
                {
                    if (File.Exists(AddonUpdaterSetting.Setting.Files[i])) File.Move(AddonUpdaterSetting.Setting.Files[i], $"Backup\\{AddonUpdaterSetting.Setting.Files[i]}");
                }
                try
                {
                    Extract();
                }
                catch (Exception ex)
                {
                    ErrorMsg(ex.HResult);
                    Backup();
                }

            }
            catch (Exception ex)
            {
                ErrorMsg(ex.HResult);
                Backup();
            }


            if (Directory.Exists("Backup")) DirectoryDelete("Backup");

            Application.Exit();
        }
    }
    public static class HttpClientUtils
    {
        public static async Task DownloadFileTaskAsync(this HttpClient client, Uri uri, string FileName)
        {
            using var s = await client.GetStreamAsync(uri);
            using var fs = new FileStream(FileName, FileMode.CreateNew);
            await s.CopyToAsync(fs);
        }
    }


}
