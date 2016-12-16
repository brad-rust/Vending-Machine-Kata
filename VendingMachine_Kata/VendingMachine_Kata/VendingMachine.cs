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
        private Coin coin;
                
        public VendingMachine()
        {
            this.display = new Display();
        }

        public void insert(string _coin)
        {
            coin = new Coin(_coin);
            this.credit += coin.value;
            this.display.changeDisplayedCreditValue(this.credit);            
        }


    }
}
