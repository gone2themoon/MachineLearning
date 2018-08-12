using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace MachineLearning_Service
{

    
    public partial class MachineLearning_Service : ServiceBase
    {
       
        public MachineLearning_Service()
        {


            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("C:\\Temp\\MachineLearning_Service.log"))
                System.Diagnostics.EventLog.CreateEventSource("C:\\Temp\\MachineLearning_Service.log",
                                                                      "MachineLearning_Service.log");

            // the event log source by which the application is registered on the computer
            eventLog1.Source = "C:\\Temp\\MachineLearning_Service.log";

            // the event log 
            eventLog1.Log = "MachineLearning_Service.log";

        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("my service stoped");
            ProcessStartInfo info = new ProcessStartInfo(Properties.Settings.Default.ConsoleApp);
            info.UseShellExecute = false;
            info.RedirectStandardError = true;
            info.RedirectStandardInput = true;
            info.RedirectStandardOutput = true;
            info.CreateNoWindow = true;
            info.ErrorDialog = false;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process process = Process.Start(info);
        }
       

        protected override void OnStop()
        {
            eventLog1.WriteEntry("my service stoped");
        }
        protected override void OnContinue()
        {
            eventLog1.WriteEntry("my service is continuing in working");
           
        }

       
    }
}
