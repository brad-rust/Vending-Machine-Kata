using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Kata
{
    public class Display
    {
        public string availableCredit { private set; get; }
        
        public void changeDisplayedCreditValue(double credit)
        {
            this.availableCredit = string.Format("{0:0.00}", credit);
        }
    }
}
