using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using VendingMachine_Kata;

namespace VendingMachine_Test
{
    [TestClass]
    public class UnitTest1
    {
        private const double nicekl = .05;
        private const double dime = .10;
        private const double quarter = .25;

        [TestMethod]
        public void whenValidCoinIsInserted_vendingMachineDisplaysAvailableCredit()
        {
            VendingMachine vm = new VendingMachine();
            vm.insert("dime");
            Assert.AreEqual(vm.display.availableCredit, "0.10");
        }

        [TestMethod]
        public void whenMultipleCoinsAreInserted_vendingMachineDisplaysAvailableCredit()
        {
            VendingMachine vm = new VendingMachine();
            vm.insert("quarter");
            vm.insert("quarter");
            Assert.AreEqual(vm.display.availableCredit, "0.50");
        }
    }
}
