using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TextmagicRest;
using System.Collections.Specialized;
using System.Net;
using RestSharp;
using Nexmo.Api;


namespace BL
{
  public  class SendMessage
    {
        public bool SendMail(string to ,string body,string subject )
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("mateemLi34@gmail.com");
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("mateemLi34@gmail.com", "tb2020@@");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void send()
        {
            
            using (WebClient client = new WebClient())
            {
                byte[] response = client.UploadValues("https://textita.com/text", new NameValueCollection() {
    { "phone", "0552402806" },
    { "message", "Sample SMS Text" },
    { "key", "textita" },
  });

                string result = System.Text.Encoding.UTF8.GetString(response);
            }
        }

        public  bool SendSMS()
        {
            try
            {
                var client = new Nexmo.Api.Client(creds: new Nexmo.Api.Request.Credentials
                {
                    ApiKey = "584a23da",
                    ApiSecret = "pxaZnYJMZk502PT3"
                });
                var results = client.SMS.Send(request: new SMS.SMSRequest
                {
                    from = "בתיוש",
                    to = "972587700022",
                    text = "Hello from Vonage SMS API"
                });
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //public void sendSms()
        //{
        //    var client = new Client("test", "my-api-key");
        //    var link = client.SendMessage("Hello from TextMagic API", "556800894");
        //    if (link.Success)
        //    {
        //        Console.WriteLine("Message ID {0} has been successfully sent", link.Id);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Message was not sent due to following exception: {0}", link.ClientException.Message);

        //    }

        //}
    }
}
