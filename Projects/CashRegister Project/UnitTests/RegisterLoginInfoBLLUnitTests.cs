using System;
using HardwareStore.BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HardwareStore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace UnitTests
{
    [TestClass]
    public class RegisterLoginInfoBLLUnitTests
    {

        [TestMethod]
        public void CreateRegisterLoginInfoBLLClass()
        {
            //Arrange & Act
            RegisterLoginInfoBLL registerLoginInfoBLL = new RegisterLoginInfoBLL();

            //Assert
            Assert.IsNotNull(registerLoginInfoBLL);
        }

        //[TestMethod]
        //public void RegisterLoginInfoBLLLoginTest()
        //{
        //    //Arrange 
        //    RegisterLoginInfoBLL registerLoginInfoBLL = new RegisterLoginInfoBLL();

        //    //Act
        //    bool HasAccount = registerLoginInfoBLL.Login("1", "4");//Actual account with field (1,4)

        //    //Assert
        //    Assert.IsTrue(HasAccount);
        //}

        [TestMethod]
        public void RegisterLoginInfoBLLLoginTest()
        {
            //Arrange 
            Employees employee = new Employees()
            {
                FirstName = "1",
                LastName = "2",
                TownId = 3,
                Password = "4",
                DutyId = 1
            };

            var mockSet1 = new Mock<DbSet<Employees>>();
            var list = new List<Employees>() { employee};
            var queryable = list.AsQueryable();
            mockSet1.As<IQueryable<Employees>>().Setup(m => m.Provider).Returns(queryable.Provider);
            mockSet1.As<IQueryable<Employees>>().Setup(m => m.Expression).Returns(queryable.Expression);
            mockSet1.As<IQueryable<Employees>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            mockSet1.As<IQueryable<Employees>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());

            var mockContext = new Mock<OfficeStoreContext>();
            mockContext.Setup(c => c.Employees).Returns(mockSet1.Object);

            var service = new RegisterLoginInfoBLL(mockContext.Object);
            //Act
            bool HasAccount = service.Login("1", "4");//Actual account with field (1,4)

            //Assert
            Assert.IsTrue(HasAccount);
       
        }

        [TestMethod]
        public void RegisterLoginInfoBLLLoginTest2()
        {
            //Arrange 
            Employees employee = new Employees()
            {
                FirstName = "1",
                LastName = "2",
                TownId = 3,
                Password = "4",
                DutyId = 1
            };

            var mockSet1 = new Mock<DbSet<Employees>>();
            var list = new List<Employees>() { employee };
            var queryable = list.AsQueryable();
            mockSet1.As<IQueryable<Employees>>().Setup(m => m.Provider).Returns(queryable.Provider);
            mockSet1.As<IQueryable<Employees>>().Setup(m => m.Expression).Returns(queryable.Expression);
            mockSet1.As<IQueryable<Employees>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            mockSet1.As<IQueryable<Employees>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());

            var mockContext = new Mock<OfficeStoreContext>();
            mockContext.Setup(c => c.Employees).Returns(mockSet1.Object);

            var service = new RegisterLoginInfoBLL(mockContext.Object);
            //Act
            bool HasAccount = service.Login("1", "3");//Actual account with field (1,4)

            //Assert
            Assert.IsFalse(HasAccount);
        }

        [TestMethod]
        public void RegisterLoginInfoBLLLoginTest3()
        {
            //Arrange 
            Employees employee = new Employees()
            {
                FirstName = "1",
                LastName = "2",
                TownId = 3,
                Password = "4",
                DutyId = 1
            };

            var mockSet1 = new Mock<DbSet<Employees>>();
            var list = new List<Employees>() { employee };
            var queryable = list.AsQueryable();
            mockSet1.As<IQueryable<Employees>>().Setup(m => m.Provider).Returns(queryable.Provider);
            mockSet1.As<IQueryable<Employees>>().Setup(m => m.Expression).Returns(queryable.Expression);
            mockSet1.As<IQueryable<Employees>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            mockSet1.As<IQueryable<Employees>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());

            var mockContext = new Mock<OfficeStoreContext>();
            mockContext.Setup(c => c.Employees).Returns(mockSet1.Object);

            var service = new RegisterLoginInfoBLL(mockContext.Object);
            //Act
            bool HasAccount = service.Login("w", "3");//Actual account with field (1,4)

            //Assert
            Assert.IsFalse(HasAccount);
        }
        
        [TestMethod]
        public void TestMocking()
        {

            Employees employee = new Employees()
            {
                FirstName = "1",
                LastName = "2",
                TownId = 3,
                Password = "4",
                DutyId = 1
            };

            var data = new List<Towns>
            {
                new Towns(){Id =2,Name="Burgas"}
               
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Towns>>();
            mockSet.As<IQueryable<Towns>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Towns>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Towns>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Towns>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var data2 = new List<Employees>
            {
                employee
            }.AsQueryable();

            var mockSet2 = new Mock<DbSet<Employees>>();
            mockSet2.As<IQueryable<Employees>>().Setup(m => m.Provider).Returns(data2.Provider);
            mockSet2.As<IQueryable<Employees>>().Setup(m => m.Expression).Returns(data2.Expression);
            mockSet2.As<IQueryable<Employees>>().Setup(m => m.ElementType).Returns(data2.ElementType);
            mockSet2.As<IQueryable<Employees>>().Setup(m => m.GetEnumerator()).Returns(data2.GetEnumerator());

            var mockContext = new Mock<OfficeStoreContext>();
            mockContext.Setup(c => c.Towns).Returns(mockSet.Object);
            mockContext.Setup(c => c.Employees).Returns(mockSet2.Object);

            var service = new RegisterLoginInfoBLL(mockContext.Object);
            
            service.Register("Barman", "Kavalov", "Burgas", "12345678");
            Assert.IsTrue(service.officestoreContext.Employees.Count() == 1);
        }

        [TestMethod]
        public void RegisterLoginInfoBLLRegisterTest()
        {
            //Arrange 
            RegisterLoginInfoBLL registerLoginInfoBLL = new RegisterLoginInfoBLL();
            OfficeStoreContext officeStoreContext = new OfficeStoreContext();
            int InitialEmployeesCount = officeStoreContext.Employees.Count();

            //Act
            registerLoginInfoBLL.Register("Barman", "Kavalov", "Sliven", "12345678");
            int AfterInitialEmployeesCount = officeStoreContext.Employees.Count();

            //Assert
            Assert.AreEqual(InitialEmployeesCount + 1, AfterInitialEmployeesCount);
            officeStoreContext.Employees.Remove(officeStoreContext.Employees.First(a => a.FirstName == "Barman"));
            officeStoreContext.SaveChanges();
        }

        [TestMethod]
        public void RegisterLoginInfoBLLNameAddressMethodTest()
        {
            //Arrange 
            RegisterLoginInfoBLL registerLoginInfoBLL = new RegisterLoginInfoBLL();

            //Act
            string[] NameAddress = registerLoginInfoBLL.GetNameAddressIfExists();

            //Assert
            Assert.IsTrue(NameAddress[0] != null);
            Assert.IsTrue(NameAddress[1] != null);
        }

        [TestMethod]
        public void RegisterLoginInfoBLLSaveDataMethodTest()
        {
            //Arrange 
            RegisterLoginInfoBLL registerLoginInfoBLL = new RegisterLoginInfoBLL();
            OfficeStoreContext officeStoreContext = new OfficeStoreContext();
            string[] NameAddress = registerLoginInfoBLL.GetNameAddressIfExists();
            //Act
            registerLoginInfoBLL.SaveData("Test1", "Test2");
            var StoreInfo = officeStoreContext.StoreInfo.First();

            //Assert
            Assert.AreEqual(StoreInfo.Name,"Test1");
            Assert.AreEqual(StoreInfo.Address, "Test2");
            registerLoginInfoBLL.SaveData(NameAddress[0], NameAddress[1]);
        }
        [TestMethod]
        public void RegisterLoginInfoBLLSaveLoginedMethodTest()
        {
            //Arrange 
            RegisterLoginInfoBLL registerLoginInfoBLL = new RegisterLoginInfoBLL();
            OfficeStoreContext officeStoreContext = new OfficeStoreContext();
            var InitialLaslLoginLoad = officeStoreContext.LastLogin.Last().Id;

            //Act
            registerLoginInfoBLL.SaveLogined("1");
            var AfterInitialLaslLoginLoad = officeStoreContext.LastLogin.Last().Id;

            //Assert
            Assert.AreEqual(InitialLaslLoginLoad+1, InitialLaslLoginLoad+1);
            officeStoreContext.LastLogin.Remove(officeStoreContext.LastLogin.Last());
            officeStoreContext.SaveChanges();
        }
    }
}
