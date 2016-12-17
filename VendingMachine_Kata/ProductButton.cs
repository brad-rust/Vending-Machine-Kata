using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Kata
{
    public sealed class ProductButton
    {
        private readonly String name;
        private readonly int value;

        public static readonly ProductButton Chips = new ProductButton(0, "chips");
        public static readonly ProductButton Candy = new ProductButton(1, "candy");
        public static readonly ProductButton Cola = new ProductButton(2, "cola");

        private ProductButton(int value, String name)
        {
            this.name = name;
            this.value = value;
        }

        public override string ToString()
        {
            return name;
        }

    }

}
