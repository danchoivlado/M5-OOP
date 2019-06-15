using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using App1.Models;
using System.Threading;

namespace App1
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public sealed partial class App : Application
    {
        public static bool BGWorker = true;
        DBContext EmpContex;
        // Background
        private BackgroundWorker bw = new BackgroundWorker();

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();

            BGWorker = true;
            this.EmpContex = new DBContext();
            this.Suspending += OnSuspending;

            CheckDate();
            //Creates BackgroundWorker
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            //bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerAsync();
        }


        /// <summary>
        /// Works in the Background 
        /// 1 Checks for arduino input
        /// 2 Then Checks if Code from the Reader is valid
        /// 3 After That Check is there any Employee int the DataBase with this code
        /// 4 Repeat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            //Connects to ARDUINO
            BackgroundWorker worker = sender as BackgroundWorker;
            SerialPort mySerialPort = new SerialPort("COM4");
            mySerialPort.BaudRate = 9600;
            mySerialPort.Open();

            //Used to Power Yellow LED ON
            mySerialPort.Write("CommunicationON");
            while (true)
            {
                string cmd = string.Empty;
                //Used to Read all 10 Serial Sends Strings from READER 
                for (int i = 1; i <= 10; i++)
                {
                    cmd = cmd + $"{(mySerialPort.ReadLine())}";
                    cmd = cmd.Substring(0, cmd.Length - 1);
                }

                //If Someone Pressed "SCAN BTN" int the "CREATE PAGE"
                if (BGWorker == false)
                {
                    Lastscaned CardNumber = new Lastscaned()
                    {
                        ScannerCardNumber = $"{cmd}"
                    };
                    EmpContex.Lastscaned.Add(CardNumber);
                    EmpContex.SaveChanges();
                    //Add to Database The Scanned code 
                    //To be used when pressed "GET BTN"

                    BGWorker = true;
                    //Send to ARDUINO not to wait for Person
                    mySerialPort.Write("ScanedCardForRegistration");
                }
                //Checks for invalid codes
                else if (cmd.Length > 3 && cmd.Substring(cmd.Length - 2) != "83")
                {
                    //Gets the employee with the SAME Code 
                    var CurEmp = this.EmpContex.Employees.FirstOrDefault(x => x.ScannerCardNumber == cmd);
                    if (CurEmp == null)
                    {
                        // 0 - Sent to ARDUINO that there is no Employee with this Code
                        mySerialPort.Write("0");
                    }
                    else
                    {
                        //Sends to ARDUINO the FirsName and LastName of the currently scanned Employee
                        mySerialPort.Write($"{CurEmp.FirstName} {CurEmp.LastName}");
                        Employeegraph GraphEmployee = this.EmpContex.Employeegraph.FirstOrDefault(x => x.EmployeeId == CurEmp.Id);
                        //If this Employee comes to WORK
                        if (GraphEmployee == null)
                        {
                            GraphEmployee = new Employeegraph()
                            {
                                EmployeeId = CurEmp.Id,
                                CameWork = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}",
                                LeaveWork = "Didnt Leave",
                                CurrentDate = $"{DateTime.Now.Day}:{DateTime.Now.Month}"
                            };
                            //ADDS to database currently passed Employee
                            this.EmpContex.Employeegraph.Add(GraphEmployee);
                        }
                        else
                        {
                            // If Employee Leaves Work
                            if (GraphEmployee.LeaveWork == "Didnt Leave")
                            {
                                //Calculate How many hours he worked
                                GraphEmployee.LeaveWork = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}";
                            }
                            //If Employee came to work for SECOND Time
                            else
                            {
                                GraphEmployee.LeaveWork = "Didnt Leave";
                            }
                        }
                        this.EmpContex.SaveChanges();
                    }

                }

            }
        }

        /// <summary>
        /// Makes BGWorker = false;
        /// </summary>
        public static void StopWorker()
        {
            //Say that sended Arduino CODE is Used for Registration
            BGWorker = false;
        }
        /// <summary>
        ///  Makes BGWorker = true;
        /// </summary>
        public static void StartWorker()
        {
            BGWorker = true;
        }

        //private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    //Debug.WriteLine (e.ProgressPercentage.ToString() + "%");
        //    Debug.WriteLine(e.ProgressPercentage.ToString());
        //}

        /// <summary>
        /// Checks if the its tomorow 
        /// And if it is Adds to Database all came to work employee to Employeegraphmounght
        /// </summary>
        private void CheckDate()
        {
            //Checks if there is anything in Employeegraph TABLE
            if (EmpContex.Employeegraph.Count() > 0)
            {
                if (this.EmpContex.Employeegraph.First().CurrentDate.Split(new string[] { ":" }, StringSplitOptions.None).First() != $"{DateTime.Now.Day}")
                {
                    foreach (var emp in this.EmpContex.Employeegraph)
                    {
                        if (emp.LeaveWork != "Didnt Leave")
                        {
                            Employeegraphmounght CurEmp = new Employeegraphmounght();
                            CurEmp.EmployeeId = emp.EmployeeId;
                            CurEmp.CurrentDate = emp.CurrentDate;
                            CurEmp.HoursWorked = (DateTime.Parse(emp.LeaveWork).Subtract(DateTime.Parse(emp.CameWork))).ToString().Substring(0, 5);
                            this.EmpContex.Employeegraphmounght.Add(CurEmp);
                        }
                        this.EmpContex.Employeegraph.Remove(emp);
                    }
                    this.EmpContex.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // When the navigation stack isn't restored navigate to the first page,
                    // configuring the new page by passing required information as a navigation
                    // parameter
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }
                // Ensure the current window is active
                Window.Current.Activate();
            }
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
