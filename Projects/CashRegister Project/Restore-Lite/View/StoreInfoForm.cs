using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HardwareStore.BusinessLogic;

namespace HardwareStore.View
{
    public partial class StoreInfoForm : Form
    {
        RegisterLoginInfoBLL RegisterLoginInfoBLL;

        public StoreInfoForm()
        {
            InitializeComponent();
            this.RegisterLoginInfoBLL = new RegisterLoginInfoBLL();
            string[] NameAddress = RegisterLoginInfoBLL.GetNameAddressIfExists();
            //Gets the info of the database
            this.StoreNameTxtBox.Text = NameAddress[0];
            this.StoreAddressTxtBox.Text = NameAddress[1];
            this.FormBorderStyle = FormBorderStyle.FixedDialog;//Disables Resizing
        }

        /// <summary>
        /// Saves the info given by the user to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBut_Click_1(object sender, EventArgs e)
        {
            string StoreName = this.StoreNameTxtBox.Text;
            string StoreAddress = this.StoreAddressTxtBox.Text;
            RegisterLoginInfoBLL.SaveData(StoreName, StoreAddress);
            //Updates StoreInfo
            this.Close();
        }
    }
}
