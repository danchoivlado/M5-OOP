using HardwareStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStore.BusinessLogic
{
    public class CartItem
    {
        public string Barcode { get; set; }
        public int Quantity { get; set; }
        public double SinglePrice { get; set; }
        public double Total { get; set; }
        OfficeStoreContext officestoreContext;

        public CartItem()
        {

        }

        public CartItem(string Barcode, string Quantity,OfficeStoreContext MockContext)
        {
            this.officestoreContext = MockContext;
            var Item = this.officestoreContext.Items.First(a => a.Id == Barcode);

            this.Barcode = Barcode;
            this.Quantity = int.Parse(Quantity);
            this.SinglePrice = Math.Round(Item.SalesPrice, 2);
            this.Total = Math.Round(this.Quantity * this.SinglePrice, 2);
        }

        /// <summary>
        /// Finds the Item from the database with the given Barcode 
        /// and with that info create CartItem
        /// </summary>
        /// <param name="Barcode">Barcode of the Item selected by the client</param>
        /// <param name="Quantity">Quantity of the item selected by the client</param>
        public CartItem(string Barcode, string Quantity)
        {
            this.officestoreContext = new OfficeStoreContext();
            var Item = this.officestoreContext.Items.First(a => a.Id == Barcode);

            this.Barcode = Barcode;
            this.Quantity = int.Parse(Quantity);
            this.SinglePrice = Math.Round(Item.SalesPrice,2);
            this.Total =Math.Round(this.Quantity*this.SinglePrice,2);
        }

        /// <summary>
        /// Decrease the quantity of the Selected Item by the client with one 
        /// </summary>
        public void QuantityMinus()
        {
            this.Quantity--;
            this.Total = this.Quantity * this.SinglePrice;
        }

        /// <summary>
        /// Increases the quantity of the Selected Item by the client with one 
        /// </summary>
        public void QuantityPlus()
        {
            this.Quantity++;
            this.Total = this.Quantity * this.SinglePrice;
        }
    }
}
