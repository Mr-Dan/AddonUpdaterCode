using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddonUpdater.Models
{
    class PanelAddonSetings
    {
        public Label AddonName { get; set; }
        public Label AddonAuthor { get; set; }
        public Label AddonCategory { get; set; }
        public Button AddonVersion { get; set; }
        public Button AddonDelete { get; set; }
        public ProgressBar ProgressBar { get; set; }
    }
}
