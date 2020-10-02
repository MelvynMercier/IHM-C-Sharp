using Microsoft.EntityFrameworkCore;
using Models;
using Provider.EntityFramework;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MailService
    {
        private readonly Context context;

        public MailService(Context context)
        {
            this.context = context;
        }

        /// <summary>
        /// Méthode permettant d'envoyer un mail à un expediteur
        /// </summary>
        public async Task SendMail(string smtp, string from, string to, string obj, string msg, string username, string password)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(smtp);

                mail.From = new MailAddress(from);
                mail.To.Add(to);
                mail.Subject = obj;
                mail.Body = msg;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                
            }
        }

    }
}
