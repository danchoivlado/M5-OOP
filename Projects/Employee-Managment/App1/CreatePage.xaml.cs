using MySql.Data.MySqlClient;
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
    public sealed partial class CreatePage : Page
    {
        EmployeeBLL employeeBLL;
        GraphBLL GraphBLL;
        public CreatePage()
        {
            this.InitializeComponent();
            employeeBLL = new EmployeeBLL();
            this.GraphBLL = new GraphBLL();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (Validate())
            {
                employeeBLL.CreateEmployee(FirstNameTxtBox.Text, SecondNameTxtBox.Text, LastNameTxtBox.Text, EGNTxtBox.Text,
                    DutyTxtBox.Text, TownTxtBox.Text, PhoneNumberTxtBox.Text, CardNUmberTxtBox.Text);
                TextClear();
                this.ValidateTxtBox.Visibility = Visibility.Collapsed;
            }
        }

        private bool Validate()
        {
            if (FirstNameTxtBox.Text.Length == 0 || SecondNameTxtBox.Text.Length == 0 || LastNameTxtBox.Text.Length == 0 ||
                EGNTxtBox.Text.Length == 0 || PhoneNumberTxtBox.Text.Length == 0 || CardNUmberTxtBox.Text.Length == 0 ||
                TownTxtBox.Text.Length == 0 || DutyTxtBox.Text.Length == 0)
            {
                this.ValidateTxtBox.Visibility = Visibility.Visible;
                return false;
            }
            return true;
        }

        private void TextClear()
        {
            this.FirstNameTxtBox.Text = "";
            this.SecondNameTxtBox.Text = "";
            this.LastNameTxtBox.Text = "";
            this.EGNTxtBox.Text = "";
            this.PhoneNumberTxtBox.Text = "";
            this.CardNUmberTxtBox.Text = "";
            this.TownTxtBox.Text = "";
            this.DutyTxtBox.Text = "";
        }

        private void BtnScan_Click(object sender, RoutedEventArgs e)
        {
            App.StopWorker();
            this.BtnGet.Visibility = Visibility.Visible;
        }

        private void BtnGet_Click(object sender, RoutedEventArgs e)
        {
            this.CardNUmberTxtBox.Text = $"{GraphBLL.GetLast()}";
            this.BtnGet.Visibility = Visibility.Collapsed;
        }
    }
}

