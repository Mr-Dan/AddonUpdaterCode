using AddonUpdater.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace AddonUpdater
{
    class DownloadAddonGitHub
    {
        public static List<GitHub> GitHubs = new List<GitHub>();
        public static List<GitHub> NeedUpdate = new List<GitHub>();
        public static bool UpdateInfo = true;

        public static List<WTF> WTF = new List<WTF>();
        public static List<LastUpdateAddon> lastUpdateAddon = new List<LastUpdateAddon>();
        public static AddonUpdaterSetting AddonUpdaterSettings = new AddonUpdaterSetting();

        public Task Aupdatecheck()
        {
            var getVersion = Task.Factory.StartNew(() =>
            {
                GetSettings();
                List<GitHub> GitHubsNew = new List<GitHub>();
                if(AddonUpdaterSettings!= null)
                foreach (Toc toc in AddonUpdaterSettings.Tocs)
                {
                    GitHubsNew.AddRange(AupdatecheckToc(toc.Link, toc.Regex));

                }
                GitHubsNew.Sort((left, right) => left.Name.CompareTo(right.Name));
                if (GitHubs.Count < 1)
                {
                    GitHubs = new List<GitHub>(GitHubsNew);
                }
                else if (GitHubsNew.Count > 0)
                {
                    if (ListCheck(GitHubs, GitHubsNew) == false)
                    {
                        UpdateGitHub(GitHubsNew);
                        UpdateInfo = true;
                    }

                }

                GetWTF();

                if (lastUpdateAddon.Count == 0)
                {
                    for (int i = 0; i < GitHubs.Count; i++)
                    {
                        if (GitHubs[i].MyVersion != null)
                        {
                            lastUpdateAddon.Add(new LastUpdateAddon { AddonName = GitHubs[i].Name, LastUpdate = GetValues(Properties.Settings.Default.LastUpdate, GitHubs[i].Name) });
                        }
                    }
                }

            });
            return getVersion;
        }

        public Task AupdatecheckLocal()
        {
            var getVersion = Task.Factory.StartNew(() =>
            {

                for (int i = 0; i < GitHubs.Count; i++)
                {
                    string myVersion = GetMyVersion(GitHubs[i].Directory, GitHubs[i].Regex);
                    if (GitHubs[i].MyVersion != myVersion)
                    {
                        GitHubs[i].MyVersion = myVersion;
                        GitHubs[i].NeedUpdate = GetNeedUpdate(GitHubs[i].Version, GitHubs[i].MyVersion, GetAddonUpdate(GitHubs[i].Name));
                        UpdateInfo = true;
                    }
                }

                GetWTF();

                if (lastUpdateAddon.Count == 0)
                {
                    for (int i = 0; i < GitHubs.Count; i++)
                    {
                        if (GitHubs[i].MyVersion != null)
                        {
                            lastUpdateAddon.Add(new LastUpdateAddon { AddonName = GitHubs[i].Name, LastUpdate = GetValues(Properties.Settings.Default.LastUpdate, GitHubs[i].Name) });
                        }
                    }
                }

            });
            return getVersion;
        }

        public List<GitHub> AupdatecheckToc(string link, string regex)
        {
            List<GitHub> GitHubsNew = new List<GitHub>();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            string getUrlGithub = GetContent(link);
            string[] url_addons = getUrlGithub.Split('\n');

            for (int i = 0; i < url_addons.Length - 1; i++)
            {
                string name = GetValues(url_addons[i], "NameAddon");
                string linkVersion = GetValues(url_addons[i], "Version");
                string branches = GetValues(url_addons[i], "Branches");
                string directory = Regex.Match(linkVersion.Replace($"{branches}/", ""), @"\/[a-zA-Z-_\d]*(\/[a-zA-Z-_\d]*.toc)").Value;
                string description = GetValues(url_addons[i], "Description");
                string version = GetVersion(linkVersion, regex);
                string myVersion = GetMyVersion(directory, regex);
                bool addonUpdate = GetAddonUpdate(name);
                bool needUpdate = GetNeedUpdate(version, myVersion, addonUpdate);
                GitHubsNew.Add(new GitHub()
                {
                    Name = name,
                    Link = linkVersion,
                    Branches = branches,
                    Files = GetValues(url_addons[i], "Files").Split(',').ToList(),
                    Version = version,
                    Directory = directory,
                    MyVersion = myVersion,
                    Description = GetDescription(description, linkVersion, directory),
                    NeedUpdate = needUpdate,
                    GithubLink = GetValues(url_addons[i], "GitHub"),
                    Forum = GetValues(url_addons[i], "Forum"),
                    BugReport = GetValues(url_addons[i], "BugReport"),
                    Author = GetValues(url_addons[i], "Author"),
                    Regex = regex,
                    SavedVariables = GetSavedVariables(directory),
                    SavedVariablesPerCharacter = GetSavedVariablesPerCharacter(directory),
                    Category = GetValues(url_addons[i], "Category")
                });

            }
            return GitHubsNew;
        }

        #region Delete

        private void AddonUpdaterDeleteDirectory(string path)
        {
            foreach (string directory in AddonUpdaterSettings.DeleteDirectory)
            {
                if (path != null)
                    if (Directory.Exists(path + $@"\{directory}"))
                    {
                        DirectoryDelete(path + $@"\{directory}");
                        Thread.Sleep(100);
                    }
                if (Directory.Exists(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\{directory}"))
                {
                    DirectoryDelete(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\{directory}");
                    Thread.Sleep(100);
                }
            }
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
                // if (Directory.Exists(path))
                //  DirectoryDelete(path);
                //MessageBox.Show(ex.ToString(), "Предупреждение");
            }
        }

        public void DeleteAddon(GitHub gitHub)
        {

            string directoryDelete = Properties.Settings.Default.PathWow + $@"\Interface\AddOns\AddonsOld{gitHub.Name}\";

            if (Directory.Exists(directoryDelete)) DirectoryDelete(directoryDelete);
            Directory.CreateDirectory(directoryDelete);

            for (int j = 0; j < gitHub.Files.Count; j++)
            {
                string sourceDirectory = Properties.Settings.Default.PathWow + @"\Interface\AddOns\" + gitHub.Files[j];
                string destinationDirectory = directoryDelete + gitHub.Files[j];
                try
                {
                    if (Directory.Exists(directoryDelete))
                        if (Directory.Exists(sourceDirectory))
                            Directory.Move(sourceDirectory, destinationDirectory);
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.ToString(), "Предупреждение");
                }
            }

            AddonUpdaterDeleteDirectory(null);


            DirectoryDelete(directoryDelete);

        }

        #endregion

        public Task DownloadAddonGitHubTask(string name, string githublink, string branches)
        {

            string githubDirectory = githublink.Replace("https://github.com/", "");
            using (WebClient client2 = new WebClient())
            {
                var task = client2.DownloadFileTaskAsync(new Uri($"https://github.com/{githubDirectory}/archive/refs/heads/{branches}.zip"), $"{name}.zip");
                return task;
            }
        }

        #region Get

        private void GetSettings()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            string getUrlGithub = GetContent("https://raw.githubusercontent.com/Mr-Dan/AddonUpdaterSettings/main/MainSettings");
            AddonUpdaterSettings = JsonConvert.DeserializeObject<AddonUpdaterSetting>(getUrlGithub);
        }

        private string GetVersion(string link, string regex)
        {
            string get_version = GetContent(link);
            Match reg = Regex.Match(get_version, regex);
            if (reg.Success) return reg.Groups[1].Value.Trim('\r');
            else return "0";
        }

        public string GetMyVersion(string directory, string regex)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(Properties.Settings.Default.PathWow + @"\Interface\AddOns" + directory);
                if (fileInfo.Exists)
                {
                    using (StreamReader reader = new StreamReader(fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Match reg = Regex.Match(line, regex);
                            if (reg.Success)
                            {

                                return reg.Groups[1].Value.Trim().Length == 0 ? "0" : reg.Groups[1].Value.Trim();
                            }
                        }
                        return "0";
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return null;
        }

        private string GetDescription(string text, string link, string directory)
        {
            string description = null;
            if (text == "null")
            {
                string[] Readme = GetContent(link.Replace(directory, "/README.md")).Split('\n');
                for (int j = 0; j < Readme.Length; j++)
                {
                    Match match = Regex.Match(Readme[j], @"(https:)\/\/([A-z0-9.\/-])*");
                    if (match.Success) Readme[j] = "";
                    description = (description + " " + Readme[j].Trim('#').Replace("**", "").Replace("Тема на форуме:", "").Replace("Поддержать автора аддона", "")).Trim();
                }
                return description;
            }
            else
            {
                return text;
            }

        }

        public bool GetAddonUpdate(string name)
        {
            if (Properties.Settings.Default.UpdateAddon.Contains(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string ConvertStringFromDouble(string version)
        {
            int count = 0;
            int first = version.IndexOf(".");
            if (first != -1)
            {
                for (int i = 0; i < version.Length; i++)
                {
                    if (version[i] == '.')
                        count++;
                }

                for (int i = 0; i < count - 1; i++)
                {
                    int Myindex = version.LastIndexOf(".");
                    version = version.Remove(Myindex, 1);
                }
            }
            return version;
        }

        public bool GetNeedUpdate(string version, string MyVersion, bool addonUpdate)
        {
            if (MyVersion == null) return false;

            double.TryParse(ConvertStringFromDouble(MyVersion).Replace(".", ","), out double MyVersionInt);
            double.TryParse(ConvertStringFromDouble(version).Replace(".", ","), out double versionInt);
            if (addonUpdate)
            {
                if (versionInt > MyVersionInt)
                {
                    return true;
                }
                return false;
            }
            else return false;
        }

        public string GetValues(string text, string type)
        {
            int start = text.IndexOf($"{type}[");
            int end = text.IndexOf($"]", start + 1);
            if (start == -1) return null;
            return text.Substring(start + type.Length + 1, end - start - type.Length - 1);
        }

        public bool GetSavedVariables(string directory)
        {
            string regex = "## SavedVariables:";
            try
            {
                FileInfo fileInfo = new FileInfo(Properties.Settings.Default.PathWow + @"\Interface\AddOns" + directory);
                if (fileInfo.Exists)
                {
                    using (StreamReader reader = new StreamReader(fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Match reg = Regex.Match(line, regex);
                            if (reg.Success)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return false;
        }

        public bool GetSavedVariablesPerCharacter(string directory)
        {
            string regex = "## SavedVariablesPerCharacter:";
            try
            {
                FileInfo fileInfo = new FileInfo(Properties.Settings.Default.PathWow + @"\Interface\AddOns" + directory);
                if (fileInfo.Exists)
                {
                    using (StreamReader reader = new StreamReader(fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Match reg = Regex.Match(line, regex);
                            if (reg.Success)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return false;
        }

        public string GetContent(string url)
        {
            string result = String.Empty;
            WebClient client = new WebClient();
            try
            {
                Stream stream = client.OpenRead(url);
                StreamReader reader = new StreamReader(stream);
                result = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ошибка подключения, повторите попытку позже", "Ошибка");
                // Application.Exit();
                //MessageBox.Show(ex.ToString(), "Предупреждение");
            }
            return result;
        }

        private void GetWTF()
        {
            WTF = new List<WTF>();
            string pathWTF = Properties.Settings.Default.PathWow + "\\WTF\\Account";
            if (Directory.Exists(pathWTF))
            {
                string[] accounts = Directory.GetDirectories(pathWTF);
                foreach (string account in accounts)
                {

                    WTF.Add(new WTF { Account = account, Realms = GetRealm(account), });
                }
            }
        }

        List<Realms> GetRealm(string path)
        {
            List<Realms> Realms = new List<Realms>();
            string[] realms = Directory.GetDirectories(path);
            foreach (string realm in realms)
            {
                if (realm.IndexOf("SavedVariables") == -1)
                    Realms.Add(new Realms { Name = realm, Persons = Directory.GetDirectories(realm).ToList() });
            }
            return Realms;
        }

        #endregion

        #region GetAddon

        public Task GetAddon()
        {
            var getaddon = Task.Factory.StartNew(() =>
            {
                try
                {

                    if (Directory.Exists(Properties.Settings.Default.PathWow + @"\Interface\AddOns\old"))
                    {
                        DirectoryDelete(Properties.Settings.Default.PathWow + @"\Interface\AddOns\old");
                        Thread.Sleep(100);
                    }
                    Directory.CreateDirectory(Properties.Settings.Default.PathWow + @"\Interface\AddOns\old");

                    for (int i = 0; i < NeedUpdate.Count; i++)
                    {
                        if (Directory.Exists(NeedUpdate[i].Name))
                        {
                            DirectoryDelete(NeedUpdate[i].Name);
                            Thread.Sleep(100);
                        }
                        Directory.CreateDirectory(NeedUpdate[i].Name);

                        ZipFile.ExtractToDirectory($"{NeedUpdate[i].Name}.zip", NeedUpdate[i].Name);

                        string[] allfiles = Directory.GetDirectories(NeedUpdate[i].Name);
                        if (allfiles[0].IndexOf($"-{NeedUpdate[i].Branches}") > -1)
                        {
                            Directory.Move(allfiles[0], NeedUpdate[i].Name + "\\" + NeedUpdate[i].Name);
                        }
                        allfiles = Directory.GetDirectories(NeedUpdate[i].Name);
                        string[] allfiles2 = Directory.GetDirectories(allfiles[0]);
                        string[] allfiles3 = Directory.GetFiles(allfiles[0]);

                        AddonUpdaterDeleteDirectory(allfiles[0]);

                        allfiles2 = Directory.GetDirectories(allfiles[0]);


                        if (File.Exists(NeedUpdate[i].Name + "\\" + NeedUpdate[i].Directory) == false)
                            foreach (string file in allfiles3)
                            {
                                File.Delete(file);
                            }

                        if (File.Exists(NeedUpdate[i].Name + "\\" + NeedUpdate[i].Directory))
                        {
                            File.Delete($"{NeedUpdate[i].Name}.zip");
                            ZipFile.CreateFromDirectory(NeedUpdate[i].Name, $"{NeedUpdate[i].Name}.zip");
                            File.Move($"{NeedUpdate[i].Name}.zip", $"{NeedUpdate[i].Name}\\{NeedUpdate[i].Name}.zip");
                        }
                        else
                            ZipFile.CreateFromDirectory(allfiles[0], $"{NeedUpdate[i].Name}\\{NeedUpdate[i].Name}.zip");

                        foreach (string dir in NeedUpdate[i].Files)
                        {
                            string sourceDirectory = Properties.Settings.Default.PathWow + @"\Interface\AddOns\" + dir;
                            string destinationDirectory = Properties.Settings.Default.PathWow + $@"\Interface\AddOns\old\" + dir;

                            if (Directory.Exists(sourceDirectory))
                                Directory.Move(sourceDirectory, destinationDirectory);
                        }
                        if (Directory.Exists(Properties.Settings.Default.PathWow + @"\Interface\AddOns"))
                            ZipFile.ExtractToDirectory($"{NeedUpdate[i].Name}\\{NeedUpdate[i].Name}.zip", Properties.Settings.Default.PathWow + @"\Interface\AddOns");
                        DirectoryDelete(NeedUpdate[i].Name);
                        File.Delete($"{NeedUpdate[i].Name}.zip");

                        if (lastUpdateAddon.FindIndex(f => f.AddonName == NeedUpdate[i].Name) > -1)
                        {
                            lastUpdateAddon[lastUpdateAddon.FindIndex(f => f.AddonName == NeedUpdate[i].Name)].LastUpdate = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
                        }
                        else
                        {
                            lastUpdateAddon.Add(new LastUpdateAddon { AddonName = NeedUpdate[i].Name, LastUpdate = DateTime.Now.ToString("dd-MM-yyyy HH:mm") });
                        }
                        SaveLastUpdate();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), ex.Message);
                }
                DirectoryDelete(Properties.Settings.Default.PathWow + @"\Interface\AddOns\old");
                //Aupdatecheck();
            });
            return getaddon;
        }

        public Task GetAddon(GitHub gitHub)
        {
            var getaddon = Task.Factory.StartNew(() =>
            {
                try
                {
                    if (Directory.Exists(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\old{gitHub.Name}"))
                    {
                        DirectoryDelete(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\old{gitHub.Name}");
                        Thread.Sleep(100);
                    }


                    if (Directory.Exists(gitHub.Name))
                    {
                        DirectoryDelete(gitHub.Name);
                        Thread.Sleep(100);
                    }
                    Directory.CreateDirectory(gitHub.Name);

                    ZipFile.ExtractToDirectory($"{gitHub.Name}.zip", gitHub.Name);

                    string[] allfiles = Directory.GetDirectories(gitHub.Name);
                    if (allfiles[0].IndexOf($"-{gitHub.Branches}") > -1)
                    {
                        Directory.Move(allfiles[0], gitHub.Name + "\\" + gitHub.Name);
                    }
                    allfiles = Directory.GetDirectories(gitHub.Name);
                    string[] allfiles2 = Directory.GetDirectories(allfiles[0]);
                    string[] allfiles3 = Directory.GetFiles(allfiles[0]);

                    AddonUpdaterDeleteDirectory(allfiles[0]);

                    allfiles2 = Directory.GetDirectories(allfiles[0]);

                    if (File.Exists(gitHub.Name + "\\" + gitHub.Directory) == false)
                        foreach (string file in allfiles3)
                        {
                            File.Delete(file);
                        }

                    if (File.Exists(gitHub.Name + "\\" + gitHub.Directory))
                    {
                        File.Delete($"{gitHub.Name}.zip");
                        ZipFile.CreateFromDirectory(gitHub.Name, $"{gitHub.Name}.zip");
                        File.Move($"{gitHub.Name}.zip", $"{gitHub.Name}\\{gitHub.Name}.zip");
                    }
                    else
                        ZipFile.CreateFromDirectory(allfiles[0], $"{gitHub.Name}\\{gitHub.Name}.zip");

                    Directory.CreateDirectory(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\old{gitHub.Name}");

                    foreach (string dir in gitHub.Files)
                    {
                        string sourceDirectory = Properties.Settings.Default.PathWow + @"\Interface\AddOns\" + dir;
                        string destinationDirectory = Properties.Settings.Default.PathWow + $@"\Interface\AddOns\old{gitHub.Name}\" + dir;

                        if (Directory.Exists(sourceDirectory))
                            Directory.Move(sourceDirectory, destinationDirectory);
                    }

                    if (Directory.Exists(Properties.Settings.Default.PathWow + @"\Interface\AddOns"))
                        ZipFile.ExtractToDirectory($"{gitHub.Name}\\{gitHub.Name}.zip", Properties.Settings.Default.PathWow + @"\Interface\AddOns");
                    DirectoryDelete(gitHub.Name);
                    File.Delete($"{gitHub.Name}.zip");

                    if (lastUpdateAddon.FindIndex(f => f.AddonName == gitHub.Name) > -1)
                    {
                        lastUpdateAddon[lastUpdateAddon.FindIndex(f => f.AddonName == gitHub.Name)].LastUpdate = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
                    }
                    else
                    {
                        lastUpdateAddon.Add(new LastUpdateAddon { AddonName = gitHub.Name, LastUpdate = DateTime.Now.ToString("dd-MM-yyyy HH:mm") });
                    }
                    SaveLastUpdate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), ex.Message);
                }
                DirectoryDelete(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\old{gitHub.Name}");
            });
            return getaddon;
        }

        #endregion

        public bool ListCheck(List<GitHub> G1, List<GitHub> G2)
        {
            if (G1.Count != G2.Count)
            {
                return false;
            }

            for (int i = 0; i < G1.Count; i++)
            {
                if (G1[i] != G2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public void SaveLastUpdate()
        {
            string lastUpdate = null;

            for (int i = 0; i < lastUpdateAddon.Count; i++)
            {
                lastUpdate += $"{lastUpdateAddon[i].AddonName}[{lastUpdateAddon[i].LastUpdate}]";
            }

            Properties.Settings.Default.LastUpdate = lastUpdate;
            Properties.Settings.Default.Save();

        }

        private void UpdateGitHub(List<GitHub> gitHub)
        {
            for (int i = 0; i < gitHub.Count; i++)
            {
                int index = GitHubs.FindIndex(addon => addon.Name == gitHub[i].Name);
                if (index > -1)
                {
                    GitHubs[i].Name = gitHub[i].Name;
                    GitHubs[i].Link = gitHub[i].Link;
                    GitHubs[i].Directory = gitHub[i].Directory;
                    GitHubs[i].Version = gitHub[i].Version;
                    GitHubs[i].MyVersion = gitHub[i].MyVersion;
                    GitHubs[i].Branches = gitHub[i].Branches;
                    GitHubs[i].Description = gitHub[i].Description;
                    GitHubs[i].Author = gitHub[i].Author;
                    GitHubs[i].GithubLink = gitHub[i].GithubLink;
                    GitHubs[i].Forum = gitHub[i].Forum;
                    GitHubs[i].BugReport = gitHub[i].BugReport;
                    GitHubs[i].Regex = gitHub[i].Regex;
                    GitHubs[i].Category = gitHub[i].Category;
                    GitHubs[i].NeedUpdate = gitHub[i].NeedUpdate;
                    GitHubs[i].SavedVariables = gitHub[i].SavedVariables;
                    GitHubs[i].SavedVariablesPerCharacter = gitHub[i].SavedVariablesPerCharacter;
                    GitHubs[i].Files = new List<string>(gitHub[i].Files);

                }
            }
        }
    }
}
