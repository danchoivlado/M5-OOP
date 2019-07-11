namespace HardwareStore.View
{
    partial class StoreInfoForm
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
            this.SaveBut = new ePOSOne.btnProduct.Button_WOC();
            this.StoreAddressLbl = new System.Windows.Forms.Label();
            this.StoreNameLbl = new System.Windows.Forms.Label();
            this.StoreInfoLbl = new System.Windows.Forms.Label();
            this.StoreNameTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.StoreAddressTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // SaveBut
            // 
            this.SaveBut.BorderColor = System.Drawing.Color.Silver;
            this.SaveBut.ButtonColor = System.Drawing.Color.SeaGreen;
            this.SaveBut.FlatAppearance.BorderSize = 0;
            this.SaveBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.SaveBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.SaveBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBut.Location = new System.Drawing.Point(193, 458);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.OnHoverBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveBut.OnHoverButtonColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveBut.OnHoverTextColor = System.Drawing.Color.White;
            this.SaveBut.Size = new System.Drawing.Size(177, 63);
            this.SaveBut.TabIndex = 11;
            this.SaveBut.Text = "Save";
            this.SaveBut.TextColor = System.Drawing.Color.White;
            this.SaveBut.UseVisualStyleBackColor = true;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click_1);
            // 
            // StoreAddressLbl
            // 
            this.StoreAddressLbl.AutoSize = true;
            this.StoreAddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreAddressLbl.ForeColor = System.Drawing.Color.Silver;
            this.StoreAddressLbl.Location = new System.Drawing.Point(100, 303);
            this.StoreAddressLbl.Name = "StoreAddressLbl";
            this.StoreAddressLbl.Size = new System.Drawing.Size(186, 31);
            this.StoreAddressLbl.TabIndex = 9;
            this.StoreAddressLbl.Text = "Store Address";
            // 
            // StoreNameLbl
            // 
            this.StoreNameLbl.AutoSize = true;
            this.StoreNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreNameLbl.ForeColor = System.Drawing.Color.Silver;
            this.StoreNameLbl.Location = new System.Drawing.Point(100, 153);
            this.StoreNameLbl.Name = "StoreNameLbl";
            this.StoreNameLbl.Size = new System.Drawing.Size(158, 31);
            this.StoreNameLbl.TabIndex = 7;
            this.StoreNameLbl.Text = "Store Name";
            // 
            // StoreInfoLbl
            // 
            this.StoreInfoLbl.AutoSize = true;
            this.StoreInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreInfoLbl.ForeColor = System.Drawing.Color.Silver;
            this.StoreInfoLbl.Location = new System.Drawing.Point(152, 40);
            this.StoreInfoLbl.Name = "StoreInfoLbl";
            this.StoreInfoLbl.Size = new System.Drawing.Size(252, 58);
            this.StoreInfoLbl.TabIndex = 6;
            this.StoreInfoLbl.Text = "Store Info";
            // 
            // StoreNameTxtBox
            // 
            this.StoreNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.StoreNameTxtBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.StoreNameTxtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.StoreNameTxtBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.StoreNameTxtBox.BorderThickness = 3;
            this.StoreNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StoreNameTxtBox.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.StoreNameTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.StoreNameTxtBox.isPassword = false;
            this.StoreNameTxtBox.Location = new System.Drawing.Point(106, 188);
            this.StoreNameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.StoreNameTxtBox.Name = "StoreNameTxtBox";
            this.StoreNameTxtBox.Size = new System.Drawing.Size(330, 53);
            this.StoreNameTxtBox.TabIndex = 29;
            this.StoreNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // StoreAddressTxtBox
            // 
            this.StoreAddressTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.StoreAddressTxtBox.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.StoreAddressTxtBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.StoreAddressTxtBox.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.StoreAddressTxtBox.BorderThickness = 3;
            this.StoreAddressTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StoreAddressTxtBox.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.StoreAddressTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.StoreAddressTxtBox.isPassword = false;
            this.StoreAddressTxtBox.Location = new System.Drawing.Point(106, 338);
            this.StoreAddressTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.StoreAddressTxtBox.Name = "StoreAddressTxtBox";
            this.StoreAddressTxtBox.Size = new System.Drawing.Size(330, 53);
            this.StoreAddressTxtBox.TabIndex = 30;
            this.StoreAddressTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Store_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(563, 563);
            this.Controls.Add(this.StoreAddressTxtBox);
            this.Controls.Add(this.StoreNameTxtBox);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.StoreAddressLbl);
            this.Controls.Add(this.StoreNameLbl);
            this.Controls.Add(this.StoreInfoLbl);
            this.MaximizeBox = false;
            this.Name = "Store_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC SaveBut;
        private System.Windows.Forms.Label StoreAddressLbl;
        private System.Windows.Forms.Label StoreNameLbl;
        private System.Windows.Forms.Label StoreInfoLbl;
        private Bunifu.Framework.UI.BunifuMetroTextbox StoreNameTxtBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox StoreAddressTxtBox;
    }
}