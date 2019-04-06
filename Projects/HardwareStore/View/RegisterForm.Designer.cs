namespace HardwareStore.View
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.SignUpBut = new ePOSOne.btnProduct.Button_WOC();
            this.TownTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.TownLbl = new System.Windows.Forms.Label();
            this.FirstNameTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.SignUpLbl = new System.Windows.Forms.Label();
            this.LastNameTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.PasswordTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.AdminPasswordTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.AdminLbl = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.InvalidNamesLbl = new System.Windows.Forms.Label();
            this.InvalidTownLbl = new System.Windows.Forms.Label();
            this.InvalidPasswordLbl = new System.Windows.Forms.Label();
            this.InvalidAdminPasswordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignUpBut
            // 
            this.SignUpBut.BorderColor = System.Drawing.Color.Silver;
            this.SignUpBut.ButtonColor = System.Drawing.Color.SeaGreen;
            this.SignUpBut.FlatAppearance.BorderSize = 0;
            this.SignUpBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.SignUpBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.SignUpBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBut.Location = new System.Drawing.Point(201, 675);
            this.SignUpBut.Name = "SignUpBut";
            this.SignUpBut.OnHoverBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SignUpBut.OnHoverButtonColor = System.Drawing.Color.MediumSeaGreen;
            this.SignUpBut.OnHoverTextColor = System.Drawing.Color.White;
            this.SignUpBut.Size = new System.Drawing.Size(177, 63);
            this.SignUpBut.TabIndex = 6;
            this.SignUpBut.Text = "SIgn Up";
            this.SignUpBut.TextColor = System.Drawing.Color.White;
            this.SignUpBut.UseVisualStyleBackColor = true;
            this.SignUpBut.Click += new System.EventHandler(this.SignUpBut_Click);
            // 
            // TownTxtBox
            // 
            this.TownTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.TownTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TownTxtBox.BackgroundImage")));
            this.TownTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TownTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TownTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.TownTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("TownTxtBox.Icon")));
            this.TownTxtBox.Location = new System.Drawing.Point(87, 305);
            this.TownTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TownTxtBox.Name = "TownTxtBox";
            this.TownTxtBox.Size = new System.Drawing.Size(418, 52);
            this.TownTxtBox.TabIndex = 3;
            this.TownTxtBox.text = "";
            // 
            // TownLbl
            // 
            this.TownLbl.AutoSize = true;
            this.TownLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TownLbl.ForeColor = System.Drawing.Color.Silver;
            this.TownLbl.Location = new System.Drawing.Point(81, 270);
            this.TownLbl.Name = "TownLbl";
            this.TownLbl.Size = new System.Drawing.Size(81, 31);
            this.TownLbl.TabIndex = 9;
            this.TownLbl.Text = "Town";
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.FirstNameTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FirstNameTxtBox.BackgroundImage")));
            this.FirstNameTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FirstNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.FirstNameTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("FirstNameTxtBox.Icon")));
            this.FirstNameTxtBox.Location = new System.Drawing.Point(87, 184);
            this.FirstNameTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(196, 52);
            this.FirstNameTxtBox.TabIndex = 1;
            this.FirstNameTxtBox.text = "";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLbl.ForeColor = System.Drawing.Color.Silver;
            this.FirstNameLbl.Location = new System.Drawing.Point(81, 149);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(147, 31);
            this.FirstNameLbl.TabIndex = 7;
            this.FirstNameLbl.Text = "First Name";
            // 
            // SignUpLbl
            // 
            this.SignUpLbl.AutoSize = true;
            this.SignUpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLbl.ForeColor = System.Drawing.Color.Silver;
            this.SignUpLbl.Location = new System.Drawing.Point(191, 34);
            this.SignUpLbl.Name = "SignUpLbl";
            this.SignUpLbl.Size = new System.Drawing.Size(209, 58);
            this.SignUpLbl.TabIndex = 6;
            this.SignUpLbl.Text = "Sign Up";
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.LastNameTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LastNameTxtBox.BackgroundImage")));
            this.LastNameTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LastNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.LastNameTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("LastNameTxtBox.Icon")));
            this.LastNameTxtBox.Location = new System.Drawing.Point(309, 184);
            this.LastNameTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(196, 52);
            this.LastNameTxtBox.TabIndex = 2;
            this.LastNameTxtBox.text = "";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.ForeColor = System.Drawing.Color.Silver;
            this.LastNameLbl.Location = new System.Drawing.Point(303, 149);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(145, 31);
            this.LastNameLbl.TabIndex = 13;
            this.LastNameLbl.Text = "Last Name";
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.PasswordTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasswordTxtBox.BackgroundImage")));
            this.PasswordTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.PasswordTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("PasswordTxtBox.Icon")));
            this.PasswordTxtBox.Location = new System.Drawing.Point(87, 438);
            this.PasswordTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(418, 52);
            this.PasswordTxtBox.TabIndex = 4;
            this.PasswordTxtBox.text = "";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.Color.Silver;
            this.PasswordLbl.Location = new System.Drawing.Point(81, 403);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(134, 31);
            this.PasswordLbl.TabIndex = 14;
            this.PasswordLbl.Text = "Password";
            // 
            // AdminPasswordTxtBox
            // 
            this.AdminPasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.AdminPasswordTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminPasswordTxtBox.BackgroundImage")));
            this.AdminPasswordTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminPasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPasswordTxtBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.AdminPasswordTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("AdminPasswordTxtBox.Icon")));
            this.AdminPasswordTxtBox.Location = new System.Drawing.Point(87, 565);
            this.AdminPasswordTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdminPasswordTxtBox.Name = "AdminPasswordTxtBox";
            this.AdminPasswordTxtBox.Size = new System.Drawing.Size(418, 52);
            this.AdminPasswordTxtBox.TabIndex = 5;
            this.AdminPasswordTxtBox.text = "";
            // 
            // AdminLbl
            // 
            this.AdminLbl.AutoSize = true;
            this.AdminLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.AdminLbl.Location = new System.Drawing.Point(81, 530);
            this.AdminLbl.Name = "AdminLbl";
            this.AdminLbl.Size = new System.Drawing.Size(217, 31);
            this.AdminLbl.TabIndex = 16;
            this.AdminLbl.Text = "Admin Password";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuSeparator1.LineThickness = 5;
            this.bunifuSeparator1.Location = new System.Drawing.Point(201, 92);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(185, 14);
            this.bunifuSeparator1.TabIndex = 18;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // InvalidNamesLbl
            // 
            this.InvalidNamesLbl.AutoSize = true;
            this.InvalidNamesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidNamesLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidNamesLbl.Location = new System.Drawing.Point(82, 241);
            this.InvalidNamesLbl.Name = "InvalidNamesLbl";
            this.InvalidNamesLbl.Size = new System.Drawing.Size(477, 25);
            this.InvalidNamesLbl.TabIndex = 21;
            this.InvalidNamesLbl.Text = "First Name and Last Name must be at least 4 symbols";
            this.InvalidNamesLbl.Visible = false;
            // 
            // InvalidTownLbl
            // 
            this.InvalidTownLbl.AutoSize = true;
            this.InvalidTownLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidTownLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidTownLbl.Location = new System.Drawing.Point(82, 362);
            this.InvalidTownLbl.Name = "InvalidTownLbl";
            this.InvalidTownLbl.Size = new System.Drawing.Size(352, 25);
            this.InvalidTownLbl.TabIndex = 22;
            this.InvalidTownLbl.Text = "Town Name must be at least 4 symbols";
            this.InvalidTownLbl.Visible = false;
            // 
            // InvalidPasswordLbl
            // 
            this.InvalidPasswordLbl.AutoSize = true;
            this.InvalidPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidPasswordLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidPasswordLbl.Location = new System.Drawing.Point(82, 495);
            this.InvalidPasswordLbl.Name = "InvalidPasswordLbl";
            this.InvalidPasswordLbl.Size = new System.Drawing.Size(332, 25);
            this.InvalidPasswordLbl.TabIndex = 23;
            this.InvalidPasswordLbl.Text = "Password must be at least 6 symbols";
            this.InvalidPasswordLbl.Visible = false;
            // 
            // InvalidAdminPasswordLbl
            // 
            this.InvalidAdminPasswordLbl.AutoSize = true;
            this.InvalidAdminPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidAdminPasswordLbl.ForeColor = System.Drawing.Color.Red;
            this.InvalidAdminPasswordLbl.Location = new System.Drawing.Point(82, 621);
            this.InvalidAdminPasswordLbl.Name = "InvalidAdminPasswordLbl";
            this.InvalidAdminPasswordLbl.Size = new System.Drawing.Size(220, 25);
            this.InvalidAdminPasswordLbl.TabIndex = 24;
            this.InvalidAdminPasswordLbl.Text = "Invalid Admin Password";
            this.InvalidAdminPasswordLbl.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(583, 750);
            this.Controls.Add(this.InvalidAdminPasswordLbl);
            this.Controls.Add(this.InvalidPasswordLbl);
            this.Controls.Add(this.InvalidTownLbl);
            this.Controls.Add(this.InvalidNamesLbl);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.AdminPasswordTxtBox);
            this.Controls.Add(this.AdminLbl);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.SignUpBut);
            this.Controls.Add(this.TownTxtBox);
            this.Controls.Add(this.TownLbl);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.SignUpLbl);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC SignUpBut;
        private Bunifu.Framework.UI.BunifuTextbox TownTxtBox;
        private System.Windows.Forms.Label TownLbl;
        private Bunifu.Framework.UI.BunifuTextbox FirstNameTxtBox;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label SignUpLbl;
        private Bunifu.Framework.UI.BunifuTextbox LastNameTxtBox;
        private System.Windows.Forms.Label LastNameLbl;
        private Bunifu.Framework.UI.BunifuTextbox PasswordTxtBox;
        private System.Windows.Forms.Label PasswordLbl;
        private Bunifu.Framework.UI.BunifuTextbox AdminPasswordTxtBox;
        private System.Windows.Forms.Label AdminLbl;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label InvalidNamesLbl;
        private System.Windows.Forms.Label InvalidTownLbl;
        private System.Windows.Forms.Label InvalidPasswordLbl;
        private System.Windows.Forms.Label InvalidAdminPasswordLbl;
    }
}