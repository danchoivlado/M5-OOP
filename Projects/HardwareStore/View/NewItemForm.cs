using HardwareStore.BusinessLogic;
using HardwareStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareStore.View
{
    public partial class NewItemForm : Form
    {
        UpdateCreateSalesReportBLL updateCreateSalesReportBLL= new UpdateCreateSalesReportBLL();
        Items Item;
        //Keeps the item data
        StoreItemsForm StoreItemsForm;

        public NewItemForm()
        {
            InitializeComponent();
            this.Item = new Items();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ActiveControl = this.BarcodeTxtBox;
        }

        /// <summary>
        /// Constructor for the Update Button
        /// with the info from the given object
        /// </summary>
        /// <param name="Item">Object that we will take the info</param>
        public NewItemForm(Items Item)
        {
            InitializeComponent();
            PasteItemInfo(Item);
            // this.FirsBarcode = Item.Id;
            this.Item = new Items();
            this.Item = Item;
            this.BarcodeTxtBox.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        /// <summary>
        /// Creates item object and saves it to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateBut_Click_1(object sender, EventArgs e)
        {

            string BarcodeText = this.BarcodeTxtBox.Text;

            if (!this.updateCreateSalesReportBLL.IsItemExists(Item.Id))//Checks if item not exists
            {
                //Creates new item
                if (!Validate(this.BarcodeTxtBox.Text, this.ProductNameTxtBox.Text,this.OriginalPriceTxtBox.Text,
                    this.SalesPriceTxtBox.Text,this.QuantityTxtBox.Text))
                {
                    this.updateCreateSalesReportBLL.CreateItem(this.ToClass());//Sent it to the BLL
                    ClearDataFromTxtBoxes();
                }
            }
            else
            {
                //Updates the item
                if (!Validate(this.BarcodeTxtBox.Text, this.ProductNameTxtBox.Text,this.OriginalPriceTxtBox.Text,
                    this.SalesPriceTxtBox.Text, this.QuantityTxtBox.Text))
                {
                    this.updateCreateSalesReportBLL.UpdateItem(ToClass(), Item.Id);//Sent to BLL
                    GenerateForm();
                }
            }
        }

        private void GenerateForm()
        {
            //Creates new form and closes the old one
            this.StoreItemsForm = new StoreItemsForm();
            this.Hide();
            this.StoreItemsForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Reset the text of all the texboxes
        /// </summary>
        private void ClearDataFromTxtBoxes()
        {
            //clears the info from all the fields
            this.BarcodeTxtBox.ResetText();
            this.ProductNameTxtBox.ResetText();
            this.OriginalPriceTxtBox.ResetText();
            this.SalesPriceTxtBox.ResetText();
            this.QuantityTxtBox.ResetText();
            this.SecondHandCheckBox.Checked = false;
        }

        /// <summary>
        /// Paste all the info from the given object
        /// </summary>
        /// <param name="Item"></param>
        private void PasteItemInfo(Items Item)
        {
            //Paste the info from the class to the form
            this.BarcodeTxtBox.Text = Item.Id;
            this.ProductNameTxtBox.Text = Item.ProductName;
            this.OriginalPriceTxtBox.Text = Item.OriginalPrice.ToString();
            this.SalesPriceTxtBox.Text = Item.SalesPrice.ToString();
            this.QuantityTxtBox.Text = Item.Quantity.ToString();
            this.SecondHandCheckBox.Checked = this.updateCreateSalesReportBLL.IsChecked(Item.Status);
            this.CreateBut.Text = "Save";

        }

        /// <summary>
        /// Gets the from the field and converts it to object
        /// </summary>
        /// <returns>Item object</returns>
        private Items ToClass()
        {
            //Gets the from the field and converts it to class
            Items item = new Items()
            {
                Id = this.BarcodeTxtBox.Text,
                ProductName = this.ProductNameTxtBox.Text,
                OriginalPrice = double.Parse(this.OriginalPriceTxtBox.Text),
                SalesPrice = double.Parse(this.SalesPriceTxtBox.Text),
                Quantity = int.Parse(this.QuantityTxtBox.Text),
                Status = this.updateCreateSalesReportBLL.StatusText(this.SecondHandCheckBox.Checked)
            };
            return item;
        }

        /// <summary>
        /// Validates the given information by the user 
        /// </summary>
        /// <param name="Barcode"></param>
        /// <param name="ProductName"></param>
        /// <param name="OriginalPrice"></param>
        /// <param name="SalesPrice"></param>
        /// <param name="Quantity"></param>
        /// <returns>If all its validated correctly returns true </returns>
        private bool Validate(string Barcode, string ProductName, string OriginalPrice,
            string SalesPrice, string Quantity)
        {
            bool IsInvalid = false;

            if (Barcode.Length < 8)
            {
                this.InvalidBarcodeLbl.Visible = true;
                IsInvalid = true;
            }
            else
            {
                this.InvalidBarcodeLbl.Visible = false;
            }

            if (ProductName.Length < 3)
            {
                this.InvalidProductNameLbl.Visible = true;
                IsInvalid = true;
            }
            else
            {
                this.InvalidProductNameLbl.Visible = false;
            }

            if (OriginalPrice == String.Empty)
            {
                this.InvalidOriginalPriceLbl.Visible = true;
                IsInvalid = true;
            }
            else
            {
                this.InvalidOriginalPriceLbl.Visible = false;
            }

            if (SalesPrice == String.Empty)
            {
                this.InvalidSalesPriceLbl.Visible = true;
                IsInvalid = true;
            }
            else
            {
                this.InvalidSalesPriceLbl.Visible = false;
            }

            if (Quantity == String.Empty)
            {
                this.InvalidQuantityLbl.Visible = true;
                IsInvalid = true;
            }
            else
            {
                this.InvalidQuantityLbl.Visible = false;
            }

            return IsInvalid;
        }

        private void BarcodeTxtBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = ProductNameTxtBox;
                ProductNameTxtBox.Focus();
            }
        }
    }
}
