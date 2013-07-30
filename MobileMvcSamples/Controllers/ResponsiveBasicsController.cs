using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileMvcSamples.Controllers
{
    public class ResponsiveBasicsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewportSample()
        {
            return View();
        }

        public ActionResult PortraitAndLandscapeExperiment()
        {
            return View();
        }

        public ActionResult ResolutionMediaQuery()
        {
            return View();
        }
    }
}
