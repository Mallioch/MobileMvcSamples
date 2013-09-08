using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileMvcSamples.Controllers.ThirdPartyLibaries
{
    public class ZurbFoundationController : Controller
    {
        public ActionResult Index()
        {
            return View(@"~\Views\ThirdPartyLibraries\ZurbFoundation\Index.cshtml");
        }
    }
}
