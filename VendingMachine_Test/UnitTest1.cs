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

        private ProductButton chipsButton = ProductButton.Chips;
        private ProductButton colaButton = ProductButton.Cola;
        private ProductButton candyButton = ProductButton.Candy;

        private Product chips = new Chips();

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
            vm.inventory.addInventory(chips, 1);
            vm.pressProductButton(chipsButton);
            List<string> items = new List<string>() { "chips" };
            CollectionAssert.AreEqual(vm.dispenser.contents, items);
        }

        [TestMethod]
        public void thankYouMessageIsDisplayed_afterMachineVendsItem()
        {
            VendingMachine vm = addOneDollarToNewVendingMachine();
            vm.inventory.addInventory(chips, 1);
            vm.pressProductButton(chipsButton);
            Assert.AreEqual(vm.display.displayMessage(), "THANK YOU");
        }

        [TestMethod]
        public void whenTooLittleCredit_vendingMachineDisplaysCostOfItem()
        {
            VendingMachine vm = add2QuartersToNewVendingMachine();
            vm.pressProductButton(candyButton);
            Assert.AreEqual(vm.display.displayMessage(), "0.65");
        }

        [TestMethod]
        public void whenReturnCoinsButtonIsPressed_CoinsAreReturnedTotheCoinSlot()
        {
            VendingMachine vm = add40CentsToVendingMachine();
            vm.pressCoinReturnButton();

        }

        [TestMethod]
        public void whenMachineDoesNotContainCoins_displayDisplaysInsertCoins()
        {
            VendingMachine vm = new VendingMachine();
            vm.putChangeInChangeBank(5, 5, 5);
            Assert.AreEqual(vm.display.displayMessage(), "INSERT COIN");
        }

        [TestMethod]
        public void whenInvalidCoinIsPlacedInMachine_ItIsDivertedToTheCoinReturnSlot()
        {
            const string badCoin = "wooden nickel";
            List<string> coinReturn = new List<string>();
            coinReturn.Add(badCoin);
            VendingMachine vm = new VendingMachine();
            vm.insert(badCoin);
            CollectionAssert.AreEqual(coinReturn, vm.coinReturn.slot());
        }

        [TestMethod]
        public void whenProductButtonIsPressedAndThereIsNoProductToDispense_displayReads_SOLD_OUT()
        {
            VendingMachine vm = addOneDollarToNewVendingMachine();
            vm.pressProductButton(colaButton);
            Assert.AreEqual("SOLD OUT", vm.display.displayMessage());
        }

        [TestMethod]
        public void whenBankDoesNotContainEnoughChangeToReturnIfAnItemIsPurchased_Display_Exact_Change_Only_message()
        {
            VendingMachine vm = new VendingMachine();
            Assert.AreEqual(vm.display.displayMessage(), "EXACT CHANGE ONLY");            
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

        private VendingMachine add40CentsToVendingMachine()
        {
            VendingMachine vm = new VendingMachine();
            vm.insert(sDime);
            vm.insert(sQuarter);
            vm.insert(sNickle);
            return vm;
        }
    }
}
