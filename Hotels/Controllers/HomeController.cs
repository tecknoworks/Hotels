using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Hotels.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
			//AcomodationService service = new AcomodationService();
           // service.GetAcomodations(1);

			return View();
        }

        public JsonResult GetAllCountries()
        {
            AcomodationService service = new AcomodationService();
            var countries = service.GetAllCountries();
            return new JsonResult() { Data = new { Countries = countries}, ContentEncoding = Encoding.UTF8, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
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