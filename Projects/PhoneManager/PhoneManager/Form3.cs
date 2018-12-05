using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManager
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            ProblemTxt.Items.AddRange(lis);
        }
        string[] lis = new string[]
            { "Mokren","Dislpay","Google Akount","Ne Tragva"};

        private void ImeiTxt_Enter_1(object sender, EventArgs e)
        {
            if (ImeiTxt.Text == "Imei")
                ImeiTxt.Text = "";
        }

        private void ImeiTxt_Leave_1(object sender, EventArgs e)
        {
            if (ImeiTxt.Text == "")
            {
                ImeiTxt.Text = "Imei";
                ImeiTxt.ForeColor = Color.LightGray;
            }
            else ImeiTxt.ForeColor = Color.LimeGreen;
        }

        private void ModelTxt_Enter_1(object sender, EventArgs e)
        {
            if (ModelTxt.Text == "Model")
                ModelTxt.Text = "";
        }

        private void ModelTxt_Leave_1(object sender, EventArgs e)
        {
            if (ModelTxt.Text == "")
            {
                ModelTxt.Text = "Model";
                ModelTxt.ForeColor = Color.LightGray;
            }
            else ModelTxt.ForeColor = Color.LimeGreen;
        }

        private void ProblemTxt_Enter_1(object sender, EventArgs e)
        {
            if (ProblemTxt.Text == "Problem")
                ProblemTxt.Text = "";
        }

        private void ProblemTxt_Leave_1(object sender, EventArgs e)
        {
            if (ProblemTxt.Text == "")
            {
                ProblemTxt.Text = "Problem";
                ProblemTxt.ForeColor = Color.LightGray;
            }
            else ProblemTxt.ForeColor = Color.LimeGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check())
                this.Hide();
            //here VALUES ARE VALIDATED ADN READY TO SET TO DATABASE
        }

        private bool Check()
        {
            if (ImeiTxt.Text != "Imei" && ModelTxt.Text != "Model" &&
                ProblemTxt.Text != "Problem")
            {
                return true;
            }
            else
            {
                if (ImeiTxt.Text == "Imei")
                    ImeiTxt.BackColor = Color.Red;
                if (ModelTxt.Text == "Model")
                    ModelTxt.BackColor = Color.Red;
                if (ProblemTxt.Text == "Problem")
                    ProblemTxt.BackColor = Color.Red;
                return false;
            }
        }
    }
}
