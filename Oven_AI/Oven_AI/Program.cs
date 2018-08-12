using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NLog;
using System.IO;
using System.ServiceProcess;
using System.ComponentModel;

namespace Oven_AI
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        
        private static void Main(string[] args)
        {
            logger.Trace("Console Application Started!");
            bool bRes = true;
            
            // This console application is Started by the MachineLearning_Service 
            // and allowed to run until the service is stopped.
            while (bRes)
            {
                // Application Logic. run
                string path = Properties.Settings.Default.SourceFolderPath;

                // Check if A new Log File Exists
                bool isEmpty = !Directory.EnumerateFiles(path).Any();
              
                if (isEmpty)
                {
                    logger.Trace(path + " is empty. 0 Files Found");
                    //Sleep 10sec before executing again. Avoid filling up Logfiles.
                    Thread.Sleep((Properties.Settings.Default.Interval)*15);
                }
                else
                {

                    // Retrieve Folder Structure from Config File.
                    string sSourceFolderPath = Properties.Settings.Default.SourceFolderPath;
                    string sDestinationFolderPath = Properties.Settings.Default.DestinationFolderPath;
                    string sArchiveFolderPath = Properties.Settings.Default.ArchiveFolderPath;

                    //  Execute File handling. 
                    FileUtilities.ProcessDirectory(sSourceFolderPath);

                    // Sleep before executing again.
                    Thread.Sleep(Properties.Settings.Default.Interval);


                }
                    //  If Service is Still Running, continue Console Application execution.
                try
                {
                    using (ServiceController sc = new ServiceController("MachineLearning_Service"))
                    {
                        // Service Status Check.
                        bRes = sc.Status == ServiceControllerStatus.Running;
                    }
                }
                catch (ArgumentException ArgumentException) {
                    logger.Debug(ArgumentException);
                    
                }
                catch (Win32Exception Win32Exception) {
                    logger.Debug(Win32Exception);
                }


            }
            logger.Trace("Machine Learning Service has stopped");

        }
    }
}
