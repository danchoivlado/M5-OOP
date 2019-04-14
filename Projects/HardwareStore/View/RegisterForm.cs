using HardwareStore.BusinessLogic;
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

namespace HardwareStore.View
{
    public partial class RegisterForm : Form
    {
        RegisterLoginInfoBLL registerLoginBLL;
        private const string AdminPassword = "0878752578";


        public RegisterForm()
        {
            InitializeComponent();
            this.ActiveControl = this.FirstNameTxtBox;
            this.registerLoginBLL = new RegisterLoginInfoBLL();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//Disables resizing
            this.AdminPasswordTxtBox._TextBox.PasswordChar = '*'; 
            this.PasswordTxtBox._TextBox.PasswordChar = '*';

        }

        /// <summary>
        /// Registers Employee by the given parameters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUpBut_Click(object sender, EventArgs e)
        {
            if (!Validate(this.FirstNameTxtBox.text,
               this.LastNameTxtBox.text,this.TownTxtBox.text, this.PasswordTxtBox.text)) //Checks for invalid fields
            {
                registerLoginBLL.Register(FirstNameTxtBox.text,
                    LastNameTxtBox.text, TownTxtBox.text, PasswordTxtBox.text);
                //Sent to BLL all the info from the form
                this.Close();
            }
        }

        /// <summary>
        /// Validates the info from the txtBoxe f
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Town"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        private bool Validate(string FirstName, string LastName, string Town, string Password)
        {
            bool IsInvalid = false;

            if (FirstName.Length < 4 || LastName.Length < 4)
            {
                this.InvalidNamesLbl.Visible = true;
                IsInvalid = true;
            }
            else
            {
                this.InvalidNamesLbl.Visible = false;
            }

            if (Town.Length < 4)
            {
                this.InvalidTownLbl.Visible = true;
                IsInvalid = true;
            }
            else
            {
                this.InvalidTownLbl.Visible = false;
            }

            if (Password.Length < 6)
            {
                this.InvalidPasswordLbl.Visible = true;
                IsInvalid = true;
            }
            else
            {
                this.InvalidPasswordLbl.Visible = false;
            }

            if(AdminPasswordTxtBox.text != AdminPassword)
            {
                this.InvalidAdminPasswordLbl.Visible = true;
                IsInvalid = true;
            }
            else
            {
                this.InvalidAdminPasswordLbl.Visible = false;
            }

            return IsInvalid;
        }
    }
}
