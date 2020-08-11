using Kata.BirthdayGreetings.Data.Models;
using Kata.BirthdayGreetings.Infrastructure;
using System;
using System.Net;
using System.Net.Mail;

namespace Kata.BirthdayGreetings.Infrastructure.Handlers
{
    class EmailHandler : Observer
    {

        public override void Update(Person person)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(Configuration.EMAIL);
                message.To.Add(new MailAddress(person.Email));
                message.Subject = Message.GetSubject();
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = Message.GetBody(person.FirstName);
                smtp.Port = 587;
                smtp.Host = Configuration.EMAIL_HOST; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(Configuration.EMAIL, Configuration.PASSWORD);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex) { }
        }
    }
}
