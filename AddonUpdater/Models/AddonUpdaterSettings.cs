using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddonUpdater.Models
{
    class AddonUpdaterSettings
    {
        public List<Toc> Tocs { get; set; }
        public List<string> DeleteDirectory { get; set; }
        public string LinkLastUpdate { get; set; }
    }
}
