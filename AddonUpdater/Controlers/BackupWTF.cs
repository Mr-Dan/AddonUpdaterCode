using AddonUpdater.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddonUpdater.Controlers
{
    class BackupWTF
    {

        public static Task CreateFileBackupTask()
        {
            return Task.Run(() => CreateFileBackup());
        }

        public static Task DeleteFileBackupTask(DateTime max)
        {
            return Task.Run(() => DeleteFileBackup(max));
        }

        public static Task DeleteFileBackupTask(int n)
        {
            return Task.Run(() => DeleteFileBackup(n));
        }

        public static Task BackupWtfTask()
        {
            return Task.Run(() => BackupWtf());
        }

        private static void CreateFileBackup()
        {

            string pathWTF = AddonUpdaterSettingApp.SettingsApp.PathWow + "\\WTF";
            string pathBackupWTF = "BackupWTF\\WTF " + DateTime.Now.ToString("dd MM yyyy HH mm ss") + ".zip";

            if (Directory.Exists("BackupWTF"))
            {
                ZipFile.CreateFromDirectory(pathWTF, pathBackupWTF);
            }
            else
            {
                Directory.CreateDirectory("BackupWTF");
                ZipFile.CreateFromDirectory(pathWTF, pathBackupWTF);

            }
        }

        private static void DeleteFileBackup(DateTime max)
        {

            if (Directory.Exists("BackupWTF"))
            {
                try
                {
                    List<string> files = Directory.GetFiles("BackupWTF").ToList();

                    foreach (string file in files)
                    {
                        DateTime dateTime = File.GetCreationTime(file);
                        if (dateTime < max)
                        {
                            File.Delete(file);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private static void DeleteFileBackup(int n)
        {

            if (Directory.Exists("BackupWTF"))
            {
                try
                {
                    List<string> files = Directory.GetFiles("BackupWTF").ToList();

                    List<FileCustom> filesCustom = new();
                    foreach (string file in files)
                    {
                        DateTime dateTime = File.GetCreationTime(file);
                        filesCustom.Add(new FileCustom() { Path = file, DateTimeCreate = dateTime });
                    }

                    filesCustom.Sort((left, right) => left.DateTimeCreate.CompareTo(right.DateTimeCreate));

                    for (int i = 0; i < filesCustom.Count - n; i++)
                    {
                        File.Delete(filesCustom[i].Path);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private static void BackupWtf()
        {

            if (Directory.Exists("BackupWTF"))
            {
                try
                {
                    List<string> files = Directory.GetFiles("BackupWTF").ToList();

                    DateTime max = DateTime.MinValue;
                    string path = "";
                    foreach (string file in files)
                    {
                        DateTime dateTime = File.GetCreationTime(file);
                        if (dateTime > max)
                        {
                            max = dateTime;
                            path = file;

                        }
                    }
                    if (path != "")
                    {
                        string pathToWtf = AddonUpdaterSettingApp.SettingsApp.PathWow + "\\WTF";

                        if (Directory.Exists(pathToWtf))
                        {
                            Directory.Delete(pathToWtf, true);
                        }
                        ZipFile.ExtractToDirectory(path, pathToWtf);
                        MessageBox.Show(path + " восстановлен");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public static DateTime GetLastBackupWtf()
        {

            DateTime dateTime = new();
            if (Directory.Exists("BackupWTF"))
            {
                List<string> files = Directory.GetFiles("BackupWTF").ToList();

                DateTime max = DateTime.MinValue;
                foreach (string file in files)
                {
                    dateTime = File.GetCreationTime(file);
                    if (dateTime > max)
                    {
                        max = dateTime;
                    }
                }
            }

            return dateTime;
        }

    }
}
