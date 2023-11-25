using AddonUpdater.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AddonUpdater.Controlers
{
    class AddonUpdaterSettingApp
    {
        public static SettingApp SettingsApp = new();
        
        public static void Save()
        {          
            string text = JsonConvert.SerializeObject(SettingsApp);
            using (StreamWriter writer = new StreamWriter("setting", false))
            {
                writer.WriteLine(text);
            }     
        }

        public static void ReadAppSetting()
        {
            if (File.Exists("setting"))
            {
                string text = "";
                using (StreamReader reader = new StreamReader("setting", false))
                {
                    text = reader.ReadLine();
                }
                SettingsApp = JsonConvert.DeserializeObject<SettingApp>(text);
            }
            else
            {
                SettingsApp = GetDefaultSetting();
            }
        }

        private static SettingApp GetDefaultSetting()
        {
            SettingApp SettingsApp = new SettingApp()
            {
                PathWow = "",
                AutoUpdateBool = false,
                DescriptionBool = true,
                LastUpdate = new List<LastUpdateAddon>(),
                LauncherOpen = false,
                UpdateAddon = new List<string>(),
                PathsWow = new List<string>(),
                BackupWTF = "Никогда"

            };
            return SettingsApp;
        }
    }
}
