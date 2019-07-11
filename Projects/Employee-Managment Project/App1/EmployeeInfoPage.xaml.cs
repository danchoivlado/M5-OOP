using App1.BusinessLogic;
using App1.Models;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EmployeeInfoPage : Page
    {

        public EmployeeInfoPage()
        {
            this.InitializeComponent();
            GraphBLL graph = new GraphBLL();
            this.ProductsGrid.ItemsSource = graph.GetAllEmployeeInfo();
        }

        private void ProductsGrid_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Frame.Navigate(typeof(EditPage), e.ClickedItem);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreatePage));
        }
    }
}
