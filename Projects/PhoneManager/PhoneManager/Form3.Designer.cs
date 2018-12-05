namespace PhoneManager
{
    partial class Form3
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
            this.ModelTxt = new System.Windows.Forms.TextBox();
            this.ProblemTxt = new System.Windows.Forms.ComboBox();
            this.ImeiTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModelTxt
            // 
            this.ModelTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "Samsung",
            "Apple",
            "Huawei",
            "Nokia",
            "Sony",
            "LG",
            "Ares",
            "HTC",
            "Motorola",
            "Lenovo",
            "Xiaomi",
            "Google",
            "Oppo",
            "Realme",
            "OnePlus",
            "Meizu",
            "vivo",
            "Asus",
            "BlackBerry",
            "Alcatel",
            "ZTE",
            "Microsoft",
            "Vodafone",
            "Energizer",
            "Cat",
            "Lava",
            "Micromax",
            "BLU",
            "Wiko",
            "Acer",
            "LeEco",
            "Panasonic",
            "Infinix",
            "YU",
            "verykool",
            "Maxwest",
            "Plum"});
            this.ModelTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ModelTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ModelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ModelTxt.Location = new System.Drawing.Point(34, 146);
            this.ModelTxt.Name = "ModelTxt";
            this.ModelTxt.Size = new System.Drawing.Size(309, 64);
            this.ModelTxt.TabIndex = 11;
            this.ModelTxt.Text = "Model";
            this.ModelTxt.Enter += new System.EventHandler(this.ModelTxt_Enter_1);
            this.ModelTxt.Leave += new System.EventHandler(this.ModelTxt_Leave_1);
            // 
            // ProblemTxt
            // 
            this.ProblemTxt.Font = new System.Drawing.Font("Microsoft Tai Le", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ProblemTxt.FormattingEnabled = true;
            this.ProblemTxt.Location = new System.Drawing.Point(34, 247);
            this.ProblemTxt.Name = "ProblemTxt";
            this.ProblemTxt.Size = new System.Drawing.Size(310, 66);
            this.ProblemTxt.TabIndex = 10;
            this.ProblemTxt.Text = "Problem";
            this.ProblemTxt.Enter += new System.EventHandler(this.ProblemTxt_Enter_1);
            this.ProblemTxt.Leave += new System.EventHandler(this.ProblemTxt_Leave_1);
            // 
            // ImeiTxt
            // 
            this.ImeiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeiTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ImeiTxt.Location = new System.Drawing.Point(34, 44);
            this.ImeiTxt.Multiline = true;
            this.ImeiTxt.Name = "ImeiTxt";
            this.ImeiTxt.Size = new System.Drawing.Size(310, 60);
            this.ImeiTxt.TabIndex = 9;
            this.ImeiTxt.Text = "Imei";
            this.ImeiTxt.Enter += new System.EventHandler(this.ImeiTxt_Enter_1);
            this.ImeiTxt.Leave += new System.EventHandler(this.ImeiTxt_Leave_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(34, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 103);
            this.button1.TabIndex = 12;
            this.button1.Text = "AddPhone";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ModelTxt);
            this.Controls.Add(this.ProblemTxt);
            this.Controls.Add(this.ImeiTxt);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ModelTxt;
        private System.Windows.Forms.ComboBox ProblemTxt;
        private System.Windows.Forms.TextBox ImeiTxt;
        private System.Windows.Forms.Button button1;
    }
}