using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBezorgdEten.Model
{
    internal class Revieuw
    {
        public Klant klant { get; set; }
        public Restaurant restaurant { get; set; }
        public string beschrijving { get; set; }
        public int beoordeling { get; set; }
        public Maaltijd Maaltijd { get; set; }
        public string Reactie { get; set; }
        public int RevieuwID { get; set; }

    }
}
