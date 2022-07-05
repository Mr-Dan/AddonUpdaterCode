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
using System.Windows.Forms;

namespace AddonUpdater
{
    class DownloadAddonGitHub
    {
        public static List<GitHub> GitHubs = new List<GitHub>();
        public static List<GitHub> NeedUpdate = new List<GitHub>();
        public static bool UpdateInfo = false;
        public static bool Update = false;
        public static List<WTF> WTF = new List<WTF>();
        public static List<LastUpdateAddon> lastUpdateAddon = new List<LastUpdateAddon>();
        public Task Aupdatecheck()
        {
            var getVersion = Task.Factory.StartNew(() =>
            {              
                List<GitHub> GitHubsNew = new List<GitHub>();
                List<GitHub> GitHubsToc = AupdatecheckToc2("https://raw.githubusercontent.com/Mr-Dan/AddonUpdaterSettings/main/AddonUpdaterLinks", @"(## Version):\s*(.*\d)*", "## Version:");
                List<GitHub> GitHubsSirus = AupdatecheckToc2("https://raw.githubusercontent.com/Mr-Dan/AddonUpdaterSettings/main/AddonUpdaterSirusLinks", @"(@Version):\s*(\d)*", "@Version:");
                GitHubsNew.AddRange(GitHubsToc);
                GitHubsNew.AddRange(GitHubsSirus);
                if (GitHubsNew.Count > 0)
                    if (ListCheck(GitHubs, GitHubsNew) == false)
                    {
                        GitHubsNew.Sort((left, right) => left.Name.CompareTo(right.Name));
                        GitHubs = new List<GitHub>(GitHubsNew);
                        UpdateInfo = true;

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
        public List<GitHub> AupdatecheckToc2(string link, string regex, string replace)
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
                string directory = Regex.Match(linkVersion.Replace($"{branches}/", ""), @"(\/)\w*(-)*\w*.(\/)\w*(-)*\w*.(toc)").Value;
                string description = GetValues(url_addons[i], "Description");
                string version = GetVersion(linkVersion, regex, replace);
                string myVersion = GetMyVersion(directory, regex, replace);
                bool blackList = GetBlacklist(name);
                bool addonUpdate = GetAddonUpdate(name);
                bool needUpdate = GetNeedUpdate(version, myVersion, blackList, addonUpdate);
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
                    Blacklist = blackList,
                    NeedUpdate = needUpdate,
                    DownloadMyAddon = needUpdate,
                    GithubLink = GetValues(url_addons[i], "GitHub"),
                    Forum = GetValues(url_addons[i], "Forum"),
                    BugReport = GetValues(url_addons[i], "BugReport"),
                    Author = GetValues(url_addons[i], "Author"),
                    Regex = regex,
                    Replace = replace,
                    SavedVariables = GetSavedVariables(directory),
                    SavedVariablesPerCharacter = GetSavedVariablesPerCharacter(directory),
                    Category = GetValues(url_addons[i], "Category")
                });

            }
            return GitHubsNew;
        }
        private string GetVersion(string link, string regex, string replace)
        {
            string get_version = GetContent(link);
            Match reg = Regex.Match(get_version, regex);
            if (reg.Success) return Regex.Replace(reg.Value.Trim('\r').Replace(replace, ""), "[A-Za-z]", "").Trim();
            else return "0";
        }
        public string GetMyVersion(string directory, string regex, string replace)
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

