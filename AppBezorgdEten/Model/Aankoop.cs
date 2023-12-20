using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBezorgdEten.Model
{
    internal class Aankoop
    {
        public int AankoopID { get; set; }
        public List<Gerecht> Gerechten { get; set;}
        public Status status { get; set; }
        public Klant klant { get; set; }
        public Restaurant restaurant { get; set; }
        public Promotie korting { get; set; }
        public int TotaalPrijs { get; set; }    
    }
}
