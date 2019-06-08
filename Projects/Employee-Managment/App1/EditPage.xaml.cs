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

        public EditPage()
        {
            this.InitializeComponent();
            this.employeeBLL = new EmployeeBLL();
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
            employeeBLL.EditEmployee(GetFieldInfo());
            this.Frame.Navigate(typeof(EmployeeInfoPage));
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
    }
}

