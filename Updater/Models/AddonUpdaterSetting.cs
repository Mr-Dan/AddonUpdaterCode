﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddonUpdater.Models
{
    class AddonUpdaterSetting
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

        public string Contacts { get; set; }

        public string Version { get; set; }


    }

    class Toc
    {
        public string Link { get; set; }
        public string Regex { get; set; }

    }
}
