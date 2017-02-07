using Connection360.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Connection360.Web.Controllers
{
    public class HomeController : Controller
    {
        private BrandModuleContext db = new BrandModuleContext();
        public ActionResult Index()
        {
            var brands = db.Brands.ToList();
            return View(brands);
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