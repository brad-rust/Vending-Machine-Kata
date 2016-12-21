using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VendingMachine_Kata;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ProductButton chipsButton = ProductButton.Chips;
            VendingMachine vm = new VendingMachine();
            vm.insert("quarter");
            vm.insert("quarter");
            vm.insert("dime");
            vm.insert("nickel");
            vm.changeBank.putCoinsInBank(5, 5, 5);
            Product product = new Chips();
            vm.inventory.addInventory(product, 1);
            vm.pressProductButton(chipsButton);
            List<string> returnedCoins = new List<string> { "dime", "nickel" };
        }
    }
}
