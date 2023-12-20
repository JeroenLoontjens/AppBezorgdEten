using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBezorgdEten.Model
{
    internal class Restaurant
    {
        public int RestaurantID { get; set; }
        public string RestaurantNaam { get; set; }
        public string Adres { get; set; }
        public int Bezorgstraal { get; set; }
        public List<Menu> menus { get; set; }   
    }

    public int GenereerComissie()
    {
        int count = 0;

        return count;
    }
}
