using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileMvcSamples.Controllers
{
    public class TouchController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Touchable()
        {
            return View();
        }

        public ActionResult Hammer()
        {
            return View();
        }
    }
}
