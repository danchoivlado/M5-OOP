using System;
using HardwareStore.BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HardwareStore.Models;

namespace UnitTests
{
    [TestClass]
    public class DailySalesReportUnitTests
    {
        [TestMethod]
        public void DailySalesReportPropertiesTest()
        {
            //Arrange 
            DailySales dailysales = new DailySales();

            //Act
            dailysales.ProductNumber = "1";
            dailysales.Quantity = 2;
            dailysales.SinglePrice = 12;
            dailysales.Total = 24;
            dailysales.Description = "Factory New";

            //Assert
            Assert.AreEqual(dailysales.ProductNumber, "1");
            Assert.AreEqual(dailysales.SinglePrice, 12);
            Assert.AreEqual(dailysales.Quantity, 2);
            Assert.AreEqual(dailysales.Total, 24);
            Assert.AreEqual(dailysales.Description, "Factory New");
        }

        [TestMethod]
        public void CreateDailySalesReportClass()
        {
            //Arrange & Act
            CartItem cartItem = new CartItem();

            //Assert
            Assert.IsNotNull(cartItem);
        }
    }
}
