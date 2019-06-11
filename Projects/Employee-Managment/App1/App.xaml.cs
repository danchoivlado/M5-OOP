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
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerAsync();
        }

       

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            SerialPort mySerialPort = new SerialPort("COM4");

            mySerialPort.BaudRate = 9600;
            //mySerialPort.Parity = Parity.None;
            //mySerialPort.StopBits = StopBits.One;
            //mySerialPort.DataBits = 8;
            //mySerialPort.Handshake = Handshake.None;
            //mySerialPort.RtsEnable = true;
            // mySerialPort.


            // mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            mySerialPort.Open();
            while (true)
            {
                // Perform a time consuming operation and report progress.
                //System.Threading.Thread.Sleep(1000);
                //worker.ReportProgress(i);

                string cmd = string.Empty;
                for (int i = 1; i <= 10; i++)
                {
                    cmd = cmd + $"{(mySerialPort.ReadLine())}";
                    cmd = cmd.Substring(0, cmd.Length - 1);
                }
                ;
                if (cmd.Length > 0)
                {
                    Debug.WriteLine(cmd);
                    //TODO Method 

                }
                if (BGWorker == false)
                {

                    Lastscaned CardNumber = new Lastscaned()
                    {
                        ScannerCardNumber = $"{cmd}"
                    };
                    EmpContex.Lastscaned.Add(CardNumber);
                    EmpContex.SaveChanges();
                    BGWorker = true;
                    mySerialPort.WriteLine("3");
                }
                else if (cmd.Length > 3)
                {
                    // string trimed = cmd.Substring(0,cmd.Length);
                    var CurEmp = this.EmpContex.Employees.FirstOrDefault(x => x.ScannerCardNumber == cmd);
                    if (CurEmp == null)
                    {
                        mySerialPort.Write("0");
                    }
                    else
                    {
                        mySerialPort.Write("1");
                        Employeegraph GraphEmployee = this.EmpContex.Employeegraph.FirstOrDefault(x => x.EmployeeId == CurEmp.Id);
                        if (GraphEmployee == null)
                        {
                            GraphEmployee = new Employeegraph()
                            {
                                EmployeeId = CurEmp.Id,
                                CameWork = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}",
                                LeaveWork = "Didnt Leave",
                                CurrentDate = $"{DateTime.Now.Day}:{DateTime.Now.Month}"
                            };
                            this.EmpContex.Employeegraph.Add(GraphEmployee);

                        }
                        else
                        {
                            if (GraphEmployee.LeaveWork == "Didnt Leave")
                            {
                                GraphEmployee.LeaveWork = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}";
                            }
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

        public static void StopWorker()
        {
            BGWorker = false;
        }

        public static void StartWorker()
        {
            BGWorker = true;
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Debug.WriteLine (e.ProgressPercentage.ToString() + "%");
            Debug.WriteLine(e.ProgressPercentage.ToString());
        }

        private void CheckDate()
        {
            if (this.EmpContex.Employeegraph.First().CurrentDate.Split(new string[] { ":" }, StringSplitOptions.None).First() != $"{DateTime.Now.Day}")
            {
                foreach (var emp in this.EmpContex.Employeegraph)
                {
                    this.EmpContex.Employeegraph.Remove(emp);
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
