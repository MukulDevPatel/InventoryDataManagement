using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    public class Stock
    {
        public string Name { get; set; }
        public int NumOfShares { get; set; }
        public double SharePrice { get; set; }
        public double Calculate()
        {
            return NumOfShares * SharePrice;
        }
    }
}
