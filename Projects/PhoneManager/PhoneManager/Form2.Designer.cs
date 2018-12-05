namespace PhoneManager
{
    partial class RegisterPage
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
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.NumberTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SimCheck = new System.Windows.Forms.CheckBox();
            this.KaparoTxt = new System.Windows.Forms.TextBox();
            this.CenaTxt = new System.Windows.Forms.TextBox();
            this.KaparoCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameTxt.Location = new System.Drawing.Point(24, 21);
            this.NameTxt.Multiline = true;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(310, 58);
            this.NameTxt.TabIndex = 0;
            this.NameTxt.Text = "Name";
            this.NameTxt.Enter += new System.EventHandler(this.NameTxt_Enter);
            this.NameTxt.Leave += new System.EventHandler(this.NameTxt_Leave);
            // 
            // NumberTxt
            // 
            this.NumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.NumberTxt.Location = new System.Drawing.Point(24, 153);
            this.NumberTxt.Multiline = true;
            this.NumberTxt.Name = "NumberTxt";
            this.NumberTxt.Size = new System.Drawing.Size(310, 58);
            this.NumberTxt.TabIndex = 1;
            this.NumberTxt.Text = "Number";
            this.NumberTxt.Enter += new System.EventHandler(this.NumberTxt_Enter);
            this.NumberTxt.Leave += new System.EventHandler(this.NumberTxt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 102);
            this.label1.TabIndex = 2;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 102);
            this.label2.TabIndex = 3;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 102);
            this.label3.TabIndex = 5;
            this.label3.Text = "*";
            // 
            // SimCheck
            // 
            this.SimCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimCheck.ForeColor = System.Drawing.Color.SeaGreen;
            this.SimCheck.Location = new System.Drawing.Point(24, 419);
            this.SimCheck.Name = "SimCheck";
            this.SimCheck.Size = new System.Drawing.Size(310, 58);
            this.SimCheck.TabIndex = 9;
            this.SimCheck.Text = "Sim";
            this.SimCheck.UseVisualStyleBackColor = true;
            // 
            // KaparoTxt
            // 
            this.KaparoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KaparoTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.KaparoTxt.Location = new System.Drawing.Point(488, 153);
            this.KaparoTxt.Multiline = true;
            this.KaparoTxt.Name = "KaparoTxt";
            this.KaparoTxt.Size = new System.Drawing.Size(297, 58);
            this.KaparoTxt.TabIndex = 10;
            this.KaparoTxt.Text = "Kaparo";
            this.KaparoTxt.Enter += new System.EventHandler(this.KaparoTxt_Enter);
            this.KaparoTxt.Leave += new System.EventHandler(this.KaparoTxt_Leave);
            // 
            // CenaTxt
            // 
            this.CenaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CenaTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CenaTxt.Location = new System.Drawing.Point(24, 285);
            this.CenaTxt.Multiline = true;
            this.CenaTxt.Name = "CenaTxt";
            this.CenaTxt.Size = new System.Drawing.Size(310, 60);
            this.CenaTxt.TabIndex = 11;
            this.CenaTxt.Text = "Cena";
            this.CenaTxt.Enter += new System.EventHandler(this.SumTxt_Enter);
            this.CenaTxt.Leave += new System.EventHandler(this.SumTxt_Leave);
            // 
            // KaparoCheck
            // 
            this.KaparoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KaparoCheck.ForeColor = System.Drawing.Color.SeaGreen;
            this.KaparoCheck.Location = new System.Drawing.Point(507, 21);
            this.KaparoCheck.Name = "KaparoCheck";
            this.KaparoCheck.Size = new System.Drawing.Size(278, 58);
            this.KaparoCheck.TabIndex = 12;
            this.KaparoCheck.Text = "Kaparo";
            this.KaparoCheck.UseVisualStyleBackColor = true;
            this.KaparoCheck.CheckedChanged += new System.EventHandler(this.KaparoCheck_CheckedChanged);
            this.KaparoCheck.CheckStateChanged += new System.EventHandler(this.KaparoCheck_CheckStateChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(502, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 101);
            this.button1.TabIndex = 13;
            this.button1.Text = "AddPhone";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(825, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KaparoCheck);
            this.Controls.Add(this.CenaTxt);
            this.Controls.Add(this.KaparoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.SimCheck);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "RegisterPage";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox NumberTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox SimCheck;
        private System.Windows.Forms.TextBox KaparoTxt;
        private System.Windows.Forms.TextBox CenaTxt;
        private System.Windows.Forms.CheckBox KaparoCheck;
        private System.Windows.Forms.Button button1;
    }
}