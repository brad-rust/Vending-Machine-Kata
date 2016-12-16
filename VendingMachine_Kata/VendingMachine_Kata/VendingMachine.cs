using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Kata
{
    public class VendingMachine
    {

        public double credit { private set; get; }
        public Display display;
        public Dispenser dispenser;
        private Coin coin;
        

        public VendingMachine()
        {
            this.display = new Display();
            this.dispenser = new Dispenser();
        }

        public void insert(string _coin)
        {
            coin = new Coin(_coin);
            this.credit += coin.value;
            this.display.setDisplayToCredit(this.credit);            
        }

        public void pressButton(string item)
        {
            Product product = new Product(item);
            if (this.credit >= product.cost)
                this.dispenser.addContents(product.name);
            else
                this.display.setDisplayToPrice(product.cost);
        }
    }
}
