using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBezorgdEten.Model
{
    internal class Promotie
    {
        public int PromotieID { get; set; } 
        public string Naam { get; set; }   
        public int Korting { get; set; }
        public Restaurant Restaurant { get; set; }
        public string PromoCode { get; set; }
    }
}
