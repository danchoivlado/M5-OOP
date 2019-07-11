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
    public sealed partial class RegisterPage : Page
    {
        GraphBLL GraphBLL;
        LoginBLL LoginBLL;
        public RegisterPage()
        {
            this.InitializeComponent();
            this.GraphBLL = new GraphBLL();
            this.LoginBLL = new LoginBLL();
        }

        /// <summary>
        /// When someone is about tom scann master card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnScan_Click(object sender, RoutedEventArgs e)
        {
            App.StopWorker();
            this.BtnGet.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Gets from the DataBase recetly scanned master card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGet_Click(object sender, RoutedEventArgs e)
        {
            this.CardNumberTxtBox.Text = $"{GraphBLL.GetLast()}";
            this.BtnGet.Visibility = Visibility.Collapsed;
            App.StartWorker();
        }

        /// <summary>
        /// Add to the DataBase admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            var ScanerCode = this.CardNumberTxtBox.Text;
            //if it is reaally the master card number
            if (this.LoginBLL.CheckAdminCode(ScanerCode))
            {
                var UserName = this.UserNameTxtBox.Text;
                var Password = this.PasswordTxtBox.Text;
                // Creates admin
                this.LoginBLL.CreateUser(UserName, Password);
                this.ValidateTxtBox.Visibility = Visibility.Collapsed;
                this.Frame.Navigate(typeof(LoginPage));
            }
            else
            {
                this.ValidateTxtBox.Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// Cencel the registration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cencel_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoginPage));
        }
        /// <summary>
        /// Shows dialog when the button pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAllUsers_Click(object sender, RoutedEventArgs e)
        {
            DisplayDeleteFileDialog();
        }

        private async void DisplayDeleteFileDialog()
        {
            ContentDialog deleteFileDialog = new ContentDialog
            {
                Title = $"Delete All Users",
                Content = $"Delete All {this.LoginBLL.GetUsersCount()} Admins of your Program forever?",
                PrimaryButtonText = "Delete",
                CloseButtonText = "Cancel"
            };

            ContentDialogResult result = await deleteFileDialog.ShowAsync();

            // Delete the file if the user clicked the primary button.
            /// Otherwise, do nothing.
            if (result == ContentDialogResult.Primary)
            {
                //deletes all the admins from the DataBase
                this.LoginBLL.DeleteAllAdminUsers();
            }
            else
            {
                // The user clicked the CLoseButton, pressed ESC, Gamepad B, or the system back button.
                // Do nothing.
            }
        }
    }
}
