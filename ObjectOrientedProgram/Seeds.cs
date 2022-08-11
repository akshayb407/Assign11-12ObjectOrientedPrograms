using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram
{
    public class Seeds
    {
        public string Brand;
        public int PricePerkg;
        public int Weight;
        public int TotalPrice;
        public override string ToString()
        {
            return String.Format("name:\t{0}\nPrice Per Kg :\t{1}\nWeight:\t{3}", this.Brand, this.PricePerkg, this.Weight, this.TotalPrice);
        }
    }
}
