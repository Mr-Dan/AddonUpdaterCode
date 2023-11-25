using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddonUpdater.Models
{
    class Setting
    {
        public List<string> DeleteDirectory { get; set; }

        public List<Toc> Tocs { get; set; }

        public string News { get; set; }

        public string ListSpells { get; set; }

        public string ListSpellVisualKit { get; set; }

        public List<string> Files { get; set; }

        public string ForumLink { get; set; }

        public string GitHubLink { get; set; }

        public string DiscordLink { get; set; }

        public string DonateLink { get; set; }

        public string Author { get; set; }

        public string Contact { get; set; }

        public string Version { get; set; }

        public string Thx { get; set; }

    }

    class Toc
    {
        public string Link { get; set; }
        public string Regex { get; set; }

    }

    class SettingApp
    {
        public string PathWow { get; set; }
        public bool AutoUpdateBool { get; set; }

        public bool DescriptionBool { get; set; }

        public List<LastUpdateAddon> LastUpdate { get; set; }

        public bool LauncherOpen { get; set; }

        public List<string> UpdateAddon { get; set; }

        public List<string> PathsWow { get; set; }

        public string BackupWTF { get; set; }

    }
}
