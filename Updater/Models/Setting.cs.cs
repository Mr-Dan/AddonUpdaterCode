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

        public List<string> Files { get; set; }

        public string ForumLink { get; set; }

        public string GitHubLink { get; set; }

        public string DiscordLink { get; set; }

        public string DonateLink { get; set; }

        public string Contact { get; set; }

        public string Version { get; set; }

        public string VersionUpdate { get; set; }

        public string AddonUpdaterLink { get; set; }

        public string UpdateLink { get; set; }

        public string Thx { get; set; }

    }

    class Toc
    {
        public string Link { get; set; }
        public string Regex { get; set; }

    }
}
