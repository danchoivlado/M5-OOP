using App1.BusinessLogic;
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
    public sealed partial class JobPage : Page
    {
        private bool IsToday =true;
        GraphBLL graph;
        public JobPage()
        {
            this.InitializeComponent();
            graph = new GraphBLL();
            this.ProductsGrid.ItemsSource = graph.GetEmployeeGraph();
        }



        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            graph = new GraphBLL();
            if (IsToday)
            {
                this.ProductsGrid.ItemsSource = graph.GetEmployeeGraph();
            }
            else
            {
                this.ProductsGrid.ItemsSource = graph.GetEmployeeGraphMounght();
            }
        }

        private void TimelineComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string TimeLine = e.AddedItems[0].ToString();

            switch (TimeLine)
            {
                case "This Month":
                    this.IsToday = false;
                    this.ProductsGrid.ItemsSource = graph.GetEmployeeGraphMounght();
                    break;
                case "Today":
                    this.IsToday = true;
                    this.ProductsGrid.ItemsSource = graph.GetEmployeeGraph();
                    break;
            }
        }
    }
}