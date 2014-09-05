using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Submit()
        {
            return View();
        }
	}
}