using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBezorgdEten.Model
{
    internal class Maaltijd
    {
        public int Prijs { get; set; }
        public string Naam { get; set; }
        public string FotoLink { get; set; }
        public int MaaltijdID { get; set; }
        public List<Gerecht> gerechten { get; set; } 
    }
}
