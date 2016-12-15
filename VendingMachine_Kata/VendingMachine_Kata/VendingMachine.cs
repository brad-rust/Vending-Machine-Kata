using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Kata
{
    public class VendingMachine
    {
        public double credit {private set; get;}

        public void addCoin(string coin)
        {
            this.credit = .10;
        }
    }
}
