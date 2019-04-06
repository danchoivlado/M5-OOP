namespace HardwareStore
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.SignInLbl = new System.Windows.Forms.Label();
            this.SignUpBut = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.NameTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTxtBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.WrongDataLbl = new System.Windows.Forms.Label();
            this.SignInBut = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // SignInLbl
            // 
            this.SignInLbl.AutoSize = true;
            this.SignInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLbl.ForeColor = System.Drawing.Color.Silver;
            this.SignInLbl.Location = new System.Drawing.Point(177, 35);
            this.SignInLbl.Name = "SignInLbl";
            this.SignInLbl.Size = new System.Drawing.Size(187, 58);
            this.SignInLbl.TabIndex = 0;
            this.SignInLbl.Text = "Sign In";
            // 
            // SignUpBut
            // 
            this.SignUpBut.AutoSize = true;
            this.SignUpBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBut.ForeColor = System.Drawing.Color.SeaGreen;
            this.SignUpBut.Location = new System.Drawing.Point(428, 465);
            this.SignUpBut.Name = "SignUpBut";
            this.SignUpBut.Size = new System.Drawing.Size(117, 31);
            this.SignUpBut.TabIndex = 6;
            this.SignUpBut.Text = "Sign Up";
            this.SignUpBut.Click += new System.EventHandler(this.SignUpBut_Click);
            this.SignUpBut.MouseLeave += new System.EventHandler(this.SignUpBut_MouseLeave);
            this.SignUpBut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SignUpBut_MouseMove);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuSeparator1.LineThickness = 5;
            this.bunifuSeparator1.Location = new System.Drawing.Point(187, 97);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(164, 14);
            this.bunifuSeparator1.TabIndex = 19;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLbl.ForeColor = System.Drawing.Color.Silver;
            this.FirstNameLbl.Location = new System.Drawing.Point(89, 146);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(139, 31);
            this.FirstNameLbl.TabIndex = 1;
            this.FirstNameLbl.Text = "Username";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.NameTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NameTxtBox.BackgroundImage")));
            this.NameTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.NameTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("NameTxtBox.Icon")));
            this.NameTxtBox.Location = new System.Drawing.Point(95, 181);
            this.NameTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(357, 52);
            this.NameTxtBox.TabIndex = 2;
            this.NameTxtBox.text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(89, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.PasswordTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasswordTxtBox.BackgroundImage")));
            this.PasswordTxtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.PasswordTxtBox.Icon = ((System.Drawing.Image)(resources.GetObject("PasswordTxtBox.Icon")));
            this.PasswordTxtBox.Location = new System.Drawing.Point(95, 331);
            this.PasswordTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(357, 52);
            this.PasswordTxtBox.TabIndex = 4;
            this.PasswordTxtBox.text = "";
            // 
            // WrongDataLbl
            // 
            this.WrongDataLbl.AutoSize = true;
            this.WrongDataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongDataLbl.ForeColor = System.Drawing.Color.Red;
            this.WrongDataLbl.Location = new System.Drawing.Point(90, 398);
            this.WrongDataLbl.Name = "WrongDataLbl";
            this.WrongDataLbl.Size = new System.Drawing.Size(297, 26);
            this.WrongDataLbl.TabIndex = 20;
            this.WrongDataLbl.Text = "Wrong Username / Password";
            this.WrongDataLbl.Visible = false;
            // 
            // SignInBut
            // 
            this.SignInBut.BorderColor = System.Drawing.Color.Silver;
            this.SignInBut.ButtonColor = System.Drawing.Color.SeaGreen;
            this.SignInBut.FlatAppearance.BorderSize = 0;
            this.SignInBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.SignInBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.SignInBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBut.Location = new System.Drawing.Point(187, 450);
            this.SignInBut.Name = "SignInBut";
            this.SignInBut.OnHoverBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SignInBut.OnHoverButtonColor = System.Drawing.Color.MediumSeaGreen;
            this.SignInBut.OnHoverTextColor = System.Drawing.Color.White;
            this.SignInBut.Size = new System.Drawing.Size(177, 63);
            this.SignInBut.TabIndex = 5;
            this.SignInBut.Text = "SIgn In";
            this.SignInBut.TextColor = System.Drawing.Color.White;
            this.SignInBut.UseVisualStyleBackColor = true;
            this.SignInBut.Click += new System.EventHandler(this.SignInBut_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(563, 563);
            this.Controls.Add(this.WrongDataLbl);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.SignUpBut);
            this.Controls.Add(this.SignInBut);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.SignInLbl);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignInLbl;
        private ePOSOne.btnProduct.Button_WOC SignInBut;
        private System.Windows.Forms.Label SignUpBut;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label FirstNameLbl;
        private Bunifu.Framework.UI.BunifuTextbox NameTxtBox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuTextbox PasswordTxtBox;
        private System.Windows.Forms.Label WrongDataLbl;
    }
}

