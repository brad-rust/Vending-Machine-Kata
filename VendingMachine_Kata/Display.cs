using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Kata
{
    public class Display
    {
        private string message;
        private const string thankYou = "THANK YOU";

        public void setDisplayToCredit(double credit)
        {
            this.message = string.Format("{0:0.00}", credit);
        }
        
        public void setDisplayToPrice(double price)
        {
            this.message = string.Format("{0:0.00}", price);
        }

        public void setDisplayThankYou()
        {
            this.message = thankYou;
        }

        public string displayMessage()
        {
            return this.message;
        }
    }
}
