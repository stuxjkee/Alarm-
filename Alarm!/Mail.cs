using System.Net;
using System.Net.Mail;
using System;
using System.Collections.Generic;


namespace Alarm_ {
    class Mail {
        public static string username = "info.monicam@gmail.com";
        public static string password = "monicampassword";
        
        public static void email_send(List<string> filenames) {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("alarma@gmail.com");
            mail.To.Add(Values.email);
            mail.Subject = "Alarm! Was a signal";
            mail.Body = "Possible danger at " + DateTime.Now.ToString("dd MMM HH:mm:ss");

            System.Net.Mail.Attachment attachment;

            foreach (string filename in filenames) {
                attachment = new System.Net.Mail.Attachment(filename);
                mail.Attachments.Add(attachment);
            }

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
    }
}
