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
        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(HomePage));
            
        }




        private void Menu_button_Click(object sender, RoutedEventArgs e)
        {
            MenuSplitView.IsPaneOpen = !MenuSplitView.IsPaneOpen;
        }

        private void PagesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HomePageItem.IsSelected)
            {
                MainFrame.Navigate(typeof(HomePage));
                PageName.Text = "Home Page";
                PageName.TextAlignment = TextAlignment.Center;
            }

            else if (LookupPageItem.IsSelected)
            {
                MainFrame.Navigate(typeof(EmployeeInfoPage));
                PageName.Text = "Database Of All EMployees";
            }

            else if (CreatePageItem.IsSelected)
            {
                MainFrame.Navigate(typeof(CreatePage));
                PageName.Text = "Create New Employee";
            }

            else if (StatsPageItem.IsSelected)
            {
                MainFrame.Navigate(typeof(JobPage));
                PageName.Text = "Work Graph Page";
            }
        }

      
    }
}
