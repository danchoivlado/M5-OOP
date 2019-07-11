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
    public partial class StoreItemsForm : Form
    {
        UpdateCreateSalesReportBLL UpdateCreateSalesReport;
        NewItemForm NewItemForm;
        Items item = new Items();

        public StoreItemsForm()
        {
            InitializeComponent();
            this.UpdateCreateSalesReport = new UpdateCreateSalesReportBLL();
            UpdateGrid();
            //Updates the info of the DataGrid
            DesignConfigurator();
            //Improves the design of the DataGrid
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//Disables Resizing
        }

        /// <summary>
        /// Make the improved design of the DataGrid
        /// </summary>
        private void DesignConfigurator()
        {
            ItemsGridView.BorderStyle = BorderStyle.None;
            ItemsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ItemsGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ItemsGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            ItemsGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ItemsGridView.EnableHeadersVisualStyles = false;
            ItemsGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ItemsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ItemsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ItemsGridView.Font = new Font("Arial", 16);
            ItemsGridView.RowTemplate.Height = 39;

        }

        /// <summary>
        /// Opens NewItem form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateBut_Click(object sender, EventArgs e)
        {
            var form1 = new NewItemForm();
            form1.ShowDialog();
        }

        private void UpdateGrid()
        {
            ItemsGridView.DataSource = this.UpdateCreateSalesReport.GetAllInfo().ToList();
            ItemsGridView.ReadOnly = true;
            ItemsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemsGridView.Columns[ItemsGridView.ColumnCount - 1].Visible = false;
            //Hides the last Column 
        }

        /// <summary>
        /// Opens NewItem form and get ready for update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBut_Click(object sender, EventArgs e)
        {
            if (ItemsGridView.SelectedRows.Count == 1) //If selected
            {
                var item = ItemsGridView.SelectedRows[0].Cells;
                var id = item[0].Value.ToString();
                Items Item = this.UpdateCreateSalesReport.GetAllInfo().First(a => a.Id == id); 
                //gets the info of selected item
                this.item = Item;
                this.NewItemForm = new NewItemForm(Item); //opens the NewItemForm with loaded info
                NewItemForm.Hide();
                this.NewItemForm.ShowDialog();
                this.Close();
            }

        }
        private void RegisterBut_Click(object sender, EventArgs e)
        {
            this.NewItemForm = new NewItemForm();
            NewItemForm.Show();
        }

        /// <summary>
        /// Delete the selected item form the DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBut_Click(object sender, EventArgs e)
        {
            if (ItemsGridView.SelectedRows.Count == 1)
            {
                var item = ItemsGridView.SelectedRows[0].Cells;
                var id = item[0].Value.ToString();
                this.UpdateCreateSalesReport.Delete(id);
            }
            UpdateGrid();
        }

        /// <summary>
        /// Updates the grid when form Focused
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreItemsForm_Activated(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
