using System;
using System.Net;
using System.Net.Mail;

namespace EmailHandler
{
    public class EmailSender
    {

        public void SendEmail(string to, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(EmailSettings.Default.From);
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;

                SmtpClient smtpServer = new SmtpClient(EmailSettings.Default.smtpServer);
                smtpServer.Port = EmailSettings.Default.Port;
                smtpServer.Credentials = new NetworkCredential(EmailSettings.Default.From, EmailSettings.Default.Password);
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
