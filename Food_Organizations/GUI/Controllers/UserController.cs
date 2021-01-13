using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BL;
using System.Text;
using System.IO;
using System.Web;
using System.Threading.Tasks;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Net.Mail;

namespace GUI.Controllers
{

    [RoutePrefix("api/Users")]
    public class UserController : ApiController
    {
      
        [Route("get"),HttpGet]
        public void sendSms()
        {
            BL.SendMessage s = new SendMessage();
            var a = s.SendSMS();
        }
        [Route("forgetPassword"), HttpGet]
        public IHttpActionResult ForgetPassword(int organizationKod,int typeUser,string mail)
        {
            var result = BL.UserBL.ForgetPassword(organizationKod, typeUser, mail);
            if (result)
                return Ok();
            return BadRequest();
        }

        
   // [Route("sendMail"),HttpGet]
    //public bool sendMail()
    //    {
    //        try { 
    //        MailMessage mail = new MailMessage();
    //        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

    //        mail.From = new MailAddress("0504161052t@gmail.com");
    //       // mail.To.Add("batyab952000@gmail.com");
    //        mail.To.Add("0504161052t@gmail.com");
    //        mail.Subject = "הי";
    //        mail.Body = "איזה באסה שהשם תפוס";

    //        SmtpServer.Port = 587;
    //        SmtpServer.Credentials = new System.Net.NetworkCredential("mateemLi34@gmail.com", "tb2020@@");
    //        SmtpServer.EnableSsl = true;

    //        SmtpServer.Send(mail);
    //            return true;
    //    }
    //        catch (Exception e)
    //        { 
    //        return false;
    //        }
    //    }
        

      
        
        [Route("io"), HttpPost]
        
        public HttpResponseMessage io()
        {
            string imageName = null;
            var httpRequest = HttpContext.Current.Request;
            //Upload Image
            var postedFile = httpRequest.Files["Image"];
            //Create custom filename
            if (postedFile != null)
            {
                imageName = new String(Path.GetFileNameWithoutExtension(postedFile.FileName).Take(10).ToArray()).Replace(" ", "-");
                //imageName = imageName + DateTime.Now.ToString("yymmssfff");
                imageName = imageName + Path.GetExtension(postedFile.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory() + imageName);
                postedFile.SaveAs(filePath);
            }
        
        //{
        //    string image1 = null;
        //    var http = HttpContext.Current.Request;
        //   var pr = http.Files["fileKey"];
        //    image1 = new String(Path.GetFileNameWithoutExtension(pr.FileName).Take(10).ToArray()).Replace(" ", "-");
        //    image1 = image1 + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(pr.FileName);
        //    var filePath = HttpContext.Current.Server.MapPath("~/Images/" + image1);
        //    pr.SaveAs(filePath);
          return Request.CreateResponse(HttpStatusCode.Created);
        //var c = Request;
        //BL.OrganizerUserBL.getRequests(3);
        //return true;
    }
 
    }
}