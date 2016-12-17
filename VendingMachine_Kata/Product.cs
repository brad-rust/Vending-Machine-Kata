using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Kata
{
    public class Product
    {
        public string name { protected set; get; }
        public double cost { protected set; get; }
    }

    public class Chips : Product
    {
        public Chips()
        {
            this.name = "chips";
            this.cost = .5;
        }
    }

    public class Cola : Product
    {
        public Cola()
        {
            this.cost = 1.0;
            this.name = "cola";
        }
    }

    public class Candy : Product
    {
        public Candy()
        {
            this.cost = .65;
            this.name = "candy";
        }
    }
}
