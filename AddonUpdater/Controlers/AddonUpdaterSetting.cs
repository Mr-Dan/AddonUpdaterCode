using AddonUpdater.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AddonUpdater.Controlers
{
    class AddonUpdaterSetting
    {

        public static Setting Setting = new();

        public static Task GetSettingsTask()
        {
            return Task.Run(async() => await GetSettingsAsync());
        }

        private static async Task GetSettingsAsync()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            using HttpClient client = new();
            try
            {
                Stream stream = await client.GetStreamAsync("https://raw.githubusercontent.com/Mr-Dan/AddonUpdaterSettings/main/MainSettings");
                StreamReader reader = new(stream);
                string result = reader.ReadToEnd();
                Setting = JsonConvert.DeserializeObject<Setting>(result);

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ошибка подключения, повторите попытку позже", "Ошибка");
                // Application.Exit();
                //MessageBox.Show(ex.ToString(), "Предупреждение");
            }
        }
    }
}
