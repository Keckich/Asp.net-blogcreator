/*using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
//using System.Net.Mail;
using System.Threading.Tasks;*/
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3
{
    public class EmailService
    {
        /*[Obsolete]
        public async Task SendEmailAsync(string email, string subject, string emailMessage)
        {
            //var emailMessage = new MimeMessage();
            
            *//*emailMessage.From.Add(new MailboxAddress("Администрация", "noreply_blog@mail.ru"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            }; *//*
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Администрация", "noreply@blog.com")); //отправитель сообщения
            message.To.Add(new MailboxAddress(email)); //адресат сообщения
            message.Subject = "Сообщение от MailKit"; //тема сообщения
            //message.Body = new BodyBuilder() { HtmlBody = emailMessage }.ToMessageBody(); //тело сообщения (так же в формате HTML)
            message.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = emailMessage
            };
            using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465, true); //либо использум порт 465
                client.Authenticate("nroflov@gmail.com", "pogger123"); //логин-пароль от аккаунта
                client.Send(message);

                client.Disconnect(true);
                //logger.LogInformation("Сообщение отправлено успешно!");
            }

            *//*using (var client = new SmtpClient("smtp.gmail.ru"))
            {
                *//*await client.ConnectAsync("smtp.mail.ru", 25, false);*//*
                await client.ConnectAsync("smtp.mail.ru", 25, false);
                await client.AuthenticateAsync("noreply_blog@mail.ru", "ytPARIt9p|a3");
                *//*client.ServerCertificateValidationCallback = (mysender, certificate, chain, sslPolicyErrors) => { return true; };
                client.CheckCertificateRevocation = false;*//*
                await client.
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }*//*
        }*/
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Blog", "blogcreatorr@mail.ru"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.mail.ru", 25, false);
                await client.AuthenticateAsync("blogcreatorr@mail.ru", "pogger123");
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);

            }
        }
    }
}
