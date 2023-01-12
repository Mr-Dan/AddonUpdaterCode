using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddonUpdater.Models
{
    public  class PanelAddonSetings
    {
        public Label Name { get; set; }
        public Label Author { get; set; }
        public Label Category { get; set; }
        public Button Version { get; set; }
        public Button Delete { get; set; }
        public ProgressBar ProgressBar { get; set; }
        public PictureBox Track { get; set; }
        public int Width { get; set; }

    }
}
