using MobileMvcSamples.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileMvcSamples.Controllers
{
    public class LeveragingNewVisualToolsController : Controller
    {
        public ActionResult WebFonts()
        {
            ViewData[DeviceCoverageHelper.DefaultSetName] = new DeviceCoverage
            {
                Android_2_1 = DeviceCoverageAmount.No,
                Android_2_2 = DeviceCoverageAmount.Unknown,
                Android_2_3 = DeviceCoverageAmount.Unknown,
                Android_4_1 = DeviceCoverageAmount.Yes,
                Android_4_1_Chrome = DeviceCoverageAmount.Yes,
                iOS_4 = DeviceCoverageAmount.Yes,
                iOS_5 = DeviceCoverageAmount.Unknown,
                iOS_6 = DeviceCoverageAmount.Yes,
                iOS_7 = DeviceCoverageAmount.Yes,
                BlackBerry10 = DeviceCoverageAmount.Unknown,
                Firefox_Android = DeviceCoverageAmount.Yes,
                FirefoxOS = DeviceCoverageAmount.Yes,
                Opera_Classic_Android = DeviceCoverageAmount.Yes,
                Opera_Webkit_Android = DeviceCoverageAmount.Yes,
                WindowsPhone7_5 = DeviceCoverageAmount.No,
                WindowsPhone8 = DeviceCoverageAmount.Unknown,
                Desktop_Chrome = DeviceCoverageAmount.Yes,
                Desktop_Firefox = DeviceCoverageAmount.Yes,
                Desktop_InternetExplorer10 = DeviceCoverageAmount.Yes,
                Tablet_InternetExplorer10 = DeviceCoverageAmount.Unknown,
                KindleFire_FirstGen = DeviceCoverageAmount.Yes,
                KindleFire_HD = DeviceCoverageAmount.Yes,
                GalaxyNexus7 = DeviceCoverageAmount.Yes
            };

            return View();
        }

        public ActionResult Transitions()
        {
            return View();
        }

        public ActionResult Transformations()
        {
            return View();
        }

        public ActionResult Animations()
        {
            return View();
        }

        public ActionResult Gradients()
        {
            return View();
        }

        public ActionResult Shadows()
        {
            return View();
        }

        public ActionResult BorderRadius()
        {
            return View();
        }

        public ActionResult Opacity()
        {
            return View();
        }

        public ActionResult RGBA()
        {
            return View();
        }

        public ActionResult GeneratedContent()
        {
            return View();
        }

        public ActionResult MultipleBackgrounds()
        {
            return View();
        }

        public ActionResult Canvas()
        {
            return View();
        }

        public ActionResult SVG()
        {
            //Inline
            ViewData[DeviceCoverageHelper.DefaultSetName] = new DeviceCoverage
            {
                Android_2_1 = DeviceCoverageAmount.No,
                Android_2_2 = DeviceCoverageAmount.Unknown,
                Android_2_3 = DeviceCoverageAmount.Unknown,
                Android_4_1 = DeviceCoverageAmount.Yes,
                Android_4_1_Chrome = DeviceCoverageAmount.Yes,
                iOS_4 = DeviceCoverageAmount.No,
                iOS_5 = DeviceCoverageAmount.Unknown,
                iOS_6 = DeviceCoverageAmount.Yes,
                iOS_7 = DeviceCoverageAmount.Yes,
                BlackBerry10 = DeviceCoverageAmount.Unknown,
                Firefox_Android = DeviceCoverageAmount.Yes,
                FirefoxOS = DeviceCoverageAmount.Yes,
                Opera_Classic_Android = DeviceCoverageAmount.Yes,
                Opera_Webkit_Android = DeviceCoverageAmount.Yes,
                WindowsPhone7_5 = DeviceCoverageAmount.Yes,
                WindowsPhone8 = DeviceCoverageAmount.Unknown,
                Desktop_Chrome = DeviceCoverageAmount.Yes,
                Desktop_Firefox = DeviceCoverageAmount.Yes,
                Desktop_InternetExplorer10 = DeviceCoverageAmount.Yes,
                Tablet_InternetExplorer10 = DeviceCoverageAmount.Unknown,
                KindleFire_FirstGen = DeviceCoverageAmount.No,
                KindleFire_HD = DeviceCoverageAmount.Yes,
                GalaxyNexus7 = DeviceCoverageAmount.Yes
            };

            ViewData["ExternalSVG"] = new DeviceCoverage
            {
                Android_2_1 = DeviceCoverageAmount.No,
                Android_2_2 = DeviceCoverageAmount.Unknown,
                Android_2_3 = DeviceCoverageAmount.Unknown,
                Android_4_1 = DeviceCoverageAmount.Yes,
                Android_4_1_Chrome = DeviceCoverageAmount.Yes,
                iOS_4 = DeviceCoverageAmount.Yes,
                iOS_5 = DeviceCoverageAmount.Unknown,
                iOS_6 = DeviceCoverageAmount.Yes,
                iOS_7 = DeviceCoverageAmount.Yes,
                BlackBerry10 = DeviceCoverageAmount.Unknown,
                Firefox_Android = DeviceCoverageAmount.Yes,
                FirefoxOS = DeviceCoverageAmount.Yes,
                Opera_Classic_Android = DeviceCoverageAmount.Yes,
                Opera_Webkit_Android = DeviceCoverageAmount.Yes,
                WindowsPhone7_5 = DeviceCoverageAmount.Yes,
                WindowsPhone8 = DeviceCoverageAmount.Unknown,
                Desktop_Chrome = DeviceCoverageAmount.Yes,
                Desktop_Firefox = DeviceCoverageAmount.Yes,
                Desktop_InternetExplorer10 = DeviceCoverageAmount.Yes,
                Tablet_InternetExplorer10 = DeviceCoverageAmount.Unknown,
                KindleFire_FirstGen = DeviceCoverageAmount.No,
                KindleFire_HD = DeviceCoverageAmount.Yes,
                GalaxyNexus7 = DeviceCoverageAmount.Yes
            };

            return View();
        }
    }
}
