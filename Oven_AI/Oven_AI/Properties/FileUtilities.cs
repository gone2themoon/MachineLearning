using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Oven_AI
{
    class FileUtilities
    { 
        // Set Instance of NLOG
        private static Logger logger = LogManager.GetCurrentClassLogger();
        
        // Process all files in the directory passed in, recurse on any directories 
        // that are found, and process the files they contain.
        public static void ProcessDirectory(string targetDirectory)
        {
            try
            {
                // Process the list of files found in the directory.
                string[] fileEntries = System.IO.Directory.GetFiles(targetDirectory);
                foreach (string fileName in fileEntries)
                    ProcessFile(fileName);
         

                // Recurse into subdirectories of this directory.
                string[] subdirectoryEntries = System.IO.Directory.GetDirectories(targetDirectory);
                foreach (string subdirectory in subdirectoryEntries)
                    ProcessDirectory(subdirectory);
            }
            catch (System.IO.DirectoryNotFoundException DirectoryNotFoundException) {
                logger.Debug(DirectoryNotFoundException);
            }
        }

        // Process Each File Individually.
        public static void ProcessFile(string path)
        {
            try
            {
                logger.Trace("File Found: " + path);
                LogConverter.ConvertLogFile(path);
                ArchiveFiles(path);
            }
            catch (System.IO.IOException IOException)
            {
                logger.Debug(IOException);
            }
        }

        // Once Finished Move to Archive Location
        public static void ArchiveFiles(string FileName)
        {
            try
            {
                string sourceFile = System.IO.Path.Combine(FileName);
                string newFileName = FileName.Remove(0, 16);
                string destFile = (Properties.Settings.Default.ArchiveFolderPath + newFileName);
                
                // Create a new target folder, if necessary.
                if (!System.IO.Directory.Exists(FileName))
                {
                    System.IO.Directory.CreateDirectory(Properties.Settings.Default.DestinationFolderPath);
                }

                // Move to Archive Folder
                if (System.IO.File.Exists(destFile))
                {
                    System.IO.File.Delete(destFile);
                }
                System.IO.File.Move(sourceFile, destFile);

            }
            catch (ArgumentException ArgumentException) {
                logger.Debug(ArgumentException);
            }
        }


    }



}

