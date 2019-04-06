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
    public class UpdateCreateSalesReportBLLTests
    {
        [TestMethod]
        public void UpdateCreateSalesReportBLLClass()
        {
            //Arrange & Act
            UpdateCreateSalesReportBLL updateCreateSalesReportBLL = new UpdateCreateSalesReportBLL();

            //Assert
            Assert.IsNotNull(updateCreateSalesReportBLL);
        }

        [TestMethod]
        public void UpdateCreateSalesReportBLLTest()
        {
            //Arrange 
            UpdateCreateSalesReportBLL updateCreateSalesReportBLL = new UpdateCreateSalesReportBLL();
            OfficeStoreContext officeStoreContext = new OfficeStoreContext();

            //Act
            var InitialItemsCount = officeStoreContext.Items.Count();
            updateCreateSalesReportBLL.CreateItem(new Items()
            { Id = "12", ProductName = "bira", Status = "Factory New", OriginalPrice = 1, SalesPrice = 2, Quantity = 12 });
            var AfterInitialItemsCount = officeStoreContext.Items.Count();

            //Assert
            Assert.AreEqual(InitialItemsCount + 1, AfterInitialItemsCount);
            officeStoreContext.Items.Remove(officeStoreContext.Items.First(a => a.ProductName == "bira"));
            officeStoreContext.SaveChanges();
        }

        [TestMethod]
        public void UpdateCreateSalesReportBLLIsItemExistsTest()
        {
            //Arrange 
            UpdateCreateSalesReportBLL updateCreateSalesReportBLL = new UpdateCreateSalesReportBLL();
            OfficeStoreContext officeStoreContext = new OfficeStoreContext();

            //Act
            updateCreateSalesReportBLL.CreateItem(new Items()
            { Id = "12", ProductName = "bira", Status = "Factory New", OriginalPrice = 1, SalesPrice = 2, Quantity = 12 });
            bool IsItemExists = updateCreateSalesReportBLL.IsItemExists("12");

            //Assert
            Assert.IsTrue(IsItemExists);
            officeStoreContext.Items.Remove(officeStoreContext.Items.First(a => a.ProductName == "bira"));
            officeStoreContext.SaveChanges();

        }

        [TestMethod]
        public void UpdateCreateSalesReportBLLIsItemExistsTest2()
        {
            //Arrange 
            UpdateCreateSalesReportBLL updateCreateSalesReportBLL = new UpdateCreateSalesReportBLL();
            OfficeStoreContext officeStoreContext = new OfficeStoreContext();

            //Act
            bool IsItemExists = updateCreateSalesReportBLL.IsItemExists("1212121212");

            //Assert
            Assert.IsFalse(IsItemExists);
        }

        [TestMethod]
        public void UpdateCreateSalesReportBLLIsGetAllInfoTest()
        {
            //Arrange 
            UpdateCreateSalesReportBLL updateCreateSalesReportBLL = new UpdateCreateSalesReportBLL();
            OfficeStoreContext officeStoreContext = new OfficeStoreContext();

            //Act
            List<Items> Items = updateCreateSalesReportBLL.GetAllInfo();

            //Assert
            Assert.IsNotNull(Items);
        }

        [TestMethod]
        public void UpdateCreateSalesReportBLLISalesReprotInfoTest()
        {
            //Arrange 
            UpdateCreateSalesReportBLL updateCreateSalesReportBLL = new UpdateCreateSalesReportBLL();
            OfficeStoreContext officeStoreContext = new OfficeStoreContext();

            //Act
            List<DailySales> Items = updateCreateSalesReportBLL.SalesReprotInfo();

            //Assert
            Assert.IsNotNull(Items);
        }

        [TestMethod]
        public void UpdateCreateSalesReportBLLStatusTextTest()
        {
            //Arrange 
            UpdateCreateSalesReportBLL updateCreateSalesReportBLL = new UpdateCreateSalesReportBLL();

            //Act
            string Text = updateCreateSalesReportBLL.StatusText(false);

            //Assert
            Assert.AreEqual("Factory New", Text);
        }

        [TestMethod]
        public void UpdateCreateSalesReportBLLStatusTextTest2()
        {
            //Arrange 
            UpdateCreateSalesReportBLL updateCreateSalesReportBLL = new UpdateCreateSalesReportBLL();

            //Act
            string Text = updateCreateSalesReportBLL.StatusText(true);

            //Assert
            Assert.AreEqual("Second Hand", Text);
        }

        [TestMethod]
        public void UpdateCreateSalesReportBLLIsCheckedTest1()
        {
            //Arrange 
            UpdateCreateSalesReportBLL updateCreateSalesReportBLL = new UpdateCreateSalesReportBLL();

            //Act
            bool IsChecked = updateCreateSalesReportBLL.IsChecked("Second Hand");

            //Assert
            Assert.IsTrue(IsChecked);
        }

        [TestMethod]
        public void UpdateCreateSalesReportBLLIsCheckedTest2()
        {
            //Arrange 
            UpdateCreateSalesReportBLL updateCreateSalesReportBLL = new UpdateCreateSalesReportBLL();

            //Act
            bool IsChecked = updateCreateSalesReportBLL.IsChecked("Factory New");

            //Assert
            Assert.IsFalse(IsChecked);
        }

        [TestMethod]
        public void UpdateCreateSalesReportBLLDeleteTest()
        {
            //Arrange 
            UpdateCreateSalesReportBLL updateCreateSalesReportBLL = new UpdateCreateSalesReportBLL();
            OfficeStoreContext officeStoreContext = new OfficeStoreContext();


            //Act
            updateCreateSalesReportBLL.CreateItem(new Items()
            { Id = "12", ProductName = "bira", Status = "Factory New", OriginalPrice = 1, SalesPrice = 2, Quantity = 12 });
            var AfterCreateItemCount = officeStoreContext.Items.Count();
            updateCreateSalesReportBLL.Delete(officeStoreContext.Items.First(a => a.ProductName == "bira").Id);
            var AfterDeleteItemCount = officeStoreContext.Items.Count();



            //Assert
            Assert.AreEqual(AfterCreateItemCount - 1, AfterDeleteItemCount);

        }

        [TestMethod]
        public void UpdateCreateSalesReportBLLGenerateProfitOfTheDayTest()
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

            var updateCreateSalesReportBLL = new UpdateCreateSalesReportBLL(mockContext.Object);
            var CartItem = new DailySales() { ProductNumber="1",Quantity=1,SinglePrice=1
                ,Description="Item",Total=1};
            var ItemsList = new List<DailySales>() { CartItem };

            //Act
            double ProfitOfTheDay =updateCreateSalesReportBLL.GenerateProfitOfTheDay(ItemsList);

            //Assert
            Assert.AreEqual(ProfitOfTheDay , 1);

        }
    }
}
