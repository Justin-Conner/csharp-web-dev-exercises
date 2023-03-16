using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamShop
{
    public class FlavorComparer : IComparer<Flavor>
    {
        public int Compare(Flavor x, Flavor y)
        {
            return string.Compare(x.Name, y.Name);
        }
        public int AllergenCompare(Flavor x, Flavor y) {
            double allergenDiff = x.Allergens.Count - y.Allergens.Count;
            if (allergenDiff > 0 )
            {
                return 1;
            }
            if (allergenDiff < 0) { 
                return -1;
            }
            return 0;
        }       
    }
}
