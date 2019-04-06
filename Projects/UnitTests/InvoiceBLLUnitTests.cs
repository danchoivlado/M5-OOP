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
    public class InvoiceBLLUnitTests
    {
        [TestMethod]
        public void CreateInvoiceBLLClass()
        {
            //Arrange & Act
            InvoiceBLL invoiceBLL = new InvoiceBLL();

            //Assert
            Assert.IsNotNull(invoiceBLL);
        }

        [TestMethod]
        public void InvoiceBLLHasItemMethod()
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

            InvoiceBLL invoiceBLL = new InvoiceBLL(mockContext.Object);

            // Act
            bool HasNotItem = invoiceBLL.HasNotItem("1");

            //Assert
            Assert.IsFalse(HasNotItem);
        }

        [TestMethod]
        public void InvoiceBLLShowRecipeMethod()
        {
            //Arrange 
            InvoiceBLL invoiceBLL = new InvoiceBLL();

            // Act
            string Recipe= invoiceBLL.ShowRecipe();

            //Assert
            Assert.IsNotNull(Recipe);
        }

        [TestMethod]
        public void InvoiceBLLSaveMethod()
        {
            //Arrange 
            var data4 = new List<LastLogin>
            {
                new LastLogin(){EmployeeId=1,Id=1}

            }.AsQueryable();

            var mockSet4 = new Mock<DbSet<LastLogin>>();
            mockSet4.As<IQueryable<LastLogin>>().Setup(m => m.Expression).Returns(data4.Expression);
            mockSet4.As<IQueryable<LastLogin>>().Setup(m => m.ElementType).Returns(data4.ElementType);
            mockSet4.As<IQueryable<LastLogin>>().Setup(m => m.GetEnumerator()).Returns(data4.GetEnumerator());
            mockSet4.As<IQueryable<LastLogin>>().Setup(m => m.Provider).Returns(data4.Provider);

            var data3 = new List<InvoiceItems>
            {
                

            }.AsQueryable();

            var mockSet3 = new Mock<DbSet<InvoiceItems>>();
            mockSet3.As<IQueryable<InvoiceItems>>().Setup(m => m.Provider).Returns(data3.Provider);
            mockSet3.As<IQueryable<InvoiceItems>>().Setup(m => m.Expression).Returns(data3.Expression);
            mockSet3.As<IQueryable<InvoiceItems>>().Setup(m => m.ElementType).Returns(data3.ElementType);
            mockSet3.As<IQueryable<InvoiceItems>>().Setup(m => m.GetEnumerator()).Returns(data3.GetEnumerator());

            var data2 = new List<Items>
            {
                new Items(){Id="1",Quantity=12,OriginalPrice=1,SalesPrice=2,
                    ProductName ="Pen",Status="Factory New"}

            }.AsQueryable();

            var mockSet2 = new Mock<DbSet<Items>>();
            mockSet2.As<IQueryable<Items>>().Setup(m => m.Provider).Returns(data2.Provider);
            mockSet2.As<IQueryable<Items>>().Setup(m => m.Expression).Returns(data2.Expression);
            mockSet2.As<IQueryable<Items>>().Setup(m => m.ElementType).Returns(data2.ElementType);
            mockSet2.As<IQueryable<Items>>().Setup(m => m.GetEnumerator()).Returns(data2.GetEnumerator());

            var data = new List<Invoice>
            {
                new Invoice()

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Invoice>>();
            mockSet.As<IQueryable<Invoice>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Invoice>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Invoice>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Invoice>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<OfficeStoreContext>();
            mockContext.Setup(c => c.Invoice).Returns(mockSet.Object);
            mockContext.Setup(c => c.Items).Returns(mockSet2.Object);
            mockContext.Setup(c => c.InvoiceItems).Returns(mockSet3.Object);
            mockContext.Setup(c => c.LastLogin).Returns(mockSet4.Object);

            List<CartItem> cartItems = new List<CartItem>();
            InvoiceBLL invoiceBLL = new InvoiceBLL(mockContext.Object);
            int InitialInvoiceCount = mockContext.Object.Invoice.Count();

            // Act
            cartItems.Add(new CartItem() { Barcode = "1", Quantity = 1, SinglePrice = 6.4, Total = 6.4 });
            invoiceBLL.SaveInvoice(cartItems, "12");
            int AfterAddedInvoiceCouhnt = mockContext.Object.Invoice.Count();

            //Assert
            Assert.AreEqual(InitialInvoiceCount, AfterAddedInvoiceCouhnt);
        }

        [TestMethod]
        public void InvoiceBLLCount()
        {


            var data = new List<Invoice>
            {
                new Invoice()

            }.AsQueryable();

            var mockSet = new Mock<DbSet<Invoice>>();
            mockSet.As<IQueryable<Invoice>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Invoice>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Invoice>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Invoice>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<OfficeStoreContext>();
            mockContext.Setup(c => c.Invoice).Returns(mockSet.Object);

            var service = new InvoiceBLL(mockContext.Object);

            Assert.IsTrue(service.InvoiceCount() == 1);
        }
    }
}
