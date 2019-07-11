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
        private bool IsToday = true;
        GraphBLL graph;
        private bool AutomaticCheckOnn;
        DispatcherTimer timer = new DispatcherTimer();

        public JobPage()
        {
            this.InitializeComponent();
            graph = new GraphBLL();
            this.ProductsGrid.ItemsSource = graph.GetEmployeeGraph();
            // timer
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        /// <summary>
        /// Ticks in 2 seconds for Automatic Refresh checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, object e)
        {
            if (AutomaticCheckOnn)
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
        }

        /// <summary>
        /// Refreshes the grid of recently commed employees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// When the user select timezone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// When checkbox Checked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutomaticRefreshCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.AutomaticCheckOnn = true;
        }

        /// <summary>
        /// When checkbox unchecked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutomaticRefreshCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.AutomaticCheckOnn = false;
        }
    }
}