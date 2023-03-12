using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddonUpdater.Models
{
    class Realms
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Persons { get; set; }
        public bool IsOnline { get; set; }
        public int Online { get; set; }
    }
}
