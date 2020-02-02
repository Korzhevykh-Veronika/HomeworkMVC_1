using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Guest()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Profile()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }
        
        [HttpPost]
        public ActionResult Profile(string firstName)
        {
            return View("~/Views/Home/Result.cshtml");
        }
    }
}