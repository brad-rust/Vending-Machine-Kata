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
            VendingMachine vm = new VendingMachine();
            vm.insert("quarter");
            vm.insert("quarter");
            vm.pressProductButton(ProductButton.Candy);
            vm.display.displayMessage();
        }
        
    }
}
