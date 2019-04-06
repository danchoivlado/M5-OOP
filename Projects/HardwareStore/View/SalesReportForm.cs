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
    public partial class SalesReportForm : Form
    {
        UpdateCreateSalesReportBLL UpdateCreateSalesReport;
        List<DailySales> DailySalesList;

        public SalesReportForm()
        {
            InitializeComponent();
            this.UpdateCreateSalesReport = new UpdateCreateSalesReportBLL();
            UpdateGrid(); //Updates the DataGrid
            DesignConfigurator(); //Improves The design of the DataGrid
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//Disables Resizing
            this.TotalLbl.Text = $"{this.DailySalesList.Sum(a => a.Total):f2} лв";//Returns the Total money of the day
            this.ProfitLBL.Text = $"{this.UpdateCreateSalesReport.GenerateProfitOfTheDay(this.DailySalesList):f2} лв";
        }
        
        private void UpdateGrid()
        {
            this.DailySalesList = new List<DailySales>();
            this.DailySalesList = this.UpdateCreateSalesReport.SalesReprotInfo();
            SalesReportDataGrid.DataSource = DailySalesList;
            SalesReportDataGrid.ReadOnly = true;
            SalesReportDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
      
        private void DesignConfigurator()
        {
            SalesReportDataGrid.BorderStyle = BorderStyle.None;
            SalesReportDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            SalesReportDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SalesReportDataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            SalesReportDataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            SalesReportDataGrid.EnableHeadersVisualStyles = false;
            SalesReportDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            SalesReportDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            SalesReportDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            SalesReportDataGrid.Font = new Font("Arial", 16);
            SalesReportDataGrid.RowTemplate.Height = 40;
        }

    }
}
