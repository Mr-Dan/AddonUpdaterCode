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
        public static extern bool PatchCreate(Spell[] spells, int count, string path);

        private Task<bool> PatchLoad(Spell[] spells, int count, string path)
        {
            var test = Task.Run(() =>
            {
                try
                {
                     return PatchCreate(spells, count, path);                 
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
                    formMainMenu.ButtonOff();
                    buttonPatchLoad.Enabled = false;
                    buttonDeletePath.Enabled = false;
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
                                    Spell[] spells = JsonConvert.DeserializeObject<Spell[]>(result);
                                    progressBar1.Value++;
                                    bool isCreate = await PatchLoad(spells, spells.Length, Properties.Settings.Default.PathWow);
                                    progressBar1.Value++;
                                    if (isCreate)
                                    {
                                        MessageBox.Show("Патч создан");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ошибка. Убедитесь, что :\n 1. Игра не запущена. \n 2. patch-ruRU-x.mpq не открыт в другой программе. \n 3. Присутствует данный файл /Data/ruRU/patch-ruRU-4.mpq.");
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
                    buttonDeletePath.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Не найдет путь к игре.");
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Spell
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
                        if (File.Exists(Properties.Settings.Default.PathWow + "/Data/ruRU/patch-ruRU-x.mpq"))
                        {
                            File.Delete(Properties.Settings.Default.PathWow + "/Data/ruRU/patch-ruRU-x.mpq");
                            MessageBox.Show("Патч удален.");
                        }
                        else
                        {
                            MessageBox.Show("Патч не найден.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка. Убедитесь, что :\n 1. Игра не запущена. \n 2. patch-ruRU-x.mpq не открыт в другой программе.");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Не найдет путь к игре.");
                }
            }
        }
    }
}
