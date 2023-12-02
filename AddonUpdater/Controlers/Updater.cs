using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Windows.Forms;
using AddonUpdater.Models;

namespace AddonUpdater.Controlers
{
    class Updater
    {
        private static string NameExe = "Update.exe";
        public static bool CheckUpdate()
        {
            if (File.Exists(NameExe))
            {
                string version = FileVersionInfo.GetVersionInfo(NameExe).ProductVersion;

                if (AddonUpdaterSetting.Setting.VersionUpdate != version)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void UpdateAddonUpdate()
        {

        }

        public static void Run()
        {
            if (File.Exists(NameExe))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = NameExe,
                    UseShellExecute = true
                });
            }
        }

        public static async Task DownloadAsync()
        {
            try
            {
                if (File.Exists(NameExe))
                {
                    File.Delete(NameExe);
                }

                await DownloadUpdaterTask(AddonUpdaterSetting.Setting.UpdateLink, NameExe);

                if (File.Exists(NameExe))
                {
                    Run();
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146233079)
                {
                    MessageBox.Show("Ошибка подключения, повторите попытку позже", "Ошибка Addon Updater");

                }
                if (ex.HResult == -2147467259)
                {
                    // MessageBox.Show("Необходимо открыть от имени администратора", "Ошибка Addon Updater");
                }
            }
        }

        private static async Task DownloadUpdaterTask(string link, string name)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            using HttpClient webClient = new();
            await Task.Run(() => webClient.DownloadFileTaskAsync(new Uri(link), name));
        }

    }
}
