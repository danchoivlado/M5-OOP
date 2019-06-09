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
    public sealed partial class EditPage : Page
    {
        EmployeeInfo ClickedEmployee;
        EmployeeBLL employeeBLL;
        GraphBLL GraphBLL;

        public EditPage()
        {
            this.InitializeComponent();
            this.employeeBLL = new EmployeeBLL();
            this.GraphBLL = new GraphBLL();
        }

        private void FillFIelds()
        {
            this.FirstNameTxtBox.Text = ClickedEmployee.FirstName;
            this.SecondNameTxtBox.Text = ClickedEmployee.SecondName;
            this.LastNameTxtBox.Text = ClickedEmployee.LastName;
            this.EGNTxtBox.Text = ClickedEmployee.EGN;
            this.DutyTxtBox.Text = ClickedEmployee.Duty;
            this.TownTxtBox.Text = ClickedEmployee.Town;
            this.PhoneNumberTxtBox.Text = ClickedEmployee.TelephoneNumber;
            this.CardNUmberTxtBox.Text = ClickedEmployee.ScannerCardNumber;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.ClickedEmployee = (EmployeeInfo)e.Parameter;
            FillFIelds();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (Validate())
            {
                employeeBLL.EditEmployee(GetFieldInfo());
                this.Frame.Navigate(typeof(EmployeeInfoPage));
                this.ValidateTxtBox.Visibility = Visibility.Collapsed;
            }
        }

        private EmployeeInfo GetFieldInfo()
        {
            ClickedEmployee.FirstName = this.FirstNameTxtBox.Text;
            ClickedEmployee.SecondName = this.SecondNameTxtBox.Text;
            ClickedEmployee.LastName = this.LastNameTxtBox.Text;
            ClickedEmployee.EGN = this.EGNTxtBox.Text;
            ClickedEmployee.Duty = this.DutyTxtBox.Text;
            ClickedEmployee.Town = this.TownTxtBox.Text;
            ClickedEmployee.TelephoneNumber = this.PhoneNumberTxtBox.Text;
            ClickedEmployee.ScannerCardNumber = this.CardNUmberTxtBox.Text;
            return this.ClickedEmployee;
        }

        private void btnCencel_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EmployeeInfoPage));
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            employeeBLL.DeleteEmployee(GetFieldInfo());
            this.Frame.Navigate(typeof(EmployeeInfoPage));
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
    }
}

