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
        //if emergency button was pressed once
        bool TrigeredOnce;
        GraphBLL GraphBLL;
        LoginBLL LoginBLL;

        public LoginPage()
        {
            this.InitializeComponent();
            this.GraphBLL = new GraphBLL();
            this.LoginBLL = new LoginBLL();
            //Displays to the screen all the admins you have registered
            this.UsersLabel.Text = $"You have total of {this.LoginBLL.GetUsersCount()} Admins.";
        }

        /// <summary>
        /// Checks if the username and password are correct and unlocks the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //Gets the username from the TextBox
            var UserName = this.UserNameTxtBox.Text;
            //Gets the password from TextBox
            var Password = this.PasswordTxtBox.Text;
            //If there is admin
            if (this.LoginBLL.CheckForValidFields(UserName, Password))
            {
                //Unlock the app
                MainPage.UnlockMenu();
                this.Frame.Navigate(typeof(HomePage));
                InvalidTxtBox.Visibility = Visibility.Collapsed;
            }
            else
            {
                //Display invalid data
                InvalidTxtBox.Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// Navigates to Register page when pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterBut_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegisterPage));
        }
        /// <summary>
        /// Opens the Servo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmergencyOpenBut_Click(object sender, RoutedEventArgs e)
        {
            //if the button was pressed
            if (!TrigeredOnce)
            {
                //Displays the confirm dialog
                DisplayDeleteFileDialog();
            }
            //Stops the emergency
            else
            {
                App.DeactivateEmergencyAlarm();
                this.TrigeredOnce = false;
                this.EmergencyOpenTxtBox.Visibility = Visibility.Collapsed;
                this.EmergencyOpenBut.Content = "Emergency Open";
            }
        }
        /// <summary>
        /// Confirm dialog
        /// </summary>
        private async void DisplayDeleteFileDialog()
        {
            ContentDialog deleteFileDialog = new ContentDialog
            {
                Title = $"Triger Emergency Open System",
                Content = $"By pressing the Trigger button you will activate emergency open alarm for all doors.",
                PrimaryButtonText = "Trigger",
                CloseButtonText = "Cancel"
            };

            ContentDialogResult result = await deleteFileDialog.ShowAsync();

            // Delete the file if the user clicked the primary button.
            /// Otherwise, do nothing.
            if (result == ContentDialogResult.Primary)
            {
                this.EmergencyOpenTxtBox.Visibility = Visibility.Visible;
                App.TriggerEmergencyAlarm();
                this.TrigeredOnce = true;
                this.EmergencyOpenBut.Content = "Emergency Close";
            }
            else
            {
                // The user clicked the CLoseButton, pressed ESC, Gamepad B, or the system back button.
                // Do nothing.
            }
        }
    }
}
