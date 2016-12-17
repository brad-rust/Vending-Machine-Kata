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

        private readonly Dictionary<string, double> validCoins = new Dictionary<string, double>
        {
            {"nickel", 05 },
            {"dime", .10 },
            {"quarter", .25 }
        };

        public Coin(string coin)
        {
            this.name = coin;
            this.value = getValue(coin);
        }

        private double getValue(string coin)
        {
            double value = 0;
            validCoins.TryGetValue(coin, out value);
            return value;
        }


    }
}
