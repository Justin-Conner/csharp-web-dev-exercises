using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamShop
{
    public class ConeComparer: IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            double costDifference = x.Cost - y.Cost;
                if (costDifference > 0)
            {
                return 1; 
            }
                else if (costDifference < 0)
            {
                return -1;
            }
                return 0;   
             //int.Compare(x.Cost, y.Cost);
        }
    }
}
