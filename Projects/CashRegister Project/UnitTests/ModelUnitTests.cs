using System;
using HardwareStore.BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HardwareStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class ModelUnitTests
    {
        [TestMethod]
        public void DutiesClassTest()
        {
            // Arrange & Act
            Duties duties = new Duties();

            //Assert
            Assert.IsNotNull(duties);
        }

        [TestMethod]
        public void EmployeesClassTest()
        {
            // Arrange & Act
            Employees employees = new Employees();

            //Assert
            Assert.IsNotNull(employees);
        }

        [TestMethod]
        public void InvoiceClassTest()
        {
            // Arrange & Act
            Invoice invoice = new Invoice();

            //Assert
            Assert.IsNotNull(invoice);
        }

        [TestMethod]
        public void InvoiceItemsClassTest()
        {
            // Arrange & Act
            InvoiceItems invoiceItems = new InvoiceItems();

            //Assert
            Assert.IsNotNull(invoiceItems);
        }

        [TestMethod]
        public void ItemsClassTest()
        {
            // Arrange & Act
            Items items = new Items();

            //Assert
            Assert.IsNotNull(items);
        }

        [TestMethod]
        public void LastLoginClassTest()
        {
            // Arrange & Act
            LastLogin lastLogin = new LastLogin();

            //Assert
            Assert.IsNotNull(lastLogin);
        }

        [TestMethod]
        public void PaymentmethodClassTest()
        {
            // Arrange & Act
            Paymentmethod paymentmethod = new Paymentmethod();

            //Assert
            Assert.IsNotNull(paymentmethod);
        }

        [TestMethod]
        public void StoreInfoClassTest()
        {
            // Arrange & Act
            StoreInfo storeInfo = new StoreInfo();

            //Assert
            Assert.IsNotNull(storeInfo);
        }

        [TestMethod]
        public void TownsClassTest()
        {
            // Arrange & Act
            Towns towns = new Towns();

            //Assert
            Assert.IsNotNull(towns);
        }
    }
}
