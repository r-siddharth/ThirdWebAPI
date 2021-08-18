using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThirdAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            ViewBag.Enviornment = ConfigurationManager.AppSettings["Enviornment"].ToString();
            ViewBag.Region = ConfigurationManager.AppSettings["Region"].ToString();

            return View();
        }
    }
}
