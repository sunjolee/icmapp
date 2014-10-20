using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using icm.Framework;

namespace icm.Front.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            string aa = "123";

            bool a = aa.IsNullOrEmpty();
              
            return View();
        }

        public ActionResult About()
        {
            return View();
        }


        public ActionResult Main()
        {
            return View();
        }
    }
}