                                return reg.Value.Replace(replace, "").Trim().Length == 0 ? "0" : Regex.Replace(reg.Value.Replace(replace, ""), "[A-Za-z]", "").Trim();
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
        private bool GetBlacklist(string name)
        {
            if (Properties.Settings.Default.AddonBlacklist.Contains(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GetAddonUpdate(string name)
        {
            if (Properties.Settings.Default.AddonUpdate.Contains(name))
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

                for (int i = 0; i < count-1; i++)
                {
                    int Myindex = version.LastIndexOf(".");
                    version = version.Remove(Myindex, 1);
                }
            }
            return version;
        }

        public bool GetNeedUpdate(string version, string MyVersion, bool blacklist, bool addonUpdate)
        {
            if (MyVersion == null) return false;

            double.TryParse(ConvertStringFromDouble(MyVersion).Replace(".",","), out double MyVersionInt);
            double.TryParse(ConvertStringFromDouble(version).Replace(".", ","), out double versionInt);
            if (blacklist == false && addonUpdate == true)
            {
                if (versionInt > MyVersionInt)
                {
                    if (Update == false) Update = true;
                    return true;
                }
                return false;
            }
            else return false;
        }
        public bool GetVersion(string version, string MyVersion)
        {
            if (MyVersion == null) return false;
            if (version == null) return false;

            double.TryParse(ConvertStringFromDouble(MyVersion).Replace(".", ","), out double MyVersionInt);
            double.TryParse(ConvertStringFromDouble(version).Replace(".", ","), out double versionInt);

            if (versionInt > MyVersionInt)
            {
                return true;
            }
            return false;

        }
        public string GetValues(string text, string type)
        {
            int start = text.IndexOf($"{type}[");
            int end = text.IndexOf($"]", start + 1);
            if (start == -1) return null;
            return text.Substring(start + type.Length + 1, end - start - type.Length - 1);
        }

        public bool ListCheck(List<GitHub> G1, List<GitHub> G2)
        {
            if (G1.Count != G2.Count)
            {
                return false;
            }

            for (int i = 0; i < G1.Count; i++)
            {
                int index = G2.FindIndex(indx => indx.Name == G1[i].Name);
                if (index > -1)
                {                  
                    if (GetVersion(G2[i].Version, G1[index].Version) ||
                        GetVersion(G1[i].MyVersion, G2[index].MyVersion) ||
                        G1[i].Description != G2[index].Description ||
                        G1[i].GithubLink != G2[index].GithubLink ||
                        G1[i].Forum != G2[index].Forum ||
                        !G1[i].Files.SequenceEqual(G2[index].Files) ||
                        G1[i].Author != G2[index].Author ||
                        G1[i].Category != G2[index].Category ||
                        G1[i].BugReport != G2[index].BugReport ||
                        G1[i].Forum != G2[index].Forum ||
                        G1[i].Link != G2[index].Link ||
                        G1[i].Name != G2[index].Name
                        )
                        return false;
                }
                else
                {
                    return false;
                }
            }

            return true;
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
                    Realms.Add(new Realms { Realm = realm, Persons = Directory.GetDirectories(realm).ToList() });
            }
            return Realms;
        }
        public Task GetAddon()
        {
            var getaddon = Task.Factory.StartNew(() =>
            {
                try
                {

                    if (Directory.Exists(Properties.Settings.Default.PathWow + @"\Interface\AddOns\old"))
                    {
                        DirectoryDelete(Properties.Settings.Default.PathWow + @"\Interface\AddOns\old");
                    }
                    Directory.CreateDirectory(Properties.Settings.Default.PathWow + @"\Interface\AddOns\old");

                    for (int i = 0; i < NeedUpdate.Count; i++)
                    {
                        if (Directory.Exists(NeedUpdate[i].Name))
                        {
                            DirectoryDelete(NeedUpdate[i].Name);
                        }
                        Directory.CreateDirectory(NeedUpdate[i].Name);

                        ZipFile.ExtractToDirectory($"{ NeedUpdate[i].Name}.zip", NeedUpdate[i].Name);

                        string[] allfiles = Directory.GetDirectories(NeedUpdate[i].Name);
                        if (allfiles[0].IndexOf($"-{NeedUpdate[i].Branches}") > -1)
                        {
                            Directory.Move(allfiles[0], NeedUpdate[i].Name + "\\" + NeedUpdate[i].Name);
                        }
                        allfiles = Directory.GetDirectories(NeedUpdate[i].Name);
                        string[] allfiles2 = Directory.GetDirectories(allfiles[0]);
                        string[] allfiles3 = Directory.GetFiles(allfiles[0]);

                        if (Directory.Exists(allfiles[0] + @"\.github"))
                        {
                            DirectoryDelete(allfiles[0] + @"\.github");
                        }
                        if (Directory.Exists(allfiles[0] + @"\.vs"))
                        {
                            DirectoryDelete(allfiles[0] + @"\.vs");
                        }
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
                    //MessageBox.Show(ex.ToString(), ex.Message);
                }
                DirectoryDelete(Properties.Settings.Default.PathWow + @"\Interface\AddOns\old");
                Update = false;
                //Aupdatecheck();
            });
            return getaddon;
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
                if (Directory.Exists(path))
                    DirectoryDelete(path);
                //MessageBox.Show(ex.ToString(), "Предупреждение");
            }
        }

        public Task DownloadAddonGitHubTask(string name, string githublink, string branches)
        {

            string githubDirectory = githublink.Replace("https://github.com/", "");
            using (WebClient client2 = new WebClient())
            {
                var task = client2.DownloadFileTaskAsync(new Uri($"https://github.com/{githubDirectory}/archive/refs/heads/{branches}.zip"), $"{name}.zip");
                return task;
            }
        }

        #region deleteAsync
        /*
        public async Task DeleteAddonAsync()
        {
            await DeleteAddon();
        }
        public Task DeleteAddon()
        {
            var Del = Task.Factory.StartNew(() =>
            {
                List<GitHub> delete = GitHubs.FindAll(find => find.Delete == true);
                string directoryDelete = Properties.Settings.Default.link_wow + $@"\Interface\AddOns\AddonsOld\";

                if (Directory.Exists(directoryDelete)) DirectoryDelete(directoryDelete);
                Directory.CreateDirectory(directoryDelete);

                for (int i = 0; i < delete.Count; i++)
                {
                    for (int j = 0; j < delete[i].Files.Count; j++)
                    {
                        string sourceDirectory = Properties.Settings.Default.link_wow + @"\Interface\AddOns\" + delete[i].Files[j];
                        string destinationDirectory = directoryDelete + delete[i].Files[j];
                        try
                        {
                            if (Directory.Exists(sourceDirectory))
                                Directory.Move(sourceDirectory, destinationDirectory);
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show(ex.ToString(), "Предупреждение");
                        }
                    }
                }

                DirectoryDelete(directoryDelete);
            });
            return Del;
        }
        */
        #endregion


        public void DeleteOneAddon(GitHub gitHub)
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


            if (Directory.Exists(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\.github"))
                if (Directory.Exists(directoryDelete))
                    Directory.Move(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\.github", directoryDelete + @"\.github");

            if (Directory.Exists(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\.vs"))
                if (Directory.Exists(directoryDelete))
                    Directory.Move(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\.vs", directoryDelete + @"\.vs");

            DirectoryDelete(directoryDelete);

        }

        public Task GetAddon2(GitHub gitHub)
        {
            var getaddon = Task.Factory.StartNew(() =>
            {
                try
                {
                    if (Directory.Exists(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\old{gitHub.Name}"))
                    {
                        DirectoryDelete(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\old{gitHub.Name}");
                    }


                    if (Directory.Exists(gitHub.Name))
                    {
                        DirectoryDelete(gitHub.Name);
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

                    if (Directory.Exists(allfiles[0] + @"\.github"))
                    {
                        DirectoryDelete(allfiles[0] + @"\.github");
                    }
                    if (Directory.Exists(allfiles[0] + @"\.vs"))
                    {
                        DirectoryDelete(allfiles[0] + @"\.vs");
                    }
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
                    //MessageBox.Show(ex.ToString(), ex.Message);
                }
                DirectoryDelete(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\old{gitHub.Name}");
            });
            return getaddon;
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
    }
}
