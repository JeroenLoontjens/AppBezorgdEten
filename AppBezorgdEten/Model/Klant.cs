using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBezorgdEten.Model
{
    internal class Klant : Persoon
    {
        public Persoon persoon { get; set; }

        public bool AbboNieuwsbrief { get; set; }
        public int KlantID { get; set; }    

    }
}
