using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;


namespace HardwareStore.View
{
    public partial class MainFrom : Form
    {
        StoreInfoForm Store_Info;
        RegisterForm RegisterForm;
        NewItemForm NewItemForm;
        StoreItemsForm StoreItemsForm;
        SalesReportForm SalesReportForm;
        InvoiceForm InvoiceFormL;


        public MainFrom()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//Disbles resizing
        }

        private void StoreInfoBut_Click(object sender, EventArgs e)
        {
            //Creates new form
            this.Store_Info = new StoreInfoForm();
            Store_Info.ShowDialog();
        }

        private void NewEmployeeBut_Click(object sender, EventArgs e)
        {
            //Creates new form
            this.RegisterForm = new RegisterForm();
            RegisterForm.ShowDialog();
        }

        private void NewInvoiceBut_Click(object sender, EventArgs e)
        {
            //Creates new form and closes the old one
            this.InvoiceFormL = new InvoiceForm();
            this.Hide();
            this.InvoiceFormL.ShowDialog();
            this.Close();
        }

        private void StoreItemsPicBox_Click(object sender, EventArgs e)
        {
            //Creates new form
            this.StoreItemsForm = new StoreItemsForm();
            this.StoreItemsForm.ShowDialog();
        }

        private void DailySalesBut_Click(object sender, EventArgs e)
        {
            //Creates new form
            this.SalesReportForm = new SalesReportForm();
            this.SalesReportForm.ShowDialog();
        }

        private void AddItemBut_Click(object sender, EventArgs e)
        {
            //Creates new form
            this.NewItemForm = new NewItemForm();
            this.NewItemForm.ShowDialog();
        }

        private void NewInvoiceBut_MouseLeave(object sender, EventArgs e)
        {
            //Changes the image
            this.NewInvoiceBut.Image = HardwareStore.Properties.Resources.Black1;
        }

        private void NewInvoiceBut_MouseMove(object sender, MouseEventArgs e)
        {
            //Changes the image
            this.NewInvoiceBut.Image = HardwareStore.Properties.Resources.Black2;
        }

        private void DailySalesBut_MouseLeave(object sender, EventArgs e)
        {
            //Changes the image
            this.DailySalesBut.Image = HardwareStore.Properties.Resources.Daily1;
        }

        private void DailySalesBut_MouseMove(object sender, MouseEventArgs e)
        {
            //Changes the image
            this.DailySalesBut.Image = HardwareStore.Properties.Resources.Daily2;
        }

        private void AddItemBut_MouseLeave(object sender, EventArgs e)
        {
            //Changes the image
            this.AddItemBut.Image = HardwareStore.Properties.Resources.Item;
        }

        private void AddItemBut_MouseMove(object sender, MouseEventArgs e)
        {
            //Changes the image
            this.AddItemBut.Image = HardwareStore.Properties.Resources.Item2;
        }

        private void StoreInfoBut_MouseLeave(object sender, EventArgs e)
        {
            //Changes the image
            this.StoreInfoBut.Image = HardwareStore.Properties.Resources.StoreInfo1;
        }

        private void StoreInfoBut_MouseMove(object sender, MouseEventArgs e)
        {
            //Changes the image
            this.StoreInfoBut.Image = HardwareStore.Properties.Resources.SoreInfo2;
        }

        private void NewEmployeeBut_MouseMove(object sender, MouseEventArgs e)
        {
            //Changes the image
            this.NewEmployeeBut.Image = HardwareStore.Properties.Resources.Employee2;
        }

        private void NewEmployeeBut_MouseLeave(object sender, EventArgs e)
        {
            //Changes the image
            this.NewEmployeeBut.Image = HardwareStore.Properties.Resources.Employees1;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            //Changes the image
            this.StoreItemsPicBox.Image = HardwareStore.Properties.Resources.Selected;
        }

        private void StoreItemsPicBox_MouseLeave(object sender, EventArgs e)
        {
            //Changes the image
            this.StoreItemsPicBox.Image = HardwareStore.Properties.Resources.Not_Selected;
        }

        private void LogoPicBox_MouseMove(object sender, MouseEventArgs e)
        {
            this.LogoPicBox.Image = HardwareStore.Properties.Resources.Layer_logo_form;
        }

        private void LogoPicBox_MouseLeave(object sender, EventArgs e)
        {
            this.LogoPicBox.Image = HardwareStore.Properties.Resources.without;
        }
    }
}
