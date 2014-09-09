using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Informatel.Website.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string first_name, string last_name, string email, string phone, string message)
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add("noreply@appswiz.com");
                mail.From = new MailAddress(email);
                mail.Subject = "Informatel-Contact Us";
                mail.Body = string.Format("Name:{0} \n Phone: {1} \n Message: {2}", first_name + ' ' + last_name, phone, message);
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("infemail01");
                smtp.Send(mail);
                return RedirectToAction("Index", "Contact");
            }
            return View();
        }
    }
}