using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using App1.BusinessLogic;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        GraphBLL GraphBLL;
        LoginBLL LoginBLL;
        public LoginPage()
        {
            this.InitializeComponent();
            this.GraphBLL = new GraphBLL();
            this.LoginBLL = new LoginBLL();
            this.UsersLabel.Text = $"You have total of {this.LoginBLL.GetUsersCount()} Admins.";
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var UserName = this.UserNameTxtBox.Text;
            var Password = this.PasswordTxtBox.Text;
            if(this.LoginBLL.CheckForValidFields(UserName, Password))
            {
                MainPage.UnlockMenu();
                this.Frame.Navigate(typeof(HomePage));
                InvalidTxtBox.Visibility = Visibility.Collapsed;
            }
            else
            {
                InvalidTxtBox.Visibility = Visibility.Visible;
            }
        }

        private void RegisterBut_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegisterPage));

        }
    }
}
