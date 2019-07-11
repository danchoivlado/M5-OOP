using HardwareStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStore.BusinessLogic
{
    public class UpdateCreateSalesReportBLL
    {
        OfficeStoreContext officeStoreContext;

        public UpdateCreateSalesReportBLL()
        {
            this.officeStoreContext = new OfficeStoreContext();
        }

        public UpdateCreateSalesReportBLL(OfficeStoreContext MockContext)
        {
            this.officeStoreContext = MockContext;
        }

        /// <summary>
        /// Adds item to officeStoreContext;
        /// </summary>
        /// <param name="item">Object of item.</param>
        public void CreateItem(Items item)
        {
            //Creates item
            this.officeStoreContext.Items.Add(item);
            this.officeStoreContext.SaveChanges();
        }

        /// <summary>
        /// Updates the selected item.
        /// </summary>
        /// <param name="Item1">Object of the item to update.</param>
        /// <param name="ItemId">Id of the item in the database. </param>
        public void UpdateItem(Items Item1, string ItemId)
        {
            //Updates current item
            var Item2 = officeStoreContext.Items.FirstOrDefault(a => a.Id == ItemId);
            Item2.Id = Item1.Id;
            Item2.ProductName = Item1.ProductName;
            Item2.OriginalPrice = Item1.OriginalPrice;
            Item2.SalesPrice = Item1.SalesPrice;
            Item2.Quantity = Item1.Quantity;
            Item2.Status = Item1.Status;

            this.officeStoreContext.SaveChanges();
        }

        /// <summary>
        /// Check if the item exists
        /// </summary>
        /// <param name="Barcode">Barcode of the selected item </param>
        /// <returns> Returns true if item exist or folse if item not exist</returns>
        public bool IsItemExists(string Barcode)
        {
            //Checks if item exists
            var Item = this.officeStoreContext.Items.FirstOrDefault(a => a.Id == Barcode);
            if (Item == null)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Gets all the information of Items in the database and provides it to the DataGrid
        /// </summary>
        /// <returns> Returns List of items.</returns>
        public List<Items> GetAllInfo()
        {
            //Collects info from database
            var list = this.officeStoreContext.Items.ToList();
            return list;
        }

        /// <summary>
        /// Gets all the item saled today
        /// </summary>
        /// <returns> Returns List of saled items.</returns>
        public List<DailySales> DailySalesReprotInfo()
        {
            List<DailySales> DailySalesList = new List<DailySales>();
            var Date = DateTime.Now.Date;

            var Invoices = this.officeStoreContext.Invoice.Where(a => a.Date.ToString("d") == Date.Date.ToString("d"));
            //Finds the current invoice
            foreach (var Invoice in Invoices)
            {
                var InvoiceItems = this.officeStoreContext.InvoiceItems.Where(a => a.InvoiceId == Invoice.Id);

                foreach (var InvoiceItem in InvoiceItems)
                {
                    DailySales dailySales = new DailySales();

                    var Desciption = this.officeStoreContext.Items.First(a => a.Id == InvoiceItem.ItemId);

                    dailySales.ProductNumber = InvoiceItem.ItemId;
                    if (DailySalesList.Any(a => a.Description == Desciption.ProductName))
                    {
                        var item = DailySalesList.First(a => a.Description == Desciption.ProductName);

                        item.Quantity += InvoiceItem.Quantity;
                        item.SinglePrice = InvoiceItem.SinglePrice;
                        item.Total += InvoiceItem.Total;
                    }
                    else
                    {
                        dailySales.Description = Desciption.ProductName;
                        dailySales.Quantity = InvoiceItem.Quantity;
                        dailySales.SinglePrice = InvoiceItem.SinglePrice;
                        dailySales.Total = InvoiceItem.Total;
                        DailySalesList.Add(dailySales);
                    }
                }
            }
            return DailySalesList;
        }

        /// <summary>
        /// Gets all the item saled this month
        /// </summary>
        /// <returns> Returns List of saled items.</returns>
        public List<DailySales> MonthlySalesReprotInfo()
        {
            List<DailySales> DailySalesList = new List<DailySales>();
            var Date = DateTime.Now;

            var Invoices = this.officeStoreContext.Invoice.Where(a => a.Date.Year==Date.Year&& a.Date.Month == Date.Month);
            //Finds the current invoice
            foreach (var Invoice in Invoices)
            {
                var InvoiceItems = this.officeStoreContext.InvoiceItems.Where(a => a.InvoiceId == Invoice.Id);

                foreach (var InvoiceItem in InvoiceItems)
                {
                    DailySales dailySales = new DailySales();

                    var Desciption = this.officeStoreContext.Items.First(a => a.Id == InvoiceItem.ItemId);

                    dailySales.ProductNumber = InvoiceItem.ItemId;
                    if (DailySalesList.Any(a => a.Description == Desciption.ProductName))
                    {
                        var item = DailySalesList.First(a => a.Description == Desciption.ProductName);

                        item.Quantity += InvoiceItem.Quantity;
                        item.SinglePrice = InvoiceItem.SinglePrice;
                        item.Total += InvoiceItem.Total;
                    }
                    else
                    {
                        dailySales.Description = Desciption.ProductName;
                        dailySales.Quantity = InvoiceItem.Quantity;
                        dailySales.SinglePrice = InvoiceItem.SinglePrice;
                        dailySales.Total = InvoiceItem.Total;
                        DailySalesList.Add(dailySales);
                    }
                }
            }
            return DailySalesList;
        }

        /// <summary>
        /// Gets all the item saled this Year
        /// </summary>
        /// <returns> Returns List of saled items.</returns>
        public List<DailySales> YearlySalesReprotInfo()
        {
            List<DailySales> DailySalesList = new List<DailySales>();
            var Date = DateTime.Now;

            var Invoices = this.officeStoreContext.Invoice.Where(a => a.Date.Year == Date.Year);
            //Finds the current invoice
            foreach (var Invoice in Invoices)
            {
                var InvoiceItems = this.officeStoreContext.InvoiceItems.Where(a => a.InvoiceId == Invoice.Id);

                foreach (var InvoiceItem in InvoiceItems)
                {
                    DailySales dailySales = new DailySales();

                    var Desciption = this.officeStoreContext.Items.First(a => a.Id == InvoiceItem.ItemId);

                    dailySales.ProductNumber = InvoiceItem.ItemId;
                    if (DailySalesList.Any(a => a.Description == Desciption.ProductName))
                    {
                        var item = DailySalesList.First(a => a.Description == Desciption.ProductName);

                        item.Quantity += InvoiceItem.Quantity;
                        item.SinglePrice = InvoiceItem.SinglePrice;
                        item.Total += InvoiceItem.Total;
                    }
                    else
                    {
                        dailySales.Description = Desciption.ProductName;
                        dailySales.Quantity = InvoiceItem.Quantity;
                        dailySales.SinglePrice = InvoiceItem.SinglePrice;
                        dailySales.Total = InvoiceItem.Total;
                        DailySalesList.Add(dailySales);
                    }
                }
            }
            return DailySalesList;
        }

        /// <summary>
        /// Provides the status of the item  
        /// </summary>
        /// <param name="IsChecked"></param>
        /// <returns> If its true returns "Second Hand" if its false "Factory New".</returns>
        public string StatusText(bool IsChecked)
        {
            if (IsChecked)
            {
                return "Second Hand";
            }
            return "Factory New";
        }

        /// <summary>
        /// Checks string and returns bool
        /// </summary>
        /// <param name="status">Given status</param>
        public bool IsChecked(string status)
        {
            if (status == "Second Hand")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Deletes Item Everywere from the database
        /// </summary>
        /// <param name="Id">Id of the selected item</param>
        public void Delete(string Id)
        {
            var ItemToDelete = this.officeStoreContext.Items.First(a => a.Id == Id);
            foreach (var CurrentItem in this.officeStoreContext.InvoiceItems.Where(a => a.ItemId == ItemToDelete.Id))
            {
                //Deletes item info everywher from the database
                this.officeStoreContext.InvoiceItems.Remove(CurrentItem);
            }
            this.officeStoreContext.Items.Remove(ItemToDelete);
            this.officeStoreContext.SaveChanges();
        }

        /// <summary>
        /// Generate profit of the day due to provided Lis of Items
        /// </summary>
        /// <param name="dailySalesList">List of the all the items choosen by the client</param>
        /// <returns> Returns the sum of the profit.</returns>
        public double GenerateProfitOfTheDay(List<DailySales> dailySalesList)
        {
            double Total = 0d;
            foreach (var item in dailySalesList)
            {
                var DataBaseItem = this.officeStoreContext.Items.First(a => a.Id == item.ProductNumber);
                Total += (DataBaseItem.SalesPrice - DataBaseItem.OriginalPrice)*item.Quantity;
            }
            return Total;
        }
    }
}
