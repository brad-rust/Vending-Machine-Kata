using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Kata
{
    public class Coin
    {
        public string name { set; get; }
        public double value { set; get; }

        public Coin(string coin)
        {
            this.name = coin;
            this.value = .10;
        }
    }
}
