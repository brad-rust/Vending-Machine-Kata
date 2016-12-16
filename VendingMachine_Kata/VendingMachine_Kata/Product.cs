using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Kata
{
    public class Product
    {
        public string name { private set; get; }
        public double cost { private set; get; }

        private readonly Dictionary<string, double> products = new Dictionary<string, double>
        {
            {"chips", .5 },
            {"cola", 1.0 },
            {"candy", .65 }
        };

        public Product(string item)
        {
            this.name = item;
            this.cost = products[this.name];
        }
    }
}
