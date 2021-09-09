using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace CoffeeShopConsoleApp.Tests
{
    [TestClass()]
    public class CoffeeTests
    {
        [TestMethod()]
        [DataRow(1)]
        [DataRow(6)]
        [DataRow(-1)]
        public void CoffeeTest(int discount)
        {
            //Arrange
            var coffee = new Cortado(discount);

            //Act
            int actualValue = coffee.Discount;

            //Assert
            Assert.IsTrue(actualValue > 0 || actualValue <= 5);
        }

        [TestMethod()]
        public void priceTestBlackCoffee()
        {
            //Arrange
            var coffee = new BlackCoffee(3);

            //Act
            int actualValue = coffee.price();

            //Assert
            Assert.AreEqual(20, actualValue);
        }

        [TestMethod()]
        public void priceTestCortado()
        {
            //Arrange
            var coffee = new Cortado(3);

            //Act
            int actualValue = coffee.price();

            //Assert
            Assert.AreEqual(25, actualValue);
        }

        [TestMethod()]
        public void priceTestLatte()
        {
            //Arrange
            var coffee = new Latte(3);

            //Act
            int actualValue = coffee.price();

            //Assert
            Assert.AreEqual(40, actualValue);
        }

        [TestMethod()]
        public void StrengthTestBlackCoffee()
        {
            //Arrange
            var coffee = new BlackCoffee(3);

            //Act
            string actualValue = coffee.Strength();

            //Assert
            Assert.IsTrue(actualValue == "Strong");

        }

        [TestMethod()]
        public void StrengthTestCortado()
        {
            //Arrange
            var coffee = new Cortado(3);

            //Act
            string actualValue = coffee.Strength();

            //Assert
            Assert.IsTrue(actualValue == "Medium");
        }

        [TestMethod()]
        public void StrengthTestLatte()
        {
            //Arrange
            var coffee = new Latte(3);

            //Act
            string actualValue = coffee.Strength();

            //Assert
            Assert.IsTrue(actualValue == "Weak");
        }
    }
}