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
        private const string insertCoin = "INSERT COIN";
        private const string soldOut = "SOLD OUT";
        private const string exactChange = "EXACT CHANGE ONLY";
        private double credit;

        public Display()
        {
            setDisplayExactChange();
        }

        public void setDisplayToCredit(double _credit)
        {
            this.credit = _credit;
            this.message = string.Format("{0:0.00}", this.credit);
        }

        public void setDisplayToCredit()
        {
            this.message = string.Format("{0:0.00}", this.credit);
        }

        public void setDisplayToPrice(double price)
        {
            this.message = string.Format("{0:0.00}", price);
        }

        public void setDisplayThankYou()
        {
            this.message = thankYou;
        }

        public void setDisplayToInsertCoin()
        {
            this.message = insertCoin;
        }

        public void setDisplayToSoldOut()
        {
            this.message = soldOut;
        }

        public void setDisplayExactChange()
        {
            this.message = exactChange;
        }

        public string displayMessage()
        {
            if (this.message == soldOut)
            {
                setDisplayToCredit();
                return soldOut;
            }
            return this.message;
        }
    }
}
