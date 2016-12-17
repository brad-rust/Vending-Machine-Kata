using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Kata
{
    public class CoinReturn
    {
        private List<string> Slot;

        public CoinReturn()
        {
            this.Slot = new List<string>();
        }

        public void placeCoinInSlot(Coin coin)
        {
            this.Slot.Add(coin.name);
        }

        public List<string> slot()
        {
            return this.Slot;
        }  
    }
}
