using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core.Preview;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //if the program is in locked mode
        public static bool Locked = false;
        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(LoginPage));
            SystemNavigationManagerPreview.GetForCurrentView().CloseRequested += this.OnCloseRequest;
        }

        /// <summary>
        /// When closing aplicatiion event
        /// to turn Comunication off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCloseRequest(object sender, SystemNavigationCloseRequestedPreviewEventArgs e)
        {
            App.TurnOffCommunicationLed();
        }

        private void Menu_button_Click(object sender, RoutedEventArgs e)
        {
            MenuSplitView.IsPaneOpen = !MenuSplitView.IsPaneOpen;
        }
        /// <summary>
        /// Navigates through pages 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PagesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HomePageItem.IsSelected && Locked == true)
            {
                MainFrame.Navigate(typeof(HomePage));
                // PageName.Text = "Home Page";
                PageName.TextAlignment = TextAlignment.Center;
            }

            else if (LookupPageItem.IsSelected && Locked == true)
            {
                MainFrame.Navigate(typeof(EmployeeInfoPage));
                // PageName.Text = "Database Of All EMployees";
            }

            else if (CreatePageItem.IsSelected && Locked == true)
            {
                MainFrame.Navigate(typeof(CreatePage));
                //PageName.Text = "Create New Employee";
            }

            else if (StatsPageItem.IsSelected && Locked == true)
            {
                MainFrame.Navigate(typeof(JobPage));
                // PageName.Text = "Work Graph Page";
            }
            //When program is started
            else if (LockAplicationItem.IsSelected && Locked == true)
            {
                MainFrame.Navigate(typeof(LoginPage));
                Locked = false;
            }

        }

        /// <summary>
        /// Used to Set Locked property true when typed username and password 
        /// </summary>
        public static void UnlockMenu()
        {
            Locked = true;
        }

        private void Menu_button_Unloaded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine();
        }
    }
}
