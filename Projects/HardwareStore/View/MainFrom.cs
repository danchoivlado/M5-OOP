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

        /// <summary>
        /// Opens new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreInfoBut_Click(object sender, EventArgs e)
        {
            //Creates new form
            this.Store_Info = new StoreInfoForm();
            Store_Info.ShowDialog();
        }

        /// <summary>
        /// Opens new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewEmployeeBut_Click(object sender, EventArgs e)
        {
            //Creates new form
            this.RegisterForm = new RegisterForm();
            RegisterForm.ShowDialog();
        }

        /// <summary>
        /// Opens new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewInvoiceBut_Click(object sender, EventArgs e)
        {
            //Creates new form and closes the old one
            this.InvoiceFormL = new InvoiceForm();
            this.Hide();
            this.InvoiceFormL.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Opens new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreItemsPicBox_Click(object sender, EventArgs e)
        {
            //Creates new form
            this.StoreItemsForm = new StoreItemsForm();
            this.StoreItemsForm.ShowDialog();
        }

        /// <summary>
        /// Opens new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DailySalesBut_Click(object sender, EventArgs e)
        {
            //Creates new form
            this.SalesReportForm = new SalesReportForm();
            this.SalesReportForm.ShowDialog();
        }

        /// <summary>
        /// Opens new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemBut_Click(object sender, EventArgs e)
        {
            //Creates new form
            this.NewItemForm = new NewItemForm();
            this.NewItemForm.ShowDialog();
        }

        /// <summary>
        /// Changes the Picture when the mause moove or leave
        /// to create animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewInvoiceBut_MouseLeave(object sender, EventArgs e)
        {
            //Changes the image
            this.NewInvoiceBut.Image = HardwareStore.Properties.Resources.Black1;
        }

        /// <summary>
        /// Changes the Picture when the mause moove or leave
        /// to create animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewInvoiceBut_MouseMove(object sender, MouseEventArgs e)
        {
            //Changes the image
            this.NewInvoiceBut.Image = HardwareStore.Properties.Resources.Black2;
        }

        /// <summary>
        /// Changes the Picture when the mause moove or leave
        /// to create animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DailySalesBut_MouseLeave(object sender, EventArgs e)
        {
            //Changes the image
            this.DailySalesBut.Image = HardwareStore.Properties.Resources.Daily1;
        }

        /// <summary>
        /// Changes the Picture when the mause moove or leave
        /// to create animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DailySalesBut_MouseMove(object sender, MouseEventArgs e)
        {
            //Changes the image
            this.DailySalesBut.Image = HardwareStore.Properties.Resources.Daily2;
        }

        /// <summary>
        /// Changes the Picture when the mause moove or leave
        /// to create animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemBut_MouseLeave(object sender, EventArgs e)
        {
            //Changes the image
            this.AddItemBut.Image = HardwareStore.Properties.Resources.Item;
        }

        /// <summary>
        /// Changes the Picture when the mause moove or leave
        /// to create animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemBut_MouseMove(object sender, MouseEventArgs e)
        {
            //Changes the image
            this.AddItemBut.Image = HardwareStore.Properties.Resources.Item2;
        }

        /// <summary>
        /// Changes the Picture when the mause moove or leave
        /// to create animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreInfoBut_MouseLeave(object sender, EventArgs e)
        {
            //Changes the image
            this.StoreInfoBut.Image = HardwareStore.Properties.Resources.StoreInfo1;
        }

        /// <summary>
        /// Changes the Picture when the mause moove or leave
        /// to create animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreInfoBut_MouseMove(object sender, MouseEventArgs e)
        {
            //Changes the image
            this.StoreInfoBut.Image = HardwareStore.Properties.Resources.SoreInfo2;
        }

        /// <summary>
        /// Changes the Picture when the mause moove or leave
        /// to create animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewEmployeeBut_MouseMove(object sender, MouseEventArgs e)
        {
            //Changes the image
            this.NewEmployeeBut.Image = HardwareStore.Properties.Resources.Employee2;
        }

        /// <summary>
        /// Changes the Picture when the mause moove or leave
        /// to create animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewEmployeeBut_MouseLeave(object sender, EventArgs e)
        {
            //Changes the image
            this.NewEmployeeBut.Image = HardwareStore.Properties.Resources.Employees1;
        }

        /// <summary>
        /// Changes the Picture when the mause moove or leave
        /// to create animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            //Changes the image
            this.StoreItemsPicBox.Image = HardwareStore.Properties.Resources.Selected;
        }

        /// <summary>
        /// Changes the Picture when the mause moove or leave
        /// to create animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreItemsPicBox_MouseLeave(object sender, EventArgs e)
        {
            //Changes the image
            this.StoreItemsPicBox.Image = HardwareStore.Properties.Resources.Not_Selected;
        }

        /// <summary>
        /// Changes the Picture when the mause moove or leave
        /// to create animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoPicBox_MouseMove(object sender, MouseEventArgs e)
        {
            this.LogoPicBox.Image = HardwareStore.Properties.Resources.Layer_logo_form;
        }

        /// <summary>
        /// Changes the Picture when the mause moove or leave
        /// to create animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoPicBox_MouseLeave(object sender, EventArgs e)
        {
            this.LogoPicBox.Image = HardwareStore.Properties.Resources.without;
        }
    }
}
