using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddonUpdater.Models
{
    public class GitHub
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public string Directory { get; set; }
        public string Version { get; set; }
        public string MyVersion { get; set; }
        public string Branches { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string GithubLink { get; set; }
        public string Forum { get; set; }
        public string BugReport { get; set; }
        public string Regex { get; set; }
        public string Replace { get; set; }
        public string Category { get; set; }
        public bool NeedUpdate { get; set; }
        public bool DownloadMyAddon { get; set; }
        public bool Blacklist { get; set; }
        public bool SavedVariables { get; set; }
        public bool SavedVariablesPerCharacter { get; set; }
        public List<string> Files { get; set; }
    }
}
