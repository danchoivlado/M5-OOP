namespace HardwareStore
{
    partial class Login
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.LoginBut = new System.Windows.Forms.Button();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.RegisterBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(15, 67);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(155, 32);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(15, 133);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(155, 32);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtBox.Location = new System.Drawing.Point(279, 133);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.Size = new System.Drawing.Size(218, 36);
            this.PasswordTxtBox.TabIndex = 3;
            this.PasswordTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTxtBox_KeyDown);
            // 
            // LoginBut
            // 
            this.LoginBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBut.Location = new System.Drawing.Point(180, 214);
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.Size = new System.Drawing.Size(162, 50);
            this.LoginBut.TabIndex = 4;
            this.LoginBut.Text = "Login";
            this.LoginBut.UseVisualStyleBackColor = true;
            this.LoginBut.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxtBox.Location = new System.Drawing.Point(279, 67);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(218, 36);
            this.NameTxtBox.TabIndex = 5;
            this.NameTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTxtBox_KeyDown);
            // 
            // RegisterBut
            // 
            this.RegisterBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBut.Location = new System.Drawing.Point(440, 230);
            this.RegisterBut.Name = "RegisterBut";
            this.RegisterBut.Size = new System.Drawing.Size(80, 36);
            this.RegisterBut.TabIndex = 6;
            this.RegisterBut.Text = "Register";
            this.RegisterBut.UseVisualStyleBackColor = true;
            this.RegisterBut.Click += new System.EventHandler(this.RegisterBut_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 276);
            this.Controls.Add(this.RegisterBut);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.LoginBut);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NameLabel);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Button LoginBut;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Button RegisterBut;
    }
}

