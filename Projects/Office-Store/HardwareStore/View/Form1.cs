using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HardwareStore.Database;
using HardwareStore.View;

namespace HardwareStore
{
    public partial class Login : Form
    {
        Base Base;
        RegisterForm RegisterForm;

        public Login()
        {
            InitializeComponent();
            this.ActiveControl = NameTxtBox;
            NameTxtBox.Focus();
        }

        private void NameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = PasswordTxtBox;
                PasswordTxtBox.Focus();
            }
        }

        private void PasswordTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBut.PerformClick();
            }
        }

        private void LoginBut_Click(object sender, EventArgs e)
        {
            this.Base = new Base();
            string Password = Base.GetPasswordIfExists(NameTxtBox.Text);
            if (PasswordTxtBox.Text == Password)
            {
                this.Hide();
            }
        }

        private void RegisterBut_Click(object sender, EventArgs e)
        {
            this.RegisterForm = new RegisterForm();
            this.Hide();
            RegisterForm.Show();
        }
    }
}
