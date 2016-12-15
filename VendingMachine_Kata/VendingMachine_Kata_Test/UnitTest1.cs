using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using VendingMachine_Kata;

namespace VendingMachine_Kata_Test
{
    [TestClass]
    public class UnitTest1
    {
        private const string nickel = "nickel";
        private const string dime = "dime";
        private const string quarter = "quarter";

        [TestMethod]
        public void vendingMachineDisplaysAmountOfLastCoinInserted()
        {
            VendingMachine vm = new VendingMachine();
            vm.addCoin("dime");
            Assert.AreEqual(vm.credit, .10);
        }
    }
}
