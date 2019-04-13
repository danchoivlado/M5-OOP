namespace HardwareStore.View
{
    partial class SalesReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SalesReportDataGrid = new System.Windows.Forms.DataGridView();
            this.GrantTotalLbl = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.ProfitLBL = new System.Windows.Forms.Label();
            this.DailyProfitLbl = new System.Windows.Forms.Label();
            this.SalesReportComboBox = new System.Windows.Forms.ComboBox();
            this.PickLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesReportDataGrid
            // 
            this.SalesReportDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesReportDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.SalesReportDataGrid.Location = new System.Drawing.Point(11, 153);
            this.SalesReportDataGrid.Name = "SalesReportDataGrid";
            this.SalesReportDataGrid.RowTemplate.Height = 24;
            this.SalesReportDataGrid.Size = new System.Drawing.Size(1071, 276);
            this.SalesReportDataGrid.TabIndex = 0;
            // 
            // GrantTotalLbl
            // 
            this.GrantTotalLbl.AutoSize = true;
            this.GrantTotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrantTotalLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrantTotalLbl.Location = new System.Drawing.Point(12, 452);
            this.GrantTotalLbl.Name = "GrantTotalLbl";
            this.GrantTotalLbl.Size = new System.Drawing.Size(169, 33);
            this.GrantTotalLbl.TabIndex = 1;
            this.GrantTotalLbl.Text = "Grand Total";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalLbl.Location = new System.Drawing.Point(884, 452);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(0, 33);
            this.TotalLbl.TabIndex = 2;
            // 
            // ProfitLBL
            // 
            this.ProfitLBL.AutoSize = true;
            this.ProfitLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfitLBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProfitLBL.Location = new System.Drawing.Point(884, 509);
            this.ProfitLBL.Name = "ProfitLBL";
            this.ProfitLBL.Size = new System.Drawing.Size(0, 33);
            this.ProfitLBL.TabIndex = 4;
            // 
            // DailyProfitLbl
            // 
            this.DailyProfitLbl.AutoSize = true;
            this.DailyProfitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyProfitLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DailyProfitLbl.Location = new System.Drawing.Point(12, 509);
            this.DailyProfitLbl.Name = "DailyProfitLbl";
            this.DailyProfitLbl.Size = new System.Drawing.Size(180, 33);
            this.DailyProfitLbl.TabIndex = 3;
            this.DailyProfitLbl.Text = "Profit Of The";
            // 
            // SalesReportComboBox
            // 
            this.SalesReportComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SalesReportComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReportComboBox.FormattingEnabled = true;
            this.SalesReportComboBox.Items.AddRange(new object[] {
            "Yearly Sales Report",
            "Monthly Sales Report",
            "Daily Sales Report"});
            this.SalesReportComboBox.Location = new System.Drawing.Point(851, 80);
            this.SalesReportComboBox.Name = "SalesReportComboBox";
            this.SalesReportComboBox.Size = new System.Drawing.Size(218, 33);
            this.SalesReportComboBox.TabIndex = 5;
            this.SalesReportComboBox.SelectedValueChanged += new System.EventHandler(this.SalesReportComboBox_SelectedValueChanged);
            // 
            // PickLabel
            // 
            this.PickLabel.AutoSize = true;
            this.PickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PickLabel.Location = new System.Drawing.Point(802, 29);
            this.PickLabel.Name = "PickLabel";
            this.PickLabel.Size = new System.Drawing.Size(280, 33);
            this.PickLabel.TabIndex = 6;
            this.PickLabel.Text = "Select Sales Report ";
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1094, 571);
            this.Controls.Add(this.PickLabel);
            this.Controls.Add(this.SalesReportComboBox);
            this.Controls.Add(this.ProfitLBL);
            this.Controls.Add(this.DailyProfitLbl);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.GrantTotalLbl);
            this.Controls.Add(this.SalesReportDataGrid);
            this.MaximizeBox = false;
            this.Name = "SalesReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesReportDataGrid;
        private System.Windows.Forms.Label GrantTotalLbl;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label ProfitLBL;
        private System.Windows.Forms.Label DailyProfitLbl;
        private System.Windows.Forms.ComboBox SalesReportComboBox;
        private System.Windows.Forms.Label PickLabel;
    }
}