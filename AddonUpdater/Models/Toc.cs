using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddonUpdater.Models
{
    class Toc
    {
        public Toc(string line)
        {
            string[] toc = line.Split(',');

            GitHubToc = toc[0].Trim();
            GitHubTocRegex = toc[1].Trim();
            GitHubTocReplase = toc[2].Trim();
        }
        public string GitHubToc { get; set; }
        public string GitHubTocRegex { get; set; }
        public string GitHubTocReplase { get; set; }
    }
}
