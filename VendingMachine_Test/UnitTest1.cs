using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using VendingMachine_Kata;

namespace VendingMachine_Test
{
    [TestClass]
    public class UnitTest1
    {
        private const double dNickel = .05;
        private const double dDime = .10;
        private const double dQuarter = .25;

        private const string sNickle = "nickel";
        private const string sDime = "dime";
        private const string sQuarter = "quarter";

        [TestMethod]
        public void whenValidCoinIsInserted_vendingMachineDisplaysAvailableCredit()
        {
            VendingMachine vm = new VendingMachine();
            vm.insert(sDime);
            Assert.AreEqual(vm.display.displayMessage(), "0.10");
        }

        [TestMethod]
        public void whenMultipleCoinsAreInserted_vendingMachineDisplaysAvailableCredit()
        {
            VendingMachine vm = add2QuartersToNewVendingMachine();
            Assert.AreEqual(vm.display.displayMessage(), "0.50");
        }

        [TestMethod]
        public void whenEnoughCreditIsAvailable_VendingMachineVends_Item()
        {
            VendingMachine vm = add2QuartersToNewVendingMachine();
            vm.pressButton(vm.button.Chips);
            List<string> items = new List<string>() { "chips" };
            CollectionAssert.AreEqual(vm.dispenser.contents, items);
        }

        [TestMethod]
        public void thankYouMessageIsDisplayed_afterMachineVendsItem()
        {
            VendingMachine vm = addOneDollarToNewVendingMachine();
            vm.pressButton(vm.button.Chips);
            Assert.AreEqual(vm.display.displayMessage(), "THANK YOU");
        }

        [TestMethod]
        public void whenTooLittleCredit_vendingMachineDisplaysCostOfItem()
        {
            VendingMachine vm = add2QuartersToNewVendingMachine();
            vm.pressButton(vm.button.Candy);
            Assert.AreEqual(vm.display.displayMessage(), "0.65");
        }

        private VendingMachine addOneDollarToNewVendingMachine()
        {
            VendingMachine vm = new VendingMachine();
            vm.insert(sQuarter);
            vm.insert(sQuarter);
            vm.insert(sQuarter);
            vm.insert(sQuarter);
            return vm;
        }

        private VendingMachine add2QuartersToNewVendingMachine()
        {
            VendingMachine vm = new VendingMachine();
            vm.insert(sQuarter);
            vm.insert(sQuarter);
            return vm;
        }
    }
}
