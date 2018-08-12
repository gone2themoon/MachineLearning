using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using NLog;

namespace Oven_AI
{
    public class LogConverter
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();


        public static void ConvertLogFile(string FileName)
        {
            try
            {
                string sDestinationFolderPath = Properties.Settings.Default.DestinationFolderPath;
                string senderStr = Properties.Settings.Default.senderEmail;
                string receiverStr = Properties.Settings.Default.receiverEmail;
                string subjectStr = Properties.Settings.Default.emailSubject;
                string clientStr = Properties.Settings.Default.emailClient;
                string messageStr = "";
                string TracePattern = @"TRACE";
                string NotSendPattern = @"NotSend";
                string gets_serialNoPattern = @"s_lot=([^\n\r]{1,28})";
                string gets_programPattern = @"s_program=([^\n\r]{1,14})";
                string getn_maxValuePattern = @"n_maxValue=(?<max>[^\n\r]{1,3})";
                string getn_minValuePattern = @"n_minValue=([^\n\r]{1,3})";
                string getn_toleranceBottomPattern = @"n_toleranceBottom=([^\n\r]{1,3})";
                string getn_toleranceTopPattern = @"n_toleranceTop=([^\n\r]{1,3})";
                string getn_setValuePattern = @"n_setValue=([^\n\r]{1,3})";
                string gets_statePattern = @"s_state=([^\n\r]{1,2})";
                string line = String.Empty;
                bool bClassifiedResults = false;
                bool bRes = false;

                // Open the Log file for reading
                TextReader reader = new StreamReader(File.OpenRead(FileName));

                // Read each line in the file
                while ((line = reader.ReadLine()) != null)
                {
                    // Try to match the line using regular expressions
                    line = line.Replace("\"", "");
                    Match parsed = Regex.Match(line, TracePattern);
                    if (parsed.Success)
                    {
                        Match parsed1 = Regex.Match(line, NotSendPattern);
                        if (parsed1.Success)
                        {
                        }
                        else
                        {
                            // If we get a regex Match, we pass that line in here for further matching.
                            Match s_serialNo = Regex.Match(line, gets_serialNoPattern);
                            Match s_program = Regex.Match(line, gets_programPattern);
                            MatchCollection n_maxValue_matches = Regex.Matches(line, getn_maxValuePattern);
                            MatchCollection n_minValue_matches = Regex.Matches(line, getn_minValuePattern);
                            MatchCollection n_toleranceBottom_matches = Regex.Matches(line, getn_toleranceBottomPattern);
                            MatchCollection n_toleranceTop_matches = Regex.Matches(line, getn_toleranceTopPattern);
                            MatchCollection n_setValue_matches = Regex.Matches(line, getn_setValuePattern);
                            MatchCollection s_state_matches = Regex.Matches(line, gets_statePattern);

                            if (!System.IO.Directory.Exists(FileName))
                            {
                                System.IO.Directory.CreateDirectory(Properties.Settings.Default.DestinationFolderPath);
                            }
                            else { }

                            using (StreamWriter sw = File.AppendText(Properties.Settings.Default.DestinationFolderPath + "\\" + "training.txt"))

                            {

                                try
                                {
                                    string newRouter, designatedOperation;
                                    string[] sfcList = new string[1];
                                    newRouter = Properties.Settings.Default.mesRoute;
                                    designatedOperation = Properties.Settings.Default.mesOperation;
                                    string sResult = "";


                                    if (line != null)
                                    {
                                        // For speed of processing I've only selected 3 Zones from 14 for Processing.
                                        // This may me increased by uncommenting the rows here.
                                        String writeOut = (s_serialNo.Groups[1].Value + "," + s_program.Groups[1].Value
                                        //+ ",DriveL1," + n_maxValue_matches[1].Groups[1].Value + "," + n_minValue_matches[1].Groups[1].Value + "," + n_toleranceBottom_matches[1].Groups[1].Value + "," + n_toleranceTop_matches[1].Groups[1].Value + "," + n_setValue_matches[1].Groups[1].Value + "," + s_state_matches[1].Groups[1].Value
                                        //+ ",HtTopZ01," + n_maxValue_matches[2].Groups[1].Value + "," + n_minValue_matches[2].Groups[1].Value + "," + n_toleranceBottom_matches[2].Groups[1].Value + "," + n_toleranceTop_matches[2].Groups[1].Value + "," + n_setValue_matches[2].Groups[1].Value + "," + s_state_matches[2].Groups[1].Value
                                        //+ ",HtTopZ02," + n_maxValue_matches[3].Groups[1].Value + "," + n_minValue_matches[3].Groups[1].Value + "," + n_toleranceBottom_matches[3].Groups[1].Value + "," + n_toleranceTop_matches[3].Groups[1].Value + "," + n_setValue_matches[3].Groups[1].Value + "," + s_state_matches[3].Groups[1].Value
                                        //+ ",HtTopZ03," + n_maxValue_matches[4].Groups[1].Value + "," + n_minValue_matches[4].Groups[1].Value + "," + n_toleranceBottom_matches[4].Groups[1].Value + "," + n_toleranceTop_matches[4].Groups[1].Value + "," + n_setValue_matches[4].Groups[1].Value + "," + s_state_matches[4].Groups[1].Value
                                        //+ ",HtTopZ04," + n_maxValue_matches[5].Groups[1].Value + "," + n_minValue_matches[5].Groups[1].Value + "," + n_toleranceBottom_matches[5].Groups[1].Value + "," + n_toleranceTop_matches[5].Groups[1].Value + "," + n_setValue_matches[5].Groups[1].Value + "," + s_state_matches[5].Groups[1].Value
                                        //+ ",HtTopZ05," + n_maxValue_matches[6].Groups[1].Value + "," + n_minValue_matches[6].Groups[1].Value + "," + n_toleranceBottom_matches[6].Groups[1].Value + "," + n_toleranceTop_matches[6].Groups[1].Value + "," + n_setValue_matches[6].Groups[1].Value + "," + s_state_matches[6].Groups[1].Value
                                        //+ ",HtTopZ06," + n_maxValue_matches[7].Groups[1].Value + "," + n_minValue_matches[7].Groups[1].Value + "," + n_toleranceBottom_matches[7].Groups[1].Value + "," + n_toleranceTop_matches[7].Groups[1].Value + "," + n_setValue_matches[7].Groups[1].Value + "," + s_state_matches[7].Groups[1].Value
                                        //+ ",HtTopZ07," + n_maxValue_matches[8].Groups[1].Value + "," + n_minValue_matches[8].Groups[1].Value + "," + n_toleranceBottom_matches[8].Groups[1].Value + "," + n_toleranceTop_matches[8].Groups[1].Value + "," + n_setValue_matches[8].Groups[1].Value + "," + s_state_matches[8].Groups[1].Value
                                        + ",HtTopP1," + n_maxValue_matches[9].Groups[1].Value + "," + n_minValue_matches[9].Groups[1].Value + "," + n_toleranceBottom_matches[9].Groups[1].Value + "," + n_toleranceTop_matches[9].Groups[1].Value + "," + n_setValue_matches[9].Groups[1].Value + "," + s_state_matches[9].Groups[1].Value
                                        + ",HtTopP2," + n_maxValue_matches[10].Groups[1].Value + "," + n_minValue_matches[10].Groups[1].Value + "," + n_toleranceBottom_matches[10].Groups[1].Value + "," + n_toleranceTop_matches[10].Groups[1].Value + "," + n_setValue_matches[10].Groups[1].Value + "," + s_state_matches[10].Groups[1].Value
                                        + ",HtTopP3," + n_maxValue_matches[11].Groups[1].Value + "," + n_minValue_matches[11].Groups[1].Value + "," + n_toleranceBottom_matches[11].Groups[1].Value + "," + n_toleranceTop_matches[11].Groups[1].Value + "," + n_setValue_matches[11].Groups[1].Value + "," + s_state_matches[11].Groups[1].Value
                                        //+ ",HtBottomZ01," + n_maxValue_matches[12].Groups[1].Value + "," + n_minValue_matches[12].Groups[1].Value + "," + n_toleranceBottom_matches[12].Groups[1].Value + "," + n_toleranceTop_matches[12].Groups[1].Value + "," + n_setValue_matches[12].Groups[1].Value + "," + s_state_matches[12].Groups[1].Value
                                        //+ ",HtBottomZ02," + n_maxValue_matches[13].Groups[1].Value + "," + n_minValue_matches[13].Groups[1].Value + "," + n_toleranceBottom_matches[13].Groups[1].Value + "," + n_toleranceTop_matches[13].Groups[1].Value + "," + n_setValue_matches[13].Groups[1].Value + "," + s_state_matches[13].Groups[1].Value
                                        //+ ",HtBottomZ03," + n_maxValue_matches[14].Groups[1].Value + "," + n_minValue_matches[14].Groups[1].Value + "," + n_toleranceBottom_matches[14].Groups[1].Value + "," + n_toleranceTop_matches[14].Groups[1].Value + "," + n_setValue_matches[14].Groups[1].Value + "," + s_state_matches[14].Groups[1].Value
                                        //+ ",HtBottomZ04," + n_maxValue_matches[15].Groups[1].Value + "," + n_minValue_matches[15].Groups[1].Value + "," + n_toleranceBottom_matches[15].Groups[1].Value + "," + n_toleranceTop_matches[15].Groups[1].Value + "," + n_setValue_matches[15].Groups[1].Value + "," + s_state_matches[15].Groups[1].Value
                                        //+ ",HtBottomZ05," + n_maxValue_matches[16].Groups[1].Value + "," + n_minValue_matches[16].Groups[1].Value + "," + n_toleranceBottom_matches[16].Groups[1].Value + "," + n_toleranceTop_matches[16].Groups[1].Value + "," + n_setValue_matches[16].Groups[1].Value + "," + s_state_matches[16].Groups[1].Value
                                        //+ ",HtBottomZ06," + n_maxValue_matches[17].Groups[1].Value + "," + n_minValue_matches[17].Groups[1].Value + "," + n_toleranceBottom_matches[17].Groups[1].Value + "," + n_toleranceTop_matches[17].Groups[1].Value + "," + n_setValue_matches[17].Groups[1].Value + "," + s_state_matches[17].Groups[1].Value
                                        //+ ",HtBottomZ07," + n_maxValue_matches[18].Groups[1].Value + "," + n_minValue_matches[18].Groups[1].Value + "," + n_toleranceBottom_matches[18].Groups[1].Value + "," + n_toleranceTop_matches[18].Groups[1].Value + "," + n_setValue_matches[18].Groups[1].Value + "," + s_state_matches[18].Groups[1].Value
                                        + ",HtBottomP1," + n_maxValue_matches[19].Groups[1].Value + "," + n_minValue_matches[19].Groups[1].Value + "," + n_toleranceBottom_matches[19].Groups[1].Value + "," + n_toleranceTop_matches[19].Groups[1].Value + "," + n_setValue_matches[19].Groups[1].Value + "," + s_state_matches[19].Groups[1].Value
                                        + ",HtBottomP2," + n_maxValue_matches[20].Groups[1].Value + "," + n_minValue_matches[20].Groups[1].Value + "," + n_toleranceBottom_matches[20].Groups[1].Value + "," + n_toleranceTop_matches[20].Groups[1].Value + "," + n_setValue_matches[20].Groups[1].Value + "," + s_state_matches[20].Groups[1].Value
                                        + ",HtBottomP3," + n_maxValue_matches[21].Groups[1].Value + "," + n_minValue_matches[21].Groups[1].Value + "," + n_toleranceBottom_matches[21].Groups[1].Value + "," + n_toleranceTop_matches[21].Groups[1].Value + "," + n_setValue_matches[21].Groups[1].Value + "," + s_state_matches[21].Groups[1].Value);
                                        // Send Collected data to a Text file for Processing.
                                        if (n_maxValue_matches[21] != null)
                                        {
                                            // Only Classify When a valid Barcode has been found. This will begin with "/"
                                            if (s_serialNo.Groups[1].Value.StartsWith("/"))
                                            {

                                                bClassifiedResults = ClassifyUsingPython(writeOut);
                                                if (bClassifiedResults)
                                                {
                                                    // If the Classification is Positive, this result can be appended to the Training Data.
                                                    sw.WriteLine(writeOut);
                                                }
                                                else
                                                {
                                                    // Part is deemed to be bad. Execute Alerts and Processing actions.

                                                    // 1. Send Email Alert Regarding Bad Part Detection.
                                                    Email email = new Email();
                                                    messageStr = writeOut;
                                                    bRes = email.sendMail(senderStr, receiverStr, senderStr, messageStr, clientStr);
                                                    if (!bRes) {
                                                        logger.Error("Data Point: " + writeOut);
                                                    }
                                                    // 2. Call ChangeProduction here.
                                                    sfcList[0] = writeOut.Substring(13, 13);
                                                    ManufacturingExecution manufacturingExecution = new ManufacturingExecution();
                                                    //manufacturingExecution.changeProduction(newRouter, designatedOperation, sfcList, ref sResult);
                                                    manufacturingExecution.NCLog(messageStr, writeOut, Properties.Settings.Default.mesResource);
                                                }

                                            }
                                        }
                                    }
                                }
                                catch (System.ArgumentOutOfRangeException ArgumentOutOfRangeException)
                                {
                                    logger.Trace("Error processing Line: " + line);
                                }


                            }
                        }

                    }

                }

                //Finish off any open elements 
                reader.Close();
                reader = null;

            }
            catch (System.IO.FileNotFoundException fileNotFoundException)
            {
                logger.Trace(fileNotFoundException);
            }
        }

