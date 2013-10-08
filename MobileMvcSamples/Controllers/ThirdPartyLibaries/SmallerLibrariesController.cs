using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileMvcSamples.Controllers.ThirdPartyLibaries
{
    public class SmallerLibrariesController : Controller
    {
        public ActionResult FitText()
        {
            return View(@"~\Views\ThirdPartyLibraries\SmallerLibraries\FitText.cshtml");
        }

        public ActionResult FlowType()
        {
            return View(@"~\Views\ThirdPartyLibraries\SmallerLibraries\FlowType.cshtml");
        }

        public ActionResult Enquire()
        {
            return View(@"~\Views\ThirdPartyLibraries\SmallerLibraries\Enquire.cshtml");
        }

        [HttpGet]
        public ActionResult EnquireContent()
        {
            return Content("<p>Loaded from the server:</p><img src=\"/content/images/bacon_200.jpg\" />");
        }

        public ActionResult Respond()
        {
            return View(@"~\Views\ThirdPartyLibraries\SmallerLibraries\Respond.cshtml");
        }

        public ActionResult Swipeview()
        {
            return View(@"~\Views\ThirdPartyLibraries\SmallerLibraries\SwipeView.cshtml");
        }

        public ActionResult Hammer()
        {
            return View(@"~\Views\ThirdPartyLibraries\SmallerLibraries\Hammer.cshtml");
        }

        public ActionResult PointerPolyfill()
        {
            return View(@"~\Views\ThirdPartyLibraries\SmallerLibraries\PointerPolyfill.cshtml");
        }
    }
}
