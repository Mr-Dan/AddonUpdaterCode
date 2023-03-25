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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AddonUpdater.FormMainMenu;

namespace AddonUpdater.Controls
{
    public partial class ModificationsControl : UserControl
    {
        private FormMainMenu formMainMenu;
        public ModificationsControl(FormMainMenu owner)
        {
            formMainMenu = owner;
            InitializeComponent();
        }

        [DllImport("PatchCreator.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool PatchCreate(Spell[] m, string v);

        private Task<bool> PatchLoad(Spell[] json, string path)
        {
            var test = Task.Run(() =>
            {
                try
                {
                    return PatchCreate(json, Properties.Settings.Default.PathWow);
                }
                catch (Exception ex)
                {
                    return false;
                }
            });

            return test;
        }

        private async void buttonPatchLoad_Click(object sender, EventArgs e)
        {

            ActiveControl = null;
            formMainMenu.ButtonOff();
            buttonPatchLoad.Enabled = false;
            progressBar1.Maximum = 2;
            progressBar1.Visible = true;
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    using (Stream stream = webClient.OpenRead(DownloadAddonGitHub.AddonUpdaterSettings.ListSpells))
                    {
                        using (StreamReader streamReader = new StreamReader(stream))
                        {
                            string result = streamReader.ReadToEnd().Replace("\n", "").Trim();
                            Spell[] json = JsonConvert.DeserializeObject<Spell[]>(result);
                            json[0].Count = json.Count();
                            progressBar1.Value++;
                            bool isCreate = await PatchLoad(json, Properties.Settings.Default.PathWow);
                            progressBar1.Value++;
                            if (isCreate)
                            {
                                MessageBox.Show("Патч создан");
                            }
                            else
                            {
                                MessageBox.Show("Ошибка. Убедитесь, что игра не запущена и/или patch-ruRU-x.mpq не открыт в другой программе.");
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            formMainMenu.ButtonOn();
            buttonPatchLoad.Enabled = true;


        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Spell
        {
            public int Key { get; set; }
            public int Value { get; set; }
           public  int Count { get; set; }
        }
    }
}
