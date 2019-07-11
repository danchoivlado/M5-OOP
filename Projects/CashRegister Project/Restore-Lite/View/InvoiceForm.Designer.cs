namespace HardwareStore.View
{
    partial class InvoiceForm
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
            this.ItemsDataGrid = new System.Windows.Forms.DataGridView();
            this.ScanBarcodeLbl = new System.Windows.Forms.Label();
            this.ScanBarcodeTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.QuantityTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.CustomerInfoTxtList = new System.Windows.Forms.ListBox();
            this.PayBut = new System.Windows.Forms.Button();
            this.DeleteItemBut = new System.Windows.Forms.Button();
            this.QuantityMinusBut = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.QuantityPlusBut = new System.Windows.Forms.Button();
            this.InvalidQuantityLbl = new System.Windows.Forms.Label();
            this.InvalidBarcodeLbl = new System.Windows.Forms.Label();
            this.InvalidItemsLbl = new System.Windows.Forms.Label();
            this.InvalidItemQuantyLbl = new System.Windows.Forms.Label();
            this.NextItemBut = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsDataGrid
            // 
            this.ItemsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsDataGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.ItemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGrid.Location = new System.Drawing.Point(25, 194);
            this.ItemsDataGrid.Name = "ItemsDataGrid";
            this.ItemsDataGrid.RowHeadersWidth = 50;
            this.ItemsDataGrid.RowTemplate.Height = 24;
            this.ItemsDataGrid.Size = new System.Drawing.Size(648, 681);
            this.ItemsDataGrid.TabIndex = 0;
            // 
            // ScanBarcodeLbl
            // 
            this.ScanBarcodeLbl.AutoSize = true;
            this.ScanBarcodeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ScanBarcodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanBarcodeLbl.ForeColor = System.Drawing.Color.White;
            this.ScanBarcodeLbl.Location = new System.Drawing.Point(18, 72);
            this.ScanBarcodeLbl.Name = "ScanBarcodeLbl";
            this.ScanBarcodeLbl.Size = new System.Drawing.Size(231, 39);
            this.ScanBarcodeLbl.TabIndex = 2;
            this.ScanBarcodeLbl.Text = "Scan Barcode";
            // 
            // ScanBarcodeTxtBox
            // 
            this.ScanBarcodeTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ScanBarcodeTxtBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.ScanBarcodeTxtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.ScanBarcodeTxtBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.ScanBarcodeTxtBox.BorderThickness = 3;
            this.ScanBarcodeTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScanBarcodeTxtBox.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.ScanBarcodeTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.ScanBarcodeTxtBox.isPassword = false;
            this.ScanBarcodeTxtBox.Location = new System.Drawing.Point(25, 115);
            this.ScanBarcodeTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.ScanBarcodeTxtBox.Name = "ScanBarcodeTxtBox";
            this.ScanBarcodeTxtBox.Size = new System.Drawing.Size(297, 44);
            this.ScanBarcodeTxtBox.TabIndex = 29;
            this.ScanBarcodeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScanBarcodeTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScanBarcodeTxtBox_KeyDown);
            // 
            // QuantityTxtBox
            // 
            this.QuantityTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.QuantityTxtBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.QuantityTxtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.QuantityTxtBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.QuantityTxtBox.BorderThickness = 3;
            this.QuantityTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityTxtBox.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.QuantityTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.QuantityTxtBox.isPassword = false;
            this.QuantityTxtBox.Location = new System.Drawing.Point(344, 115);
            this.QuantityTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityTxtBox.Name = "QuantityTxtBox";
            this.QuantityTxtBox.Size = new System.Drawing.Size(178, 44);
            this.QuantityTxtBox.TabIndex = 31;
            this.QuantityTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLbl.ForeColor = System.Drawing.Color.White;
            this.QuantityLbl.Location = new System.Drawing.Point(337, 72);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(143, 39);
            this.QuantityLbl.TabIndex = 30;
            this.QuantityLbl.Text = "Quantity";
            // 
            // CustomerInfoTxtList
            // 
            this.CustomerInfoTxtList.BackColor = System.Drawing.SystemColors.MenuText;
            this.CustomerInfoTxtList.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInfoTxtList.ForeColor = System.Drawing.Color.Green;
            this.CustomerInfoTxtList.FormattingEnabled = true;
            this.CustomerInfoTxtList.ItemHeight = 51;
            this.CustomerInfoTxtList.Location = new System.Drawing.Point(704, 45);
            this.CustomerInfoTxtList.Name = "CustomerInfoTxtList";
            this.CustomerInfoTxtList.Size = new System.Drawing.Size(551, 259);
            this.CustomerInfoTxtList.TabIndex = 35;
            // 
            // PayBut
            // 
            this.PayBut.BackColor = System.Drawing.Color.SeaGreen;
            this.PayBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PayBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PayBut.Location = new System.Drawing.Point(704, 310);
            this.PayBut.Name = "PayBut";
            this.PayBut.Size = new System.Drawing.Size(551, 72);
            this.PayBut.TabIndex = 36;
            this.PayBut.Text = "PAY";
            this.PayBut.UseVisualStyleBackColor = false;
            this.PayBut.Click += new System.EventHandler(this.PayBut_Click);
            // 
            // DeleteItemBut
            // 
            this.DeleteItemBut.BackColor = System.Drawing.Color.DarkGray;
            this.DeleteItemBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteItemBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteItemBut.ForeColor = System.Drawing.Color.Maroon;
            this.DeleteItemBut.Location = new System.Drawing.Point(1118, 418);
            this.DeleteItemBut.Name = "DeleteItemBut";
            this.DeleteItemBut.Size = new System.Drawing.Size(137, 118);
            this.DeleteItemBut.TabIndex = 37;
            this.DeleteItemBut.Text = "Delete Item";
            this.DeleteItemBut.UseVisualStyleBackColor = false;
            this.DeleteItemBut.Click += new System.EventHandler(this.DeleteItemBut_Click);
            // 
            // QuantityMinusBut
            // 
            this.QuantityMinusBut.BackColor = System.Drawing.Color.DarkGray;
            this.QuantityMinusBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuantityMinusBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityMinusBut.ForeColor = System.Drawing.Color.Black;
            this.QuantityMinusBut.Location = new System.Drawing.Point(911, 418);
            this.QuantityMinusBut.Name = "QuantityMinusBut";
            this.QuantityMinusBut.Size = new System.Drawing.Size(137, 118);
            this.QuantityMinusBut.TabIndex = 38;
            this.QuantityMinusBut.Text = "Quantity Minus";
            this.QuantityMinusBut.UseVisualStyleBackColor = false;
            this.QuantityMinusBut.Click += new System.EventHandler(this.ChangeQuantityBut_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.DarkGray;
            this.MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.ForeColor = System.Drawing.Color.Black;
            this.MainMenu.Location = new System.Drawing.Point(1118, 589);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(137, 118);
            this.MainMenu.TabIndex = 39;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // QuantityPlusBut
            // 
            this.QuantityPlusBut.BackColor = System.Drawing.Color.DarkGray;
            this.QuantityPlusBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuantityPlusBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityPlusBut.ForeColor = System.Drawing.Color.Black;
            this.QuantityPlusBut.Location = new System.Drawing.Point(704, 418);
            this.QuantityPlusBut.Name = "QuantityPlusBut";
            this.QuantityPlusBut.Size = new System.Drawing.Size(137, 118);
            this.QuantityPlusBut.TabIndex = 40;
            this.QuantityPlusBut.Text = "Quantity Plus";
            this.QuantityPlusBut.UseVisualStyleBackColor = false;
            this.QuantityPlusBut.Click += new System.EventHandler(this.QuantityPlusBut_Click);
            // 
            // InvalidQuantityLbl
            // 
            this.InvalidQuantityLbl.AutoSize = true;
            this.InvalidQuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidQuantityLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidQuantityLbl.Location = new System.Drawing.Point(339, 166);
            this.InvalidQuantityLbl.Name = "InvalidQuantityLbl";
            this.InvalidQuantityLbl.Size = new System.Drawing.Size(142, 25);
            this.InvalidQuantityLbl.TabIndex = 41;
            this.InvalidQuantityLbl.Text = "Invalid Quantty";
            this.InvalidQuantityLbl.Visible = false;
            // 
            // InvalidBarcodeLbl
            // 
            this.InvalidBarcodeLbl.AutoSize = true;
            this.InvalidBarcodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidBarcodeLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidBarcodeLbl.Location = new System.Drawing.Point(20, 163);
            this.InvalidBarcodeLbl.Name = "InvalidBarcodeLbl";
            this.InvalidBarcodeLbl.Size = new System.Drawing.Size(146, 25);
            this.InvalidBarcodeLbl.TabIndex = 42;
            this.InvalidBarcodeLbl.Text = "Invalid Barcode";
            this.InvalidBarcodeLbl.Visible = false;
            // 
            // InvalidItemsLbl
            // 
            this.InvalidItemsLbl.AutoSize = true;
            this.InvalidItemsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidItemsLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidItemsLbl.Location = new System.Drawing.Point(938, 385);
            this.InvalidItemsLbl.Name = "InvalidItemsLbl";
            this.InvalidItemsLbl.Size = new System.Drawing.Size(89, 25);
            this.InvalidItemsLbl.TabIndex = 43;
            this.InvalidItemsLbl.Text = "No Items";
            this.InvalidItemsLbl.Visible = false;
            // 
            // InvalidItemQuantyLbl
            // 
            this.InvalidItemQuantyLbl.AutoSize = true;
            this.InvalidItemQuantyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidItemQuantyLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidItemQuantyLbl.Location = new System.Drawing.Point(699, 548);
            this.InvalidItemQuantyLbl.Name = "InvalidItemQuantyLbl";
            this.InvalidItemQuantyLbl.Size = new System.Drawing.Size(328, 25);
            this.InvalidItemQuantyLbl.TabIndex = 44;
            this.InvalidItemQuantyLbl.Text = "Item Quantity Cannot Be Below Zero";
            this.InvalidItemQuantyLbl.Visible = false;
            // 
            // NextItemBut
            // 
            this.NextItemBut.BorderColor = System.Drawing.Color.Silver;
            this.NextItemBut.ButtonColor = System.Drawing.Color.SeaGreen;
            this.NextItemBut.FlatAppearance.BorderSize = 0;
            this.NextItemBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.NextItemBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.NextItemBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextItemBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextItemBut.Location = new System.Drawing.Point(540, 96);
            this.NextItemBut.Name = "NextItemBut";
            this.NextItemBut.OnHoverBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NextItemBut.OnHoverButtonColor = System.Drawing.Color.MediumSeaGreen;
            this.NextItemBut.OnHoverTextColor = System.Drawing.Color.White;
            this.NextItemBut.Size = new System.Drawing.Size(133, 63);
            this.NextItemBut.TabIndex = 34;
            this.NextItemBut.Text = "Next Item";
            this.NextItemBut.TextColor = System.Drawing.Color.White;
            this.NextItemBut.UseVisualStyleBackColor = true;
            this.NextItemBut.Click += new System.EventHandler(this.NextItemBut_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1282, 903);
            this.Controls.Add(this.InvalidItemQuantyLbl);
            this.Controls.Add(this.InvalidItemsLbl);
            this.Controls.Add(this.InvalidBarcodeLbl);
            this.Controls.Add(this.InvalidQuantityLbl);
            this.Controls.Add(this.QuantityPlusBut);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.QuantityMinusBut);
            this.Controls.Add(this.DeleteItemBut);
            this.Controls.Add(this.PayBut);
            this.Controls.Add(this.CustomerInfoTxtList);
            this.Controls.Add(this.NextItemBut);
            this.Controls.Add(this.QuantityTxtBox);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.ScanBarcodeTxtBox);
            this.Controls.Add(this.ScanBarcodeLbl);
            this.Controls.Add(this.ItemsDataGrid);
            this.MaximizeBox = false;
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Form";
            this.Activated += new System.EventHandler(this.InvoiceForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemsDataGrid;
        private System.Windows.Forms.Label ScanBarcodeLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox ScanBarcodeTxtBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox QuantityTxtBox;
        private System.Windows.Forms.Label QuantityLbl;
        private ePOSOne.btnProduct.Button_WOC NextItemBut;
        private System.Windows.Forms.ListBox CustomerInfoTxtList;
        private System.Windows.Forms.Button PayBut;
        private System.Windows.Forms.Button DeleteItemBut;
        private System.Windows.Forms.Button QuantityMinusBut;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button QuantityPlusBut;
        private System.Windows.Forms.Label InvalidQuantityLbl;
        private System.Windows.Forms.Label InvalidBarcodeLbl;
        private System.Windows.Forms.Label InvalidItemsLbl;
        private System.Windows.Forms.Label InvalidItemQuantyLbl;
    }
}