using HardwareStore.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareStore.View
{
    public partial class InvoiceForm : Form
    {
        List<CartItem> cartItems;
        PayForm PayForm;
        MainFrom MainFrom;
        InvoiceBLL InvoiceBLL;
        private int InvoiceCount;
        public InvoiceForm()
        {
            InitializeComponent();
            this.cartItems = new List<CartItem>();
            this.InvoiceBLL = new InvoiceBLL();
            this.InvoiceCount = this.InvoiceBLL.InvoiceCount();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//Disables Resizing
            DesignConfigurator();//Improves DataGride design
            this.ActiveControl = this.ScanBarcodeTxtBox;
            GenrateCustomerInfoListBox();
        }

        private void GenrateCustomerInfoListBox()
        {
            //Sets info for the listbox
            this.CustomerInfoTxtList.Items.Add($"Item Single Price           {0:f2}");
            this.CustomerInfoTxtList.Items.Add($"Item Quantity                {0}");
            this.CustomerInfoTxtList.Items.Add($"Item Total                      {0:f2}");
            this.CustomerInfoTxtList.Items.Add("");
            this.CustomerInfoTxtList.Items.Add($"Grand Total                    {(cartItems.Sum(a => a.Total)):f2}");
            this.CustomerInfoTxtList.SelectionMode = SelectionMode.None;
        }

        private void NextItemBut_Click(object sender, EventArgs e)
        {
            if (!Validate(this.ScanBarcodeTxtBox.Text, int.Parse(this.QuantityTxtBox.Text)))
            {
                CartItem Item = this.cartItems.FirstOrDefault(a => a.Barcode == this.ScanBarcodeTxtBox.Text);
                if (Item != null)//Item exists in list
                {
                    this.cartItems.Find(a => a.Barcode == this.ScanBarcodeTxtBox.Text).
                        Quantity += int.Parse(this.QuantityTxtBox.Text);
                    //Updates quantity

                    this.cartItems.Find(a => a.Barcode == this.ScanBarcodeTxtBox.Text).
                        Total += int.Parse(this.QuantityTxtBox.Text) * Item.SinglePrice;
                    //Updates total

                    UpdateTextbox(Item);//Update the textbox

                }
                else
                {
                    CartItem NewItem = new CartItem(this.ScanBarcodeTxtBox.Text, this.QuantityTxtBox.Text);
                    this.cartItems.Add(NewItem);
                    //Adds Item to list

                    UpdateTextbox(NewItem);
                }
                this.ItemsDataGrid.DataSource = this.cartItems.ToList();
                ItemsDataGrid.Columns[2].Width = 185;
            }
        }

        private void UpdateTextbox(CartItem Item)
        {
            //Updates info for the listbox
            this.CustomerInfoTxtList.Items[0] = $"Item Single Price           {Item.SinglePrice:f2}";
            this.CustomerInfoTxtList.Items[1] = $"Item Quantity                {Item.Quantity}";
            this.CustomerInfoTxtList.Items[2] = $"Item Total                      {Item.Total:f2}";
            this.CustomerInfoTxtList.Items[4] = $"Grand Total                    {(cartItems.Sum(a => a.Total)):f2}";
        }




        private void DesignConfigurator()
        {
            ItemsDataGrid.BorderStyle = BorderStyle.None;
            ItemsDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ItemsDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ItemsDataGrid.DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen;
            ItemsDataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ItemsDataGrid.EnableHeadersVisualStyles = false;
            ItemsDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ItemsDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ItemsDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ItemsDataGrid.ReadOnly = true;
            ItemsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemsDataGrid.Font = new Font("Arial", 20);
            ItemsDataGrid.RowTemplate.Height = 50;

            this.QuantityTxtBox.Text = "1";
        }

        private void PayBut_Click(object sender, EventArgs e)
        {
            this.InvalidBarcodeLbl.Visible = false;
            if (this.ItemsDataGrid.RowCount > 0)
            {
                if (this.cartItems.Any(a => a.Quantity <= 0))//Checks for zero quantity
                {
                    this.InvalidItemQuantyLbl.Visible = true;
                }
                else
                {
                    this.InvalidItemsLbl.Visible = false;
                    this.PayForm = new PayForm(this.cartItems);//Open new form
                    this.PayForm.ShowDialog();
                    this.InvalidItemQuantyLbl.Visible = false;
                }

            }
            else
                this.InvalidItemsLbl.Visible = true;
        }

        private void DeleteItemBut_Click(object sender, EventArgs e)
        {
            //Deletes Selected Item
            if (this.ItemsDataGrid.RowCount > 0)//Checks if selected
            {
                var SelectedRow = ItemsDataGrid.SelectedRows[0].Cells;//Keeps Index of the selected row
                var SelectedItem = SelectedRow[0].Value.ToString();
                CartItem ItemToDelete = this.cartItems.First(a => a.Barcode == SelectedItem);
                //Keeps item info
                this.cartItems.Remove(ItemToDelete);
                this.ItemsDataGrid.DataSource = this.cartItems.ToList();
                this.InvalidItemsLbl.Visible = false;

                if (this.cartItems.Count < 1)
                {
                    UpdateTextbox(new CartItem());
                }
                else
                {
                    UpdateTextbox(this.cartItems.Last());
                }
            }
            else
                this.InvalidItemsLbl.Visible = true;
        }

        private void ChangeQuantityBut_Click(object sender, EventArgs e)
        {
            if (this.ItemsDataGrid.RowCount > 0)//If Selected  
            {
                int SelectedRowIndex = this.ItemsDataGrid.CurrentCell.RowIndex;//Keeps Index of the selected row
                var SelectedRow = ItemsDataGrid.SelectedRows[0].Cells;
                var SelectedRowBarcode = SelectedRow[0].Value.ToString();//Keeps the barcode
                CartItem Item = this.cartItems.First(a => a.Barcode == SelectedRowBarcode);
                //Gets the item from the list
                Item.QuantityMinus();//Decreases the quantity by 1
                this.ItemsDataGrid.DataSource = this.cartItems.ToList();
                ItemsDataGrid.CurrentCell = ItemsDataGrid.Rows[SelectedRowIndex].Cells[0];
                this.InvalidItemsLbl.Visible = false;

                UpdateTextbox(Item);
            }
            else
                this.InvalidItemsLbl.Visible = true;
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            //Returns to main menu
            this.MainFrom = new MainFrom();
            this.Hide();
            this.MainFrom.ShowDialog();
            this.Close();
        }

        private void QuantityPlusBut_Click(object sender, EventArgs e)
        {
            if (this.ItemsDataGrid.RowCount > 0) //If Selected  
            {
                int SelectedRowIndex = this.ItemsDataGrid.CurrentCell.RowIndex; //Keeps Index of the selected row
                var SelectedRow = ItemsDataGrid.SelectedRows[0].Cells;
                var SelectedRowBarcode = SelectedRow[0].Value.ToString();//Keeps the barcode
                CartItem Item = this.cartItems.First(a => a.Barcode == SelectedRowBarcode);
                //Gets the item from the list
                Item.QuantityPlus(); //Increases the quantity by 1
                this.ItemsDataGrid.DataSource = this.cartItems.ToList();
                ItemsDataGrid.CurrentCell = ItemsDataGrid.Rows[SelectedRowIndex].Cells[0];
                this.InvalidItemsLbl.Visible = false;

                UpdateTextbox(Item);
            }
            else
                this.InvalidItemsLbl.Visible = true;
        }

        private void ScanBarcodeTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Performs click when key enter is registered
            if (e.KeyCode == Keys.Enter)
            {
                if (!Validate(this.ScanBarcodeTxtBox.Text, int.Parse(this.QuantityTxtBox.Text)))
                {
                    this.NextItemBut.PerformClick();
                    this.ScanBarcodeTxtBox.ResetText();
                    this.QuantityTxtBox.Text = "1";
                }
            }
        }

        private bool Validate(string Barcode, int Quantity)
        {
            //Checks for invalid fields
            bool IsInvalid = false;

            if (this.InvoiceBLL.HasNotItem(Barcode))
            {
                this.InvalidBarcodeLbl.Visible = true;
                IsInvalid = true;
            }
            else
            {
                this.InvalidBarcodeLbl.Visible = false;
            }

            if (Quantity < 1 || Quantity > 200)
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

        private void InvoiceForm_Activated(object sender, EventArgs e)
        {
            if (this.InvoiceCount != this.InvoiceBLL.InvoiceCount())
            {
                this.cartItems.Clear();
                this.ItemsDataGrid.DataSource = this.cartItems.ToList();
                UpdateTextbox(new CartItem());
                this.ScanBarcodeTxtBox.ResetText();
                this.ActiveControl = ScanBarcodeTxtBox;
                ScanBarcodeTxtBox.Focus();
                this.InvoiceCount = this.InvoiceBLL.InvoiceCount();
            }
        }
    }

}
