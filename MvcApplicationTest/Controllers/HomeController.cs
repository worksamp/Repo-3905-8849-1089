using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Comment Added on April 26, 2017 -2
            return View();
        }
    }
}
