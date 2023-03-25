using System;
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

    }

    class Toc
    {
        public string Link { get; set; }
        public string Regex { get; set; }

    }
}
