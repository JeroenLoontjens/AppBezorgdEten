using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBezorgdEten.Model
{
    internal class Bezorger : Persoon
    {

        public Persoon persoon { get; set; }
        public List<Beschikbaar> beschikbaarheid { get; set; }
    }
}
