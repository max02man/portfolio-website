using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult programming()
        {
            ViewBag.Message = "programming";

            return View();
        }
        public ActionResult DB_desgin()
        {
            ViewBag.Message = "SQL";

            return View();
        }
        public ActionResult web_deve()
        {
            ViewBag.Message = "web developing";

            return View();
        }
        public ActionResult sys_analysis()
        {
            ViewBag.Message = "project";

            return View();
        }

        public ActionResult deve_project()
        {
            ViewBag.Message = "team project";

            return View();
        }
        public ActionResult Info_security()
        {
            ViewBag.Message = "secrtiy";

            return View();
        }
    }
}