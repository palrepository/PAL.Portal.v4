using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PAL.Portal.v4.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Products()
        {
            ViewBag.Message = "Your product page.";

            return View();
        }
    }
}