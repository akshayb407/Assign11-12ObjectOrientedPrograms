using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram
{
    public class Card
    {
        private string suit, value;
        public Card(string tvalue, string tsuit)
        {
            this.suit = tsuit;
            this.value = tvalue;
        }
        public override string ToString()
        {
            return this.value + " of " + this.suit;
        }
    }
}
