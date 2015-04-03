using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETCourse.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Labs()
        {
            ViewBag.Message = "Hand On Labs";

            return View();
        }

        public ActionResult Lectures()
        {
            ViewBag.Message = "Lectures";

            return View();
        }
    }
}