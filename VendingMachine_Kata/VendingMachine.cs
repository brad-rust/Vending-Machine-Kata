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
        public ProductButton productButton;
        public CoinReturn coinReturn;
        private Coin coin;
        private List<Coin> insertedCoins;

        public VendingMachine()
        {
            this.display = new Display();
            this.dispenser = new Dispenser();
            this.productButton = new ProductButton();
            this.coinReturn = new CoinReturn();
            this.insertedCoins = new List<Coin>();
        }

        public void insert(string _coin)
        {
            coin = new Coin(_coin);
            this.credit += coin.value;
            this.insertedCoins.Add(coin);
            this.display.setDisplayToCredit(this.credit);            
        }

        public void pressProductButton(string item)
        {
            Product product = new Product(item);
            if (this.credit >= product.cost)
            {
                this.dispenser.addContents(product.name);
                this.display.setDisplayThankYou();
            }
            else
                this.display.setDisplayToPrice(product.cost);
        }

        public void pressCoinReturnButton()
        {
            foreach(Coin coin in this.insertedCoins)
            {
                this.coinReturn.placeCoinInSlot(coin);
            }
            this.insertedCoins = new List<Coin>();
        }

    }
}
