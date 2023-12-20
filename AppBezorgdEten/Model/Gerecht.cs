using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBezorgdEten.Model
{
    internal class Gerecht
    {
        public int GerechtID { get; set; }

        public string GerechtNaam { get; set; }
        public Maat maat { get; set; }
        public string fotolink { get; set; }  
        public Status status { get; set; }
        public SoortGerecht soortGerecht { get; set; }
     
    }
}
