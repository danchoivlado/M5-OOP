using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HardwareStore.Models;

namespace HardwareStore.BusinessLogic
{
    public class InvoiceBLL
    {
        OfficeStoreContext officeStoreContext;

        public InvoiceBLL()
        {
            this.officeStoreContext =new OfficeStoreContext();
        }

        public InvoiceBLL(OfficeStoreContext mockcontex)
        {
            this.officeStoreContext = mockcontex;
        }

        /// <summary>
        /// Add to database all the ordered Products to the table Invoice Items
        /// Creates Invoice and adds it to table Invoices
        /// </summary>
        /// <param name="cartItems">List of all the ordered Items</param>
        /// <param name="CashAmount">Cash ammount given by the client</param>
        /// <returns>Returns the change for the client</returns>
        public double SaveInvoice(List<CartItem> cartItems, string CashAmount )
        {
            var Id = this.officeStoreContext.Invoice.Count() + 1;
            foreach (var item in cartItems)
            {
                InvoiceItems InvoiceItem = new InvoiceItems()
                {
                    ItemId = item.Barcode,
                    Quantity = item.Quantity,
                    SinglePrice = item.SinglePrice,
                    Total = item.Total,
                    InvoiceId = Id
                };
                this.officeStoreContext.Items.First(a => a.Id == InvoiceItem.ItemId).Quantity-= InvoiceItem.Quantity;
                this.officeStoreContext.InvoiceItems.Add(InvoiceItem);
            }
            Invoice invoice = new Invoice()
            {
                OrderNo = Id + 1000,
                Date = DateTime.Now.Date,
                Time = DateTime.Now.TimeOfDay,
                EmployeeId = this.officeStoreContext.LastLogin.Last().EmployeeId,
                Total = cartItems.Sum(a => a.Total),
                PaymentMethodId = 1,
                StoreInfoId = 1
            };


            this.officeStoreContext.Invoice.Add(invoice);
            this.officeStoreContext.SaveChanges();
            return (double.Parse(CashAmount) - invoice.Total);
        }

        /// <summary>
        /// Gets the last Invoice of the database
        /// Show how the Recipe will look.
        /// </summary>
        /// <returns>String of the Recipe</returns>
        public string ShowRecipe()
        {
            StringBuilder sb = new StringBuilder();
            var Invoice = this.officeStoreContext.Invoice.Last();//Gets current invoice
            var Customer = this.officeStoreContext.Employees.First(a => a.Id == Invoice.EmployeeId);
            //Gets current customer
            var storeInfo = this.officeStoreContext.StoreInfo.First();//Gets store info
            var Items = this.officeStoreContext.InvoiceItems.Where(a=>a.InvoiceId==Invoice.Id);//Gets all items

            sb.AppendLine($"{storeInfo.Name}");
            sb.AppendLine($"{storeInfo.Address}");
            sb.AppendLine($"");
            sb.AppendLine($@"Сметка\номер:         {Invoice.OrderNo} от {Invoice.Date.ToString("d")} {Invoice.Time.ToString().Substring(0,5)}");
            sb.AppendLine($@"Касиер:  {Customer.FirstName} {Customer.LastName}");
            sb.AppendLine($@"--------------------------------------------");
            sb.AppendLine($@"|    наименование    | кол. | ед.цена | стойност |");
            sb.AppendLine($@"--------------------------------------------");
            foreach (var item in Items)
            {
                sb.AppendLine(GenerateItems(item));
            }

            sb.AppendLine($@"--------------------------------------------");
            sb.AppendLine($@"Стойност на сметката:                {Invoice.Total:f2}");

            return sb.ToString(); ;
        }

        /// <summary>
        /// Checks if there is not Item with this Barcode
        /// </summary>
        /// <param name="Barcode">Given Barcode</param>
        /// <returns>true or false</returns>
        public bool HasNotItem(string Barcode)
        {
            //Checks if item exists 
            var Item = this.officeStoreContext.Items.FirstOrDefault(a => a.Id == Barcode);
            if (Item is null)
                return true;
            return false;
        }

        /// <summary>
        /// Genrete Line used in the ShowRecipe method wih all the needed space between the words
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Perfect ordered line</returns>
        private  string GenerateItems(InvoiceItems item)
        {
            //Generates item
            var Total = item.SinglePrice * item.Quantity;
            var ItemName = this.officeStoreContext.Items.First(a => a.Id == item.ItemId).ProductName;
            return $"{ItemName}{Spaces(ItemName, 32)}{item.Quantity}{Spaces(item.Quantity.ToString(), 5)}{item.SinglePrice:f2}{Spaces(item.SinglePrice.ToString(), 8)}{Total:f2} ";
        }

        /// <summary>
        /// Generete spaces between the word due to Item lenght and Spaces of the line 
        /// </summary>
        /// <param name="Item">Word of the certain line</param>
        /// <param name="TotalSpaces">The spaces needed for the line</param>
        /// <returns></returns>
        private  string Spaces(string Item, int TotalSpaces)
        {
            //Generate Spaces
            return new string(' ', TotalSpaces - Item.Length);
        }

        /// <summary>
        /// Gets all the records of the invoice table 
        /// </summary>
        /// <returns>The count of the records</returns>
        public int InvoiceCount()
        {
            return this.officeStoreContext.Invoice.Count();
        }
    }
}
