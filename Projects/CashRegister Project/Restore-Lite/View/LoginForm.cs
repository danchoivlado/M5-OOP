using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HardwareStore.BusinessLogic;
using HardwareStore.View;

namespace HardwareStore
{
    public partial class LoginForm : Form
    {
        RegisterForm RegisterForm;
        RegisterLoginInfoBLL registerLoginBLL;
        MainFrom MainForm;


        public LoginForm()
        {
            InitializeComponent();
            this.registerLoginBLL = new RegisterLoginInfoBLL();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//Disables resizing
            this.PasswordTxtBox._TextBox.PasswordChar = '*';
        }

        /// <summary>
        /// Check if there is User with the given Name and password 
        /// and if there is countinue to the MainMenuForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignInBut_Click(object sender, EventArgs e)
        {
            if (this.registerLoginBLL.Login(this.NameTxtBox.text, this.PasswordTxtBox.text))//If user exists
            {
                this.registerLoginBLL.SaveLogined(this.NameTxtBox.text);
                //Send to BLL
                MainForm = new MainFrom();
                this.Hide();
                MainForm.ShowDialog();
                this.Close();
            }
            else
                this.WrongDataLbl.Visible = true;
        }

        /// <summary>
        /// Opens the Register form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUpBut_Click(object sender, EventArgs e)
        {
            //Creates new form
            this.RegisterForm = new RegisterForm();
            RegisterForm.ShowDialog();
        }

        private void SignUpBut_MouseMove(object sender, MouseEventArgs e)
        {
            this.SignUpBut.ForeColor = Color.MediumSeaGreen;
        }

        private void SignUpBut_MouseLeave(object sender, EventArgs e)
        {
            this.SignUpBut.ForeColor = Color.SeaGreen;
        }
    }
}
