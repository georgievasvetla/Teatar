using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatarCompear
{
    class IPriceComperator : IComparer<Teatar>
    {
        public int Compare(Teatar x, Teatar y)
        {
            return x.Price.CompareTo(y.Price); 
        }
    }
}
