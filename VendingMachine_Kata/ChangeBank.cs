﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine_Kata
{
    public class ChangeBank
    {
        int nickelCount = 0, dimeCount = 0, quarterCount = 0;
        private const double quarter = .25, dime = .1, nickel = .05;

        public void putCoinsInBank(int nC, int dC, int qC)
        {
            nickelCount = nC;
            dimeCount = dC;
            quarterCount = qC;
        }

        public bool exactChangeRequired()
        {
            if ((quarterCount < 2) || dimeCount < 1 || nickelCount < 1)
                return true;
            return false;
        }

        public Coin getLargestCoinPossible(double credit)
        {
            Coin coin;
            if (credit >= quarter)
                coin = new Coin("quarter");
            else if (credit >= dime)
                coin = new Coin("dime");
            else
                coin = new Coin("nickel");
            return coin;
        }
    }
}
