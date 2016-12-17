using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Kata
{
    public class Inventory
    {
        private int chipCount, colaCount, candyCount;
        Dictionary<string, int> productCounts;
        Chips chips = new Chips();
        Cola cola = new Cola();
        Candy candy = new Candy();

        public Inventory()
        {
            this.chipCount = 0;
            this.colaCount = 0;
            this.candyCount = 0;
            productCounts = new Dictionary<string, int>();
            productCounts.Add(chips.name, this.chipCount);
            productCounts.Add(cola.name, this.colaCount);
            productCounts.Add(candy.name, this.candyCount);
        }

        public void addInventory(Product product, int numberToAdd)
        {
            productCounts[product.name] += numberToAdd;
        }

        public bool inStock(Product product)
        {
            return productCounts[product.name] > 0 ? true : false;
        }

    }
}
