using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HardwareStore.BusinessLogic;
using HardwareStore.Models;

namespace HardwareStore.View
{
    public partial class PayForm : Form
    {
        //this should be not here
        List<CartItem> cartItems;
        InvoiceBLL InvoiceBLL;

        public PayForm(List<CartItem> cartItems)
        {
            InitializeComponent();
            this.cartItems = cartItems;
            this.TotalTxtBox.Text = $"{cartItems.Sum(a => a.Total):f2}";//Sets text
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//Disables resizing 
            this.InvoiceBLL = new InvoiceBLL();
        }

        private void EndTransactionBut_Click(object sender, EventArgs e)
        {
            double CashAmount = double.Parse(this.CashAmountTxtBox.Text);
            double TotalPrice = double.Parse(this.TotalTxtBox.Text);
            if (CashAmount >= TotalPrice)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to end the transaction?","Message"
                      , MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        this.InvalidCashAmountLbl.Visible = false;
                        this.ChangeTxtBox.Text = $"{this.InvoiceBLL.SaveInvoice(this.cartItems, this.CashAmountTxtBox.Text):f2}";
                        //Save Invoice
                        this.EndTransactionBut.Enabled = false;
                        //Closes the certain form
                        break;
                    case DialogResult.No:
                        break;
                }
                
            }
            else
            {
                this.InvalidCashAmountLbl.Visible = true;
            }
        }

        private void RemoveCharIfNeeded(string Number)
        {
            if (this.CashAmountTxtBox.Text == "0")
            {
                CashAmountTxtBox.Text = Number;
            }
            else
            {
                CashAmountTxtBox.Text += Number;
            }
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            if (this.CashAmountTxtBox.Text.Length > 0 && this.CashAmountTxtBox.Text != "0")
            {
                this.CashAmountTxtBox.Text = CashAmountTxtBox.Text.Remove(CashAmountTxtBox.Text.Length - 1);
            }
            if (this.CashAmountTxtBox.Text.Length == 0)
            {
                this.CashAmountTxtBox.Text = "0";
            }
        }

        private void OneBut_Click(object sender, EventArgs e)
        {
            RemoveCharIfNeeded(OneBut.Text);  //Adds the digit to textbox
        }

        private void TwoBut_Click(object sender, EventArgs e)
        {
            RemoveCharIfNeeded(TwoBut.Text); //Adds the digit to textbox
        }

        private void ThreeBut_Click(object sender, EventArgs e)
        {
            RemoveCharIfNeeded(ThreeBut.Text); //Adds the digit to textbox
        }

        private void FourBut_Click(object sender, EventArgs e)
        {
            RemoveCharIfNeeded(FourBut.Text); //Adds the digit to textbox
        }

        private void FiveBut_Click(object sender, EventArgs e)
        {
            RemoveCharIfNeeded(FiveBut.Text); //Adds the digit to textbox
        }

        private void SixBut_Click(object sender, EventArgs e)
        {
            RemoveCharIfNeeded(SixBut.Text); //Adds the digit to textbox
        }

        private void SevenBut_Click(object sender, EventArgs e)
        {
            RemoveCharIfNeeded(SevenBut.Text); //Adds the digit to textbox
        }

        private void EightBut_Click(object sender, EventArgs e)
        {
            RemoveCharIfNeeded(EightBut.Text); //Adds the digit to textbox
        }

        private void NineBut_Click(object sender, EventArgs e)
        {
            RemoveCharIfNeeded(NineBut.Text); //Adds the digit to textbox
        }

        private void DoubleZeroBut_Click(object sender, EventArgs e)
        {
            RemoveCharIfNeeded(DoubleZeroBut.Text); //Adds the digit to textbox
        }

        private void ComaBut_Click(object sender, EventArgs e)
        {
            CashAmountTxtBox.Text += ComaBut.Text; //Adds the digit to textbox
        }

        private void ZeroBut_Click(object sender, EventArgs e)
        {
            RemoveCharIfNeeded(ZeroBut.Text); //Adds the digit to textbox
        }

        private void AllHundred_Click(object sender, EventArgs e)
        {
            CashAmountTxtBox.Text = (int.Parse(CashAmountTxtBox.Text) + 100).ToString();
        }

        private void AllFifty_Click(object sender, EventArgs e)
        {
            CashAmountTxtBox.Text = (int.Parse(CashAmountTxtBox.Text) + 50).ToString();

        }

        private void AllTwenty_Click(object sender, EventArgs e)
        {
            CashAmountTxtBox.Text = (int.Parse(CashAmountTxtBox.Text) + 20).ToString();

        }

        private void AllTen_Click(object sender, EventArgs e)
        {
            CashAmountTxtBox.Text = (int.Parse(CashAmountTxtBox.Text) + 10).ToString();

        }

        private void AllFive_Click(object sender, EventArgs e)
        {
            CashAmountTxtBox.Text = (int.Parse(CashAmountTxtBox.Text) + 5).ToString();

        }

        private void ShowRecipe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.InvoiceBLL.ShowRecipe());
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.CashAmountTxtBox.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