        /// <summary>
        /// ClassifyUsingPython:
        /// Used to Execute an external Python Script that implements Scikit Learn.
        /// A module that specialises in Machine Learning.
        /// </summary>
        /// <param name="writeOut"></param>
        /// <returns>
        /// The results are returned and used to Determine if an item is Scrapped or not.
        /// e.g. "[210],[245.4],[274]"
        /// These are the 3 predicted values of 3 classifications 
        /// </returns>
        private static bool ClassifyUsingPython(string writeOut)
        {

            try
            {
                // Extract Instance Zone Temperatures.
                string zone1 = Properties.Settings.Default.zone1;
                string zone2 = Properties.Settings.Default.zone2;
                string zone3 = Properties.Settings.Default.zone3;
                int startPos = writeOut.LastIndexOf(zone1) + zone1.Length + 1;
                string tempZone1 = writeOut.Substring(startPos, 3);
                startPos = writeOut.LastIndexOf(zone2) + zone2.Length + 1;
                string tempZone2 = writeOut.Substring(startPos, 3);
                startPos = writeOut.LastIndexOf(zone3) + zone3.Length + 1;
                string tempZone3 = writeOut.Substring(startPos, 3);

                string pythonScript = Properties.Settings.Default.PythonScript;

                // Call Python Script to handle machine learning.
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo(Properties.Settings.Default.PythonPath, pythonScript)
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardError = true,

                };
                p.Start();

                // Handle Response from Python Script.
                using (StreamReader reader = p.StandardOutput)
                {
                    // Here the Result of the Python Script is returned and Parsed.
                    // It is set to return the 3 Zone Temperature Predictions.
                    // These 3 values are used to verify if the current Data points are good or Bad.
                    string result = reader.ReadToEnd();
                    int endPos = result.IndexOf("] [");
                    string predictedtempZone1 = result.Substring(1, 3);
                    string predictedtempZone2 = result.Substring(endPos + 3, 3);
                    endPos = result.IndexOf("]", endPos + 1);
                    string predictedtempZone3 = result.Substring(endPos + 3, 3);

                    Int32 predictedZone1 = 0;
                    Int32.TryParse(predictedtempZone1, out predictedZone1);

                    Int32 predictedZone2 = 0;
                    Int32.TryParse(predictedtempZone2, out predictedZone2);

                    Int32 predictedZone3 = 0;
                    Int32.TryParse(predictedtempZone3, out predictedZone3);

                    Int32 tZone1 = 0;
                    Int32.TryParse(tempZone1, out tZone1);

                    Int32 tZone2 = 0;
                    Int32.TryParse(tempZone2, out tZone2);

                    Int32 tZone3 = 0;
                    Int32.TryParse(tempZone3, out tZone3);
                    int t = Properties.Settings.Default.iTolerance;

                    if ((tZone1 > (predictedZone1 - t)) & (tZone1 < (predictedZone1 + t)))
                    {
                        if ((tZone2 > (predictedZone2 - t)) & (tZone2 < (predictedZone2 + t)))
                        {
                            if ((tZone3 > (predictedZone3 - t)) & (tZone3 < (predictedZone3 + t)))
                            {

                                // All 3 Temperatures Match and the Current PCB is Good.
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                       
                    }
                    else
                    {
                        // One or more Temperature Zones do not match and the PCB is Bad.
                        return false;
                    }

                }

            }

            // Handle Errors.
            catch (IOException IOException)
            {
                // Log Error.
                logger.Trace(IOException.Message.ToString());
                return false;
            }
        }




    }
}
