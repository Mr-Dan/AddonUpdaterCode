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

        public Task Aupdatecheck()
        {
            var getVersion = Task.Factory.StartNew(() =>
            {
                List<GitHub> GitHubsNew = new List<GitHub>();
                List<GitHub> GitHubsToc = AupdatecheckToc("https://raw.githubusercontent.com/Mr-Dan/AddonUpdaterSettings/main/AddonLinks", @"(Version):\s*(.*\d)*", "Version:");
                List<GitHub> GitHubsSirus = AupdatecheckToc("https://raw.githubusercontent.com/Mr-Dan/AddonUpdaterSettings/main/AddonLinksSirus", @"(@Version):\s*(\d)*", "@Version:");
                GitHubsNew.AddRange(GitHubsToc);
                GitHubsNew.AddRange(GitHubsSirus);
                if (GitHubsNew.Count > 0)
                    if (ListCheck(GitHubs, GitHubsNew) == false)
                    {
                        GitHubs = new List<GitHub>(GitHubsNew);
                    }
            });
            return getVersion;
        }

        public List<GitHub> AupdatecheckToc(string link, string regex, string replace)
        {

            List<GitHub> GitHubsNew = new List<GitHub>();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;           
              
            string Get_url_Github = GetContent(link);

            string[] url_addons = Get_url_Github.Split('\n');
            for (int i = 0; i < url_addons.Length - 1; i++)
            {
                List<string> files = new List<string>();
                string[] lines2 = url_addons[i].Split(',');
                for (int j = 3; j < lines2.Length; j++)
                {
                    files.Add(lines2[j]);
                }

                GitHubsNew.Add(new GitHub() { Name = lines2[0], link = lines2[1], Branches = lines2[2], Files= files.ToList()});          
            }

            for (int i = 0; i < GitHubsNew.Count; i++)
            {
                string get_version = GetContent(GitHubsNew[i].link);
                Match reg = Regex.Match(get_version, regex);
                if (reg.Success) GitHubsNew[i].Version = reg.Value.Trim('\r').Replace(replace, "").Trim();                                
                else GitHubsNew[i].Version= "0";

            }

            for (int i = 0; i < GitHubsNew.Count; i++)
            {
                
                Match reg = Regex.Match(GitHubsNew[i].link, @"(\/)\w*(-)*\w*.(\/)\w*(-)*\w*.(toc)");
                string readPath = reg.Value;
                GitHubsNew[i].Directory = readPath;
                try
                {
                    if(File.Exists(Properties.Settings.Default.PathWow + @"\Interface\AddOns" + readPath))
                    using (StreamReader sr = new StreamReader(Properties.Settings.Default.PathWow + @"\Interface\AddOns" + readPath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            reg = Regex.Match(line, regex);
                            if (reg.Success)
                            {
                                //string myVersion = reg.Value.Replace(replace, "").Trim();
                                GitHubsNew[i].MyVersion = reg.Value.Replace(replace, "").Trim();
                                if (GitHubsNew[i].MyVersion != GitHubsNew[i].Version)
                                {
                                    GitHubsNew[i].NeedUpdate = true;
                                    GitHubsNew[i].Download = true;
                                    FormMainMenu.UpdateCount++;
                                }
                                else
                                {
                                    GitHubsNew[i].NeedUpdate = false;
                                }                  
                                break;
                            }
                            else GitHubsNew[i].MyVersion = "0";
                        }
                    }
                }
                catch(Exception ex) 
                {
                    //MessageBox.Show(ex.ToString(), "Предупреждение");
                }
            }

            return GitHubsNew;
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
                    if (G1[i].Version != G2[index].Version || G1[i].MyVersion != G2[index].MyVersion)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
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
                        string currdir = Directory.GetCurrentDirectory();
                        string[] alldir = Directory.GetDirectories(currdir);
                        
                        if (alldir.Length > 0)
                        {
                            for (int j = 0; j < alldir.Length; j++)
                            {
                                if (alldir[j].IndexOf(NeedUpdate[i].Name) > -1)
                                {
                                    DirectoryDelete(alldir[j]);
                                }
                            }
                        }
                        Directory.CreateDirectory(NeedUpdate[i].Name);

                        ZipFile.ExtractToDirectory($"{ NeedUpdate[i].Name}.zip", NeedUpdate[i].Name);

                        string[] allfiles = Directory.GetDirectories(NeedUpdate[i].Name);
                        string[] allfiles2 = Directory.GetDirectories(allfiles[0]);
                        string[] allfiles3 = Directory.GetFiles(allfiles[0]);

                        if (Directory.Exists(allfiles[0] + @"\.github"))
                        {
                            DirectoryDelete(allfiles[0] + @"\.github");
                        }
                        if (Directory.Exists(allfiles[0]+ @"\.vs"))
                        {
                            DirectoryDelete(allfiles[0] + @"\.vs");
                        }
                        allfiles2 = Directory.GetDirectories(allfiles[0]);


                        foreach (string file in allfiles3)
                        {
                            File.Delete(file);
                        }

                        ZipFile.CreateFromDirectory(allfiles[0], $"{NeedUpdate[i].Name}\\{NeedUpdate[i].Name}.zip");

                        for (int j = 0; j < allfiles2.Length; j++)
                        {
                            string sourceDirectory = Properties.Settings.Default.PathWow + @"\Interface\AddOns" + allfiles2[j].Replace(allfiles[0], "").Trim();
                            string destinationDirectory = Properties.Settings.Default.PathWow + @"\Interface\AddOns\old" + allfiles2[j].Replace(allfiles[0], "").Trim();

                            if (Directory.Exists(sourceDirectory))
                                Directory.Move(sourceDirectory, destinationDirectory);

                        }

                        ZipFile.ExtractToDirectory($"{NeedUpdate[i].Name}\\{NeedUpdate[i].Name}.zip", Properties.Settings.Default.PathWow + @"\Interface\AddOns");
                        DirectoryDelete(NeedUpdate[i].Name);
                        File.Delete($"{NeedUpdate[i].Name}.zip");
                    }
                }
                catch(Exception ex)
                {
                    //MessageBox.Show(ex.ToString(), ex.Message);
                }
                    DirectoryDelete(Properties.Settings.Default.PathWow + @"\Interface\AddOns\old");
                 
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
     
        public Task DownloadAddonGitHubTask(string link, string name, string dir, string branches)
        {
            link = link.Replace("https://raw.githubusercontent.com/", String.Empty);
            link = link.Replace($"/{branches}{dir}", String.Empty);
            using (WebClient client2 = new WebClient())
            {
                var task = client2.DownloadFileTaskAsync(new Uri($"https://github.com/{link}/archive/refs/heads/{branches}.zip"), $"{name}.zip");
                return task;
            }         
        }
  
        public void DeleteAddon()
        {      
            List<GitHub> delete = GitHubs.FindAll(find => find.Delete == true);
            string directoryDelete = Properties.Settings.Default.PathWow + $@"\Interface\AddOns\AddonsOld\";

            if (Directory.Exists(directoryDelete)) DirectoryDelete(directoryDelete);
            Directory.CreateDirectory(directoryDelete);

            for (int i = 0; i < delete.Count; i++)
            {
                for (int j = 0; j < delete[i].Files.Count; j++)
                {
                    string sourceDirectory = Properties.Settings.Default.PathWow + @"\Interface\AddOns\" + delete[i].Files[j];
                    string destinationDirectory = directoryDelete + delete[i].Files[j];
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
            }
                
            if (Directory.Exists(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\.github"))       
                if (Directory.Exists(directoryDelete))
                        Directory.Move(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\.github", directoryDelete+ @"\.github");
               
            if (Directory.Exists(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\.vs"))    
                if (Directory.Exists(directoryDelete))
                        Directory.Move(Properties.Settings.Default.PathWow + $@"\Interface\AddOns\.vs", directoryDelete + @"\.vs");
                 
            DirectoryDelete(directoryDelete);
           
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

    }
    public class  GitHub
    {
        public string Name { get; set; }
        public string link { get; set; }
        public string Directory { get; set; }
        public string Version { get; set; }
        public string MyVersion { get; set; }
        public string Branches { get; set; }
        public bool NeedUpdate { get; set; }
        public List<string> Files { get; set; }
        public bool Delete { get; set; }
        public bool  Download { get; set; }
        public bool Description { get; set; }
    }
}
