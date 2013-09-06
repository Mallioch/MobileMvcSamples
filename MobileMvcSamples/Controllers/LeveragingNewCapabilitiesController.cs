using MobileMvcSamples.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileMvcSamples.Controllers
{
    public class LeveragingNewCapabilitiesController : Controller
    {
        public ActionResult WebSockets()
        {
            return View();
        }

        public ActionResult WebStorage()
        {
            return View();
        }

        public ActionResult ApplicationCache()
        {
            return View();
        }

        public ActionResult WebWorkers()
        {
            return View();
        }

        public ActionResult HistoryAPI()
        {
            ViewData[DeviceCoverageHelper.DefaultSetName] = new DeviceCoverage
            {
                Android_2_1 = DeviceCoverageAmount.Unknown,
                Android_2_2 = DeviceCoverageAmount.Unknown,
                Android_2_3 = DeviceCoverageAmount.Unknown,
                Android_4_1 = DeviceCoverageAmount.Unknown,
                Android_4_1_Chrome = DeviceCoverageAmount.Unknown,
                iOS_4 = DeviceCoverageAmount.Unknown,
                iOS_5 = DeviceCoverageAmount.Unknown,
                iOS_6 = DeviceCoverageAmount.Unknown,
                iOS_7 = DeviceCoverageAmount.Unknown,
                BlackBerry10 = DeviceCoverageAmount.Unknown,
                Firefox_Android = DeviceCoverageAmount.Unknown,
                FirefoxOS = DeviceCoverageAmount.Unknown,
                Opera_Classic_Android = DeviceCoverageAmount.Unknown,
                Opera_Webkit_Android = DeviceCoverageAmount.Unknown,
                WindowsPhone7_5 = DeviceCoverageAmount.Unknown,
                WindowsPhone8 = DeviceCoverageAmount.Yes,
                Desktop_Chrome = DeviceCoverageAmount.Unknown,
                Desktop_Firefox = DeviceCoverageAmount.Unknown,
                Desktop_InternetExplorer10 = DeviceCoverageAmount.Unknown,
                Tablet_InternetExplorer10 = DeviceCoverageAmount.Unknown,
                KindleFire_FirstGen = DeviceCoverageAmount.Unknown,
                KindleFire_HD = DeviceCoverageAmount.Unknown,
                GalaxyNexus7 = DeviceCoverageAmount.Unknown
            };

            return View();
        }

        public ActionResult AudioAndVideo()
        {
            return View();
        }

        public ActionResult BetterSemantics()
        {
            return View();
        }
    }
}
