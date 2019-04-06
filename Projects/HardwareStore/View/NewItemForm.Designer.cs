namespace HardwareStore.View
{
    partial class NewItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItemForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SecondHandCheckBox = new System.Windows.Forms.CheckBox();
            this.ProductNumberLbl = new System.Windows.Forms.Label();
            this.BarcodeLbl = new System.Windows.Forms.Label();
            this.SalesPriceLbl = new System.Windows.Forms.Label();
            this.OriginalPriceLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.BarcodeTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ProductNameTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.OriginalPriceTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SalesPriceTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.QuantityTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.CreateBut = new ePOSOne.btnProduct.Button_WOC();
            this.InvalidBarcodeLbl = new System.Windows.Forms.Label();
            this.InvalidProductNameLbl = new System.Windows.Forms.Label();
            this.InvalidOriginalPriceLbl = new System.Windows.Forms.Label();
            this.InvalidSalesPriceLbl = new System.Windows.Forms.Label();
            this.InvalidQuantityLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SecondHandCheckBox
            // 
            this.SecondHandCheckBox.AutoSize = true;
            this.SecondHandCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondHandCheckBox.ForeColor = System.Drawing.Color.Silver;
            this.SecondHandCheckBox.Location = new System.Drawing.Point(99, 491);
            this.SecondHandCheckBox.Name = "SecondHandCheckBox";
            this.SecondHandCheckBox.Size = new System.Drawing.Size(212, 37);
            this.SecondHandCheckBox.TabIndex = 16;
            this.SecondHandCheckBox.Text = "Second Hand";
            this.SecondHandCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProductNumberLbl
            // 
            this.ProductNumberLbl.AutoSize = true;
            this.ProductNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNumberLbl.ForeColor = System.Drawing.Color.Silver;
            this.ProductNumberLbl.Location = new System.Drawing.Point(93, 344);
            this.ProductNumberLbl.Name = "ProductNumberLbl";
            this.ProductNumberLbl.Size = new System.Drawing.Size(187, 31);
            this.ProductNumberLbl.TabIndex = 19;
            this.ProductNumberLbl.Text = "Product Name";
            // 
            // BarcodeLbl
            // 
            this.BarcodeLbl.AutoSize = true;
            this.BarcodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLbl.ForeColor = System.Drawing.Color.Silver;
            this.BarcodeLbl.Location = new System.Drawing.Point(93, 227);
            this.BarcodeLbl.Name = "BarcodeLbl";
            this.BarcodeLbl.Size = new System.Drawing.Size(115, 31);
            this.BarcodeLbl.TabIndex = 17;
            this.BarcodeLbl.Text = "Barcode";
            // 
            // SalesPriceLbl
            // 
            this.SalesPriceLbl.AutoSize = true;
            this.SalesPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesPriceLbl.ForeColor = System.Drawing.Color.Silver;
            this.SalesPriceLbl.Location = new System.Drawing.Point(584, 344);
            this.SalesPriceLbl.Name = "SalesPriceLbl";
            this.SalesPriceLbl.Size = new System.Drawing.Size(151, 31);
            this.SalesPriceLbl.TabIndex = 23;
            this.SalesPriceLbl.Text = "Sales Price";
            // 
            // OriginalPriceLbl
            // 
            this.OriginalPriceLbl.AutoSize = true;
            this.OriginalPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalPriceLbl.ForeColor = System.Drawing.Color.Silver;
            this.OriginalPriceLbl.Location = new System.Drawing.Point(584, 227);
            this.OriginalPriceLbl.Name = "OriginalPriceLbl";
            this.OriginalPriceLbl.Size = new System.Drawing.Size(176, 31);
            this.OriginalPriceLbl.TabIndex = 21;
            this.OriginalPriceLbl.Text = "Original Price";
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLbl.ForeColor = System.Drawing.Color.Silver;
            this.QuantityLbl.Location = new System.Drawing.Point(584, 454);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(116, 31);
            this.QuantityLbl.TabIndex = 25;
            this.QuantityLbl.Text = "Quantity";
            // 
            // BarcodeTxtBox
            // 
            this.BarcodeTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.BarcodeTxtBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.BarcodeTxtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.BarcodeTxtBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.BarcodeTxtBox.BorderThickness = 3;
            this.BarcodeTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BarcodeTxtBox.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.BarcodeTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.BarcodeTxtBox.isPassword = false;
            this.BarcodeTxtBox.Location = new System.Drawing.Point(99, 262);
            this.BarcodeTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.BarcodeTxtBox.Name = "BarcodeTxtBox";
            this.BarcodeTxtBox.Size = new System.Drawing.Size(319, 44);
            this.BarcodeTxtBox.TabIndex = 28;
            this.BarcodeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BarcodeTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarcodeTxtBox_KeyDown_1);
            // 
            // ProductNameTxtBox
            // 
            this.ProductNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ProductNameTxtBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.ProductNameTxtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.ProductNameTxtBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.ProductNameTxtBox.BorderThickness = 3;
            this.ProductNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductNameTxtBox.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.ProductNameTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.ProductNameTxtBox.isPassword = false;
            this.ProductNameTxtBox.Location = new System.Drawing.Point(99, 379);
            this.ProductNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductNameTxtBox.Name = "ProductNameTxtBox";
            this.ProductNameTxtBox.Size = new System.Drawing.Size(319, 44);
            this.ProductNameTxtBox.TabIndex = 29;
            this.ProductNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // OriginalPriceTxtBox
            // 
            this.OriginalPriceTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.OriginalPriceTxtBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.OriginalPriceTxtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.OriginalPriceTxtBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.OriginalPriceTxtBox.BorderThickness = 3;
            this.OriginalPriceTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OriginalPriceTxtBox.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.OriginalPriceTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.OriginalPriceTxtBox.isPassword = false;
            this.OriginalPriceTxtBox.Location = new System.Drawing.Point(590, 262);
            this.OriginalPriceTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.OriginalPriceTxtBox.Name = "OriginalPriceTxtBox";
            this.OriginalPriceTxtBox.Size = new System.Drawing.Size(133, 44);
            this.OriginalPriceTxtBox.TabIndex = 30;
            this.OriginalPriceTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SalesPriceTxtBox
            // 
            this.SalesPriceTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.SalesPriceTxtBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.SalesPriceTxtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.SalesPriceTxtBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.SalesPriceTxtBox.BorderThickness = 3;
            this.SalesPriceTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SalesPriceTxtBox.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.SalesPriceTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.SalesPriceTxtBox.isPassword = false;
            this.SalesPriceTxtBox.Location = new System.Drawing.Point(590, 379);
            this.SalesPriceTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.SalesPriceTxtBox.Name = "SalesPriceTxtBox";
            this.SalesPriceTxtBox.Size = new System.Drawing.Size(133, 44);
            this.SalesPriceTxtBox.TabIndex = 31;
            this.SalesPriceTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.QuantityTxtBox.Location = new System.Drawing.Point(590, 491);
            this.QuantityTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityTxtBox.Name = "QuantityTxtBox";
            this.QuantityTxtBox.Size = new System.Drawing.Size(133, 44);
            this.QuantityTxtBox.TabIndex = 32;
            this.QuantityTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateBut
            // 
            this.CreateBut.BorderColor = System.Drawing.Color.Silver;
            this.CreateBut.ButtonColor = System.Drawing.Color.SeaGreen;
            this.CreateBut.FlatAppearance.BorderSize = 0;
            this.CreateBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.CreateBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.CreateBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBut.Location = new System.Drawing.Point(319, 603);
            this.CreateBut.Name = "CreateBut";
            this.CreateBut.OnHoverBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CreateBut.OnHoverButtonColor = System.Drawing.Color.MediumSeaGreen;
            this.CreateBut.OnHoverTextColor = System.Drawing.Color.White;
            this.CreateBut.Size = new System.Drawing.Size(248, 63);
            this.CreateBut.TabIndex = 33;
            this.CreateBut.Text = "Create";
            this.CreateBut.TextColor = System.Drawing.Color.White;
            this.CreateBut.UseVisualStyleBackColor = true;
            this.CreateBut.Click += new System.EventHandler(this.CreateBut_Click_1);
            // 
            // InvalidBarcodeLbl
            // 
            this.InvalidBarcodeLbl.AutoSize = true;
            this.InvalidBarcodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidBarcodeLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidBarcodeLbl.Location = new System.Drawing.Point(94, 310);
            this.InvalidBarcodeLbl.Name = "InvalidBarcodeLbl";
            this.InvalidBarcodeLbl.Size = new System.Drawing.Size(319, 25);
            this.InvalidBarcodeLbl.TabIndex = 34;
            this.InvalidBarcodeLbl.Text = "Barcode must be at least 8 symbols";
            this.InvalidBarcodeLbl.Visible = false;
            // 
            // InvalidProductNameLbl
            // 
            this.InvalidProductNameLbl.AutoSize = true;
            this.InvalidProductNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidProductNameLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidProductNameLbl.Location = new System.Drawing.Point(94, 427);
            this.InvalidProductNameLbl.Name = "InvalidProductNameLbl";
            this.InvalidProductNameLbl.Size = new System.Drawing.Size(370, 25);
            this.InvalidProductNameLbl.TabIndex = 35;
            this.InvalidProductNameLbl.Text = "Product Name must be at least 3 symbols";
            this.InvalidProductNameLbl.Visible = false;
            // 
            // InvalidOriginalPriceLbl
            // 
            this.InvalidOriginalPriceLbl.AutoSize = true;
            this.InvalidOriginalPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidOriginalPriceLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidOriginalPriceLbl.Location = new System.Drawing.Point(585, 310);
            this.InvalidOriginalPriceLbl.Name = "InvalidOriginalPriceLbl";
            this.InvalidOriginalPriceLbl.Size = new System.Drawing.Size(109, 25);
            this.InvalidOriginalPriceLbl.TabIndex = 36;
            this.InvalidOriginalPriceLbl.Text = "Insert Price";
            this.InvalidOriginalPriceLbl.Visible = false;
            // 
            // InvalidSalesPriceLbl
            // 
            this.InvalidSalesPriceLbl.AutoSize = true;
            this.InvalidSalesPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidSalesPriceLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidSalesPriceLbl.Location = new System.Drawing.Point(591, 427);
            this.InvalidSalesPriceLbl.Name = "InvalidSalesPriceLbl";
            this.InvalidSalesPriceLbl.Size = new System.Drawing.Size(109, 25);
            this.InvalidSalesPriceLbl.TabIndex = 37;
            this.InvalidSalesPriceLbl.Text = "Insert Price";
            this.InvalidSalesPriceLbl.Visible = false;
            // 
            // InvalidQuantityLbl
            // 
            this.InvalidQuantityLbl.AutoSize = true;
            this.InvalidQuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidQuantityLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidQuantityLbl.Location = new System.Drawing.Point(591, 539);
            this.InvalidQuantityLbl.Name = "InvalidQuantityLbl";
            this.InvalidQuantityLbl.Size = new System.Drawing.Size(109, 25);
            this.InvalidQuantityLbl.TabIndex = 38;
            this.InvalidQuantityLbl.Text = "Insert Price";
            this.InvalidQuantityLbl.Visible = false;
            // 
            // NewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(839, 687);
            this.Controls.Add(this.InvalidQuantityLbl);
            this.Controls.Add(this.InvalidSalesPriceLbl);
            this.Controls.Add(this.InvalidOriginalPriceLbl);
            this.Controls.Add(this.InvalidProductNameLbl);
            this.Controls.Add(this.InvalidBarcodeLbl);
            this.Controls.Add(this.CreateBut);
            this.Controls.Add(this.QuantityTxtBox);
            this.Controls.Add(this.SalesPriceTxtBox);
            this.Controls.Add(this.OriginalPriceTxtBox);
            this.Controls.Add(this.ProductNameTxtBox);
            this.Controls.Add(this.BarcodeTxtBox);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.SalesPriceLbl);
            this.Controls.Add(this.OriginalPriceLbl);
            this.Controls.Add(this.ProductNumberLbl);
            this.Controls.Add(this.BarcodeLbl);
            this.Controls.Add(this.SecondHandCheckBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NewItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Item";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox SecondHandCheckBox;
        private System.Windows.Forms.Label ProductNumberLbl;
        private System.Windows.Forms.Label BarcodeLbl;
        private System.Windows.Forms.Label SalesPriceLbl;
        private System.Windows.Forms.Label OriginalPriceLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox BarcodeTxtBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox ProductNameTxtBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox OriginalPriceTxtBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox SalesPriceTxtBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox QuantityTxtBox;
        private ePOSOne.btnProduct.Button_WOC CreateBut;
        private System.Windows.Forms.Label InvalidBarcodeLbl;
        private System.Windows.Forms.Label InvalidProductNameLbl;
        private System.Windows.Forms.Label InvalidOriginalPriceLbl;
        private System.Windows.Forms.Label InvalidSalesPriceLbl;
        private System.Windows.Forms.Label InvalidQuantityLbl;
    }
}