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
        public Inventory inventory;
        private Coin coin;
        private List<Coin> insertedCoins;
        private readonly Dictionary<string, Product> products;
        Product candy;
        Product cola;
        Product chips;
        private ChangeBank changeBank;

        public VendingMachine()
        {
            this.changeBank = new ChangeBank();
            this.display = new Display();
            this.dispenser = new Dispenser();
            this.coinReturn = new CoinReturn();
            this.insertedCoins = new List<Coin>();
            this.candy = new Candy();
            this.cola = new Cola();
            this.chips = new Chips();
            this.inventory = new Inventory();
            createDictionary(ref products);
            setDisplay();
        }

        private void setDisplay()
        {
            if (changeBank.exactChangeRequired())
                display.setDisplayExactChange();
            else
                display.setDisplayToInsertCoin();
        }

        public void putChangeInChangeBank(int nC, int dC, int qC)
        {
            changeBank.putCoinsInBank(nC, dC, qC);
            setDisplay();
        }

        public void insert(string _coin)
        {
            coin = new Coin(_coin);
            if (coin.value > 0)
            {
                this.credit += coin.value;
                this.insertedCoins.Add(coin);
                this.display.setDisplayToCredit(this.credit);
            }
            else
                this.coinReturn.placeCoinInSlot(coin);
        }

        public void pressProductButton(ProductButton item)
        {
            Product product = this.products[item.ToString()];
            if (this.credit >= product.cost)
            {
                if (inventory.inStock(product))
                {
                    this.dispenser.addContents(product.name);
                    this.display.setDisplayThankYou();
                }
                else
                    this.display.setDisplayToSoldOut();
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

         private void createDictionary(ref Dictionary<string, Product> products)
        {
            products = new Dictionary<string, Product>();
            products.Add(ProductButton.Candy.ToString(), this.candy);
            products.Add(ProductButton.Cola.ToString(), this.cola);
            products.Add(ProductButton.Chips.ToString(), this.chips);   
        }
    }
}
