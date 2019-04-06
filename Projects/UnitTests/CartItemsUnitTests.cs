using System;
using HardwareStore.BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HardwareStore.Models;
using System.Collections.Generic;
using System.Linq;
using Moq;
using Microsoft.EntityFrameworkCore;

namespace UnitTests
{
    [TestClass]
    public class CartItemsUnitTests
    {
        [TestMethod]
        public void CreateCartItemsClass()
        {
            //Arrange & Act
            CartItem cartItem = new CartItem();

            //Assert
            Assert.IsNotNull(cartItem);
        }

        [TestMethod]
        public void CreateCartItemsClassSecondConstructor()
        {
            //Arrange & Act
            CartItem cartItem = new CartItem("]C0KP1350300781802EF4PE03", "12");

            //Assert
            Assert.IsNotNull(cartItem);
        }

        [TestMethod]
        public void CreateCartItemsClassThirdConstructor()
        {
            //Arrange & Act
            var data = new List<Items>
            {
                new Items(){Id="1",Quantity=12,OriginalPrice=1,SalesPrice=2,
                    ProductName ="Pen",Status="Factory New"}

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Items>>();
            mockSet.As<IQueryable<Items>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Items>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Items>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Items>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<OfficeStoreContext>();
            mockContext.Setup(c => c.Items).Returns(mockSet.Object);

            CartItem cartItem = new CartItem("1", "12", mockContext.Object);

            //Assert
            Assert.IsNotNull(cartItem);
        }

        [TestMethod]
        public void CartItemsQuantityMinusTest()
        {
            //Arrange 
            var data = new List<Items>
            {
                new Items(){Id="1",Quantity=12,OriginalPrice=1,SalesPrice=2,
                    ProductName ="Pen",Status="Factory New"}

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Items>>();
            mockSet.As<IQueryable<Items>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Items>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Items>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Items>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<OfficeStoreContext>();
            mockContext.Setup(c => c.Items).Returns(mockSet.Object);

            CartItem cartItem = new CartItem("1", "12", mockContext.Object);

            int InitialQuantity = cartItem.Quantity;

            //Act
            cartItem.QuantityMinus();

            //Assert
            Assert.AreEqual(InitialQuantity-1,cartItem.Quantity);
        }

        [TestMethod]
        public void CartItemsQuantityPlusTest()
        {
            //Arrange 
            var data = new List<Items>
            {
                new Items(){Id="1",Quantity=12,OriginalPrice=1,SalesPrice=2,
                    ProductName ="Pen",Status="Factory New"}

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Items>>();
            mockSet.As<IQueryable<Items>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Items>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Items>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Items>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<OfficeStoreContext>();
            mockContext.Setup(c => c.Items).Returns(mockSet.Object);

            CartItem cartItem = new CartItem("1", "12", mockContext.Object);
            int InitialQuantity = cartItem.Quantity;

            //Act
            cartItem.QuantityPlus();

            //Assert
            Assert.AreEqual(InitialQuantity+1, cartItem.Quantity);
        }

        [TestMethod]
        public void CartItemsPropertiesTest()
        {
            //Arrange 
            var data = new List<Items>
            {
                new Items(){Id="1",Quantity=12,OriginalPrice=1,SalesPrice=2,
                    ProductName ="Pen",Status="Factory New"}

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Items>>();
            mockSet.As<IQueryable<Items>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Items>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Items>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Items>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<OfficeStoreContext>();
            mockContext.Setup(c => c.Items).Returns(mockSet.Object);

            CartItem cartItem = new CartItem("1", "12", mockContext.Object);

            //Act
            cartItem.Barcode ="1";
            cartItem.Quantity =2;
            cartItem.SinglePrice =12;
            cartItem.Total=24;

            //Assert
            Assert.AreEqual(cartItem.Barcode , "1");
            Assert.AreEqual(cartItem.SinglePrice , 12);
            Assert.AreEqual(cartItem.Quantity , 2);
            Assert.AreEqual(cartItem.Total , 24);
        }
    }
}
