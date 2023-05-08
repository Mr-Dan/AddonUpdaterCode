using AddonUpdater.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace AddonUpdater.Controls
{
    public partial class ModificationsControl : UserControl
    {
        //public static HttpClient httpClient;
        //public static HttpRequestMessage requestForCheck;
        private FormMainMenu formMainMenu;
        public ModificationsControl(FormMainMenu owner)
        {
            //httpClient = new HttpClient();
            //requestForCheck = new HttpRequestMessage(HttpMethod.Get, "http://51.15.228.31:8080/api/client/patches");

            formMainMenu = owner;
            InitializeComponent();
        }

        [DllImport("PatchCreator.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool PatchCreate(SpellMap[] SpellDBC, int SpellDBCCount, SpellMap[] SpellVisualKitDBC, int SpellVisualKitDBCCount, string path);

        private Task<bool> PatchLoad(SpellMap[] SpellDBC, int SpellDBCCount, SpellMap[] SpellVisualKitDBC, int SpellVisualKitDBCCount, string path)
        {
            var test = Task.Run(() =>
            {
                try
                {
                    return PatchCreate(SpellDBC, SpellDBCCount, SpellVisualKitDBC,SpellVisualKitDBCCount, path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            });

            return test;
        }

        private async void buttonPatchLoad_Click(object sender, EventArgs e)
        {
            ActiveControl = null;

            DialogResult dialogResult = MessageBox.Show(
                   $"Внимание МЫ не несем ответственности за данный патч. ВЫ используете его на свой страх и риск. Продолжить?",
                   "ВНИМАНИЕ",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                if (Properties.Settings.Default.PathWow != null)
                {
                    try
                    {
                        formMainMenu.ButtonOff();
                        buttonPatchLoad.Enabled = false;
                        buttonDeletePath.Enabled = false;
                        progressBar1.Maximum = 3;
                        progressBar1.Visible = true;
                        progressBar1.Value++;

                        SpellMap[] SpellDBC = GetSpell(DownloadAddonGitHub.AddonUpdaterSettings.ListSpells);
                        if (SpellDBC == null)
                        {
                            throw new Exception();
                        }

                        SpellMap[] SpellVisualKitDBC = GetSpell(DownloadAddonGitHub.AddonUpdaterSettings.ListSpellVisualKit);
                        if (SpellVisualKitDBC == null)
                        {
                            throw new Exception();
                        }
                      
                        bool isCreate = await PatchLoad(SpellDBC, SpellDBC.Length, SpellVisualKitDBC, SpellVisualKitDBC.Length, Properties.Settings.Default.PathWow);
                        progressBar1.Value++;
                        if (isCreate)
                        {
                            MessageBox.Show("Патч создан");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка. Убедитесь, что :\n 1. Игра не запущена. \n 2. patch-ruRU-[.mpq не открыт в другой программе. \n 3. Присутствует данный файл /Data/ruRU/patch-ruRU-4.mpq. \n 4. Необходимо обновить Microsoft Visual C++ Redistributable до последней версии.");
                        }


                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    progressBar1.Value = 0;
                    progressBar1.Visible = false;
                    formMainMenu.ButtonOn();
                    buttonPatchLoad.Enabled = true;
                    buttonDeletePath.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Не найдет путь к игре.");
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SpellMap
        {
            public int Key { get; set; }
            public int Value { get; set; }
        }

        private void buttonDeletePath_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            DialogResult dialogResult = MessageBox.Show(
                   $"Вы точно хотите удалить патч?",
                   "Подтверждение",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                if (Properties.Settings.Default.PathWow != null)
                {
                    try
                    {
                        if (File.Exists(Properties.Settings.Default.PathWow + "/Data/ruRU/patch-ruRU-[.mpq"))
                        {
                            File.Delete(Properties.Settings.Default.PathWow + "/Data/ruRU/patch-ruRU-[.mpq");
                            MessageBox.Show("Патч удален.");
                        }
                        else
                        {
                            MessageBox.Show("Патч не найден.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка. Убедитесь, что :\n 1. Игра не запущена. \n 2. patch-ruRU-[.mpq не открыт в другой программе.");
                    }

                }
                else
                {
                    MessageBox.Show("Не найдет путь к игре.");
                }
            }
        }

        private SpellMap[] GetSpell(string url)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    using (Stream stream = webClient.OpenRead(url))
                    {
                        using (StreamReader streamReader = new StreamReader(stream))
                        {
                            string result = streamReader.ReadToEnd().Replace("\n", "").Trim();
                            SpellMap[] spells = JsonConvert.DeserializeObject<SpellMap[]>(result);
                            return spells;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        /////////////////////////////////////////////////////////////////
        public static string pathToWow = "D:\\games\\sirus\\World of Warcraft Sirus";

        static HttpClient httpClient = new HttpClient();

        #region Check Patch whit md5
        [DllImport("PatchChecker.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern bool CheckPatch(string pathToFile, string md5);
        #endregion

        #region get md5 from file
        public delegate void ResponseDelegate(string s);
        [DllImport("PatchChecker.dll", EntryPoint = "GetMD5", CallingConvention = CallingConvention.StdCall)]
        /*
         *  GetMD5(pathToWow, pathToFileFromWowDir, s =>
            {
                Console.WriteLine(s);
            });
         */
        public static extern void GetMD5(string pathToFile, ResponseDelegate response);
        #endregion

        public static async Task CheckPatchAsync(Newtonsoft.Json.Linq.JToken info,ProgressBar bar)
        {
            //Console.WriteLine(info);
            //var time = DateTime.Parse((string)info?["updated_at"], DateTimeFormatInfo.InvariantInfo);
            //var timeNow = DateTime.Now;
            var pathToFile = pathToWow + (string)info?["path"] + (string)info?["filename"];
            var urlForDownload = (string)info?["host"] + (string)info?["storage_path"];

            var isUpdated = CheckPatch(pathToFile, (string)info?["md5"]);
            if (!isUpdated)
            {
                using (HttpClient client = new System.Net.Http.HttpClient())
                {
                    if (File.Exists(pathToFile))
                    {
                        // If file found, delete it    
                        File.Delete(pathToFile);
                        //Console.WriteLine(pathToFile);
                    }
                    var uri = new Uri(urlForDownload);
                    await httpClient.DownloadFileTaskAsync(uri, pathToFile);

                }
            }
            bar.Invoke((MethodInvoker)delegate
            {
                bar.Value++;
            });
        }

        static async Task MainFunction(ProgressBar bar)
        {
            List<Task> tasks = new List<Task>();
            // запросики
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "http://51.15.228.31:8080/api/client/patches");
                var response = await client.SendAsync(request);
                string content = await response.Content.ReadAsStringAsync();

                Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(content);
                // проверка патчей
                bar.Invoke((MethodInvoker)delegate
                {
                    bar.Maximum = (int)obj?["patches"]?.Count();
                    bar.Visible = true;
                    bar.Value = 0;
                });
                for (int i = 1; i < obj?["patches"]?.Count(); i++)
                {
                    var info = obj?["patches"]?[i];
                    tasks.Add(Task.Run(() => CheckPatchAsync(info,bar)));

                }
                await Task.WhenAll(tasks);
                bar.Invoke((MethodInvoker)delegate
                {
                    bar.Visible = false;
                    bar.Value = 0;
                });
                MessageBox.Show("Клиент проверен успешно");
            }

        }

        /////////////////////////////////////////////////////////////////
        private void CheckPatch_Click(object sender, EventArgs e)
        {
            Task.Run(() => MainFunction(CheckPatchProgressBar));
        }
    }

    public static class HttpClientUtils
    {
        public static async Task DownloadFileTaskAsync(this HttpClient client, Uri uri, string FileName)
        {
            using (var s = await client.GetStreamAsync(uri))
            {
                using (var fs = new FileStream(FileName, FileMode.CreateNew))
                {
                    await s.CopyToAsync(fs);
                }
            }
        }
    }

}
