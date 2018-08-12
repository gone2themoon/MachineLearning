using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.IO;
using NLog;

namespace Oven_AI
{
    class Email
    {
       private static Logger logger = LogManager.GetCurrentClassLogger();

        //E-mailing funtion
        // Test SFC Y0007ABC12340
        public bool sendMail(string senderStr, string receiverStr, string subjectStr, string messageStr, string clientStr)
        {
        try
           {
                // create mail message object
                MailMessage message = new MailMessage();

                string datetime;
                datetime = DateTime.Now.ToString();

                //Mail Address object to instanciate sender
                MailAddress fromMail = new MailAddress(senderStr);
                message.From = fromMail;

                //Adding multiple receivers can be set in the Properties section.
                foreach (var address in receiverStr.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    message.To.Add(address);
                }
                
                //subject for mail message
                message.Subject = subjectStr;
                
                //body for mail message
                message.Body = @messageStr + " @" + datetime ;
                
                //client server for mail message
                SmtpClient client = new SmtpClient(clientStr);
                
                // Credentials are necessary if the server requires the client 
                // to authenticate before it will send e-mail on the client's behalf.
                // This is the case in the Kostal Environment using Ms Exchange.
                client.UseDefaultCredentials = true;
                client.Send(message);

                // Log Email sent.
                logger.Trace("Email Sent :" + datetime);
                return true;
            }
            catch (Exception ex)
            {
                //logging error events
               logger.Error("SendMail Function " + ex.Message.ToString(), false);
               return false;
            }





            //log Trace message
            // Trace("Exit in Class: Email, Method: sendMail() ");
        }

       

        // {
        //logging error
        //         fileFunct.errorLog("sendInfoToEngineer Function \n" + ex.ToString(), true);
        // }

        //log Trace message
        //   Trace("Enter in Class: Email, Method: sendInfoToEngineer() ");
    }
        }
    


    

