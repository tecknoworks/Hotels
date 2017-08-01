using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotels.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
			CountryService cs = new CountryService();
			cs.GetAllCountries();

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
    }
}