using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Used to bring in more libraries
using System.Net.Mail;

namespace CIS407Project
{
    public class clsBusinessLayer
    {
        public static bool SendEmail(string Sender, string Recipient, string bcc, string cc,
        string Subject, string Body)
        {
            //Try to make sure the emails are sent out
            try {

            //Initializes variable and sets it as a new mail message
            MailMessage MyMailMessage = new MailMessage();

            //Initializes the form and sets the sender
            MyMailMessage.From = new MailAddress(Sender);

            //Adds the recipient to the for,
            MyMailMessage.To.Add(new MailAddress(Recipient));

            //if statement for the BCC field
            if (bcc != null && bcc != string.Empty) {
            //If there is a BCC then it will send to this person
            MyMailMessage.Bcc.Add(new MailAddress(bcc));
            }

            //if statement for the CC field
            if (cc != null && cc != string.Empty) {
            //If there is a CC then it will send to this person
            MyMailMessage.CC.Add(new MailAddress(cc));
            }

            //Adds the subject to the email
            MyMailMessage.Subject = Subject;

            //Adds the Body to the Email
            MyMailMessage.Body = Body;

            //Sets the email body to not just be plain text
            MyMailMessage.IsBodyHtml = true;

            //Sets the mail priority
            MyMailMessage.Priority = MailPriority.Normal;

            //Sets the transfer protocol
            SmtpClient MySmtpClient = new SmtpClient();

            //Sets the port
            MySmtpClient.Port = 25;
            //Sets the IP
            MySmtpClient.Host = "127.0.0.1";

            //Sends the Email
            MySmtpClient.Send(MyMailMessage);

            //Returns that it was a success
            return true;
            } catch (Exception ex) {

            //Returns that something failed
            return false;
            }

        }
    }
}