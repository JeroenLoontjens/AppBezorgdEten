using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBezorgdEten.Model
{
    internal class Menu
    {
        public List<Maaltijd> maaltijden;
        public List<Gerecht> gerechten;
        public string Naam { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
