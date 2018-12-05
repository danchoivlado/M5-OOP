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
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();

            KaparoTxt.Hide();
        }



        private void NameTxt_Enter(object sender, EventArgs e)
        {
            if (NameTxt.Text == "Name")
                NameTxt.Text = "";

        }

        private void NameTxt_Leave(object sender, EventArgs e)
        {
            if (NameTxt.Text == "")
            {
                NameTxt.Text = "Name";
                NameTxt.ForeColor = Color.LightGray;
            }
            else NameTxt.ForeColor = Color.LimeGreen;
        }

        private void NumberTxt_Enter(object sender, EventArgs e)
        {
            if (NumberTxt.Text == "Number")
                NumberTxt.Text = "";
        }

        private void NumberTxt_Leave(object sender, EventArgs e)
        {
            if (NumberTxt.Text == "")
            {
                NumberTxt.Text = "Number";
                NumberTxt.ForeColor = Color.LightGray;
            }
            else if(NumberTxt.Text.Length>9) NumberTxt.ForeColor = Color.LimeGreen;
        }



        private void KaparoTxt_Enter(object sender, EventArgs e)
        {
            if (KaparoTxt.Text == "Kaparo")
                KaparoTxt.Text = "";
        }

        private void KaparoTxt_Leave(object sender, EventArgs e)
        {
            if (KaparoTxt.Text == "")
            {
                KaparoTxt.Text = "Kaparo";
                KaparoTxt.ForeColor = Color.LightGray;
            }
            else KaparoTxt.ForeColor = Color.LimeGreen;
        }

        private void SumTxt_Enter(object sender, EventArgs e)
        {
            if (CenaTxt.Text == "Cena")
                CenaTxt.Text = "";
        }

        private void SumTxt_Leave(object sender, EventArgs e)
        {
            if (CenaTxt.Text == "")
            {
                CenaTxt.Text = "Cena";
                CenaTxt.ForeColor = Color.LightGray;
                CenaTxt.ForeColor = Color.LightGray;
                CenaTxt.ForeColor = Color.LightGray;
                CenaTxt.ForeColor = Color.LightGray;
            }
            else CenaTxt.ForeColor = Color.LimeGreen;
        }

        private void KaparoCheck_CheckedChanged(object sender, EventArgs e)
        {
            //KaparoTxt.Show();
            // KaparoTxt.Hide();

        }

        private void KaparoCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (KaparoCheck.Checked)
            {
                KaparoTxt.Show();
            }
            else if (KaparoTxt.Text == "Kaparo")
            {
                KaparoTxt.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
        }
        private bool Check()
        {
            if (NameTxt.Text != "Name" && NumberTxt.Text.Length  > 9 &&
                CenaTxt.Text != "Cena")
            {
                return true;
            }
            else
            {
                if (NameTxt.Text == "Name")
                    NameTxt.BackColor = Color.Red;
                if (NumberTxt.Text == "Number" || NumberTxt.Text.Length  < 10)
                    NumberTxt.BackColor = Color.Red;
                if (CenaTxt.Text == "Cena")
                    CenaTxt.BackColor = Color.Red;
                return false;
            }
        }
    }
}
