using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using NLog;

namespace parsingLogFiles
{
    public class LogConverter
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void ConvertLogFile(string FileName)
        {
            try
            {
                string sDestinationFolderPath = Properties.Settings.Default.DestinationFolderPath;
                string TracePattern = @"TRACE";
                string NotSendPattern = @"NotSend";
                string BarcodePattern = @"BarcodeScanned";

                //string DateTimePattern =@"(?<year>\d{4})-(?<month>\d{1,2})" +
                //    @"-(?<day>\d{1,2})T(?<hour>\d{1,2})" +
                //    @":(?<minutes>\d{1,2}):(?<seconds>\d{1,2})";

                string DateTimePattern = @"(?<date>(?<year>\d{4})-(?<month>\d{1,2})" +
                    @"-(?<day>\d{1,2}))T(?<time>(?<hour>\d{1,2}):" +
                    @"(?<minutes>\d{1,2}):(?<seconds>\d{1,2}))";

                string gets_serialNoPattern = @"s_lot=([^\n\r]{1,28})";
                string gets_programPattern = @"s_program=([^\n\r]{1,14})";
                string getn_maxValuePattern = @"n_maxValue=(?<max>[^\n\r]{1,3})";
                //string getn_maxValuePattern = @"n_maxValue=([^\n\r]{1,3})";
                string getn_minValuePattern = @"n_minValue=([^\n\r]{1,3})";
                string getn_toleranceBottomPattern = @"n_toleranceBottom=([^\n\r]{1,3})";
                string getn_toleranceTopPattern = @"n_toleranceTop=([^\n\r]{1,3})";
                string getn_setValuePattern = @"n_setValue=([^\n\r]{1,3})";
                string gets_statePattern = @"s_state=([^\n\r]{1,2})";







                //string getSFCPattern = @"s_serialNo=([^\n\r]{1,28})";
                //string getSFCPattern = @"s_serialNo=([^\n\r]{1,28})";

                //string Pattern = @"(?<date>(?<day>\d{1,2})/" +
                //  @"(?<month>\d{1,2})/(?<year>(?:\d{4}|\d{2}))" +
                //  @"(?x))\t(?<time>(?<hour>\d{2}):(?<minutes>\d{2}))\t" +
                //  @"(?<action>.*)\t(?<record>.*)\t(?<user>\w*)";
                string line = String.Empty;

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
                            // If we get a regex Match, we pass
                            // the XML writer off to a method that will
                            // use the Match groups to generate XML data
                            // inside our XML document
                            //  WriteAsXML(line, xmlFile);
                            Match s_serialNo = Regex.Match(line, gets_serialNoPattern);
                            Match s_program = Regex.Match(line, gets_programPattern);

                            //Match n_maxValue = Regex.Match(line, getn_maxValuePattern);
                            MatchCollection n_maxValue_matches = Regex.Matches(line, getn_maxValuePattern);
                            MatchCollection n_minValue_matches = Regex.Matches(line, getn_minValuePattern);
                            MatchCollection n_toleranceBottom_matches = Regex.Matches(line, getn_toleranceBottomPattern);
                            MatchCollection n_toleranceTop_matches = Regex.Matches(line, getn_toleranceTopPattern);
                            MatchCollection n_setValue_matches = Regex.Matches(line, getn_setValuePattern);
                            MatchCollection s_state_matches = Regex.Matches(line, gets_statePattern);

                            //foreach (Match match in n_maxValue_matches)
                            //    {
                            //    Console.WriteLine("Area Code:        {0}", match.Groups[1].Value);
                            //}
                            //string value = n_maxValue_matches[1].Groups[1].Value;
                            // value = n_toleranceTop_matches[2].Groups[1].Value;
                            // value = n_maxValue_matches[3].Groups[1].Value;

                            //  WriteAsText(
                            //using (StreamWriter sw = File.AppendText("C:\\Temp\\MasterLog.txt"))
                            if (!System.IO.Directory.Exists(FileName))
                            {
                                System.IO.Directory.CreateDirectory(Properties.Settings.Default.DestinationFolderPath);
                            }
                            else { }

                            using (StreamWriter sw = File.AppendText(Properties.Settings.Default.DestinationFolderPath + "\\" + "training.txt"))

                            {

                                try
                                {
                                    if (line != null)
                                    {
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
                                        // Send Collected data to a Tet file for Processing.
                                        // Or call the Python Classification Module on the writeOutObject
                                        if (n_maxValue_matches[21] != null)
                                        {
                                            if (s_serialNo.Groups[1].Value.StartsWith("/")){
                                                sw.WriteLine(writeOut);
                                            }
                                        }
                                    }
                                }
                                catch (System.ArgumentOutOfRangeException ArgumentOutOfRangeException)
                                {
                                    logger.Trace("Error processing Line: " + line + ". MESSAGE: " + ArgumentOutOfRangeException.Message);
                                }
                            

                            }
                        }

                    }

                }

                //Finish off any open elements 
                //textFile.Flush();
                reader.Close();
                reader = null;
                //textFile.Close();
                //textFile = null;
            }
            catch (System.IO.FileNotFoundException fileNotFoundException)
            {
                logger.Trace(fileNotFoundException);
            }
        }

        //private static void WriteAsText(string line, TextWriter textFile)
        //{
        //    textFile.WriteLine(line);
        //}

        private static string formatline(string line)
        {
            line = line.Replace("\"", "");
            return line;
        }

        //public static void WriteAsXML(string line, XmlTextWriter writer)

        // //    public static void WriteAsXML(Match regexMatch,
        //   //                            XmlTextWriter writer)
        //{
        //    // Open a new 'Entry' element
        //    writer.WriteStartElement("Entry");

        //    // Write out each date element value as a separate node
        //    // writer.WriteElementString("date",
        //    //                          regexMatch.Groups["date"].Value);

        //    //writer.WriteElementString("year",
        //    //                          regexMatch.Groups["year"].Value);

        //    //writer.WriteElementString("month",
        //    //                          regexMatch.Groups["month"].Value);

        //    //writer.WriteElementString("day",
        //    //                          regexMatch.Groups["day"].Value);

        //    //// Time: Full format, hours, and minutes
        //    //writer.WriteElementString("time",
        //    //                          regexMatch.Groups["time"].Value);
        //    //writer.WriteElementString("hour",
        //    //                          regexMatch.Groups["hour"].Value);
        //    //writer.WriteElementString("minutes",
        //    //                          regexMatch.Groups["minutes"].Value);
        //    //writer.WriteElementString("seconds",
        //    //                          regexMatch.Groups["seconds"].Value);

        //    //// Record ,actions and users
        //    //writer.WriteElementString("action",
        //    //                          regexMatch.Groups["action"].Value);
        //    //writer.WriteElementString("record",
        //    //                          regexMatch.Groups["record"].Value);
        //    //writer.WriteElementString("user",
        //    //                          regexMatch.Groups["user"].Value);

        //    //writer.WriteElementString("barcode",regexMatch.Groline);

        //    writer.WriteElementString("PART_OUT",line);
            


        //    writer.WriteEndElement();
        //}
    }
}
