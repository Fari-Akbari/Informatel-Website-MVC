using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Informatel.Website.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(string first_name, string last_name, string email, string phone)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MailMessage mail = new MailMessage();
                    mail.To.Add("noreply@appswiz.com");
                    mail.From = new MailAddress(email);
                    mail.Subject = first_name + ' ' + last_name;
                    mail.Body = phone;

                    System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("infemail01");
                    smtp.Send(mail);

                    return RedirectToAction("Index", "Home");
                }
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }
	}
}