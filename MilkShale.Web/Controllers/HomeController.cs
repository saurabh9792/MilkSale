using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MilkShale.Controllers
{
    public class HomeController : Controller
    {
       

        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

       
        public ActionResult Product()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult HeaderPageContent()
        {
            
            return PartialView("~/Views/Shared/_Header.cshtml");
        }

        [ChildActionOnly]
        public ActionResult FooterPageContent()
        {
            
            return PartialView("~/Views/Shared/_Footer.cshtml");
        }

    }
}