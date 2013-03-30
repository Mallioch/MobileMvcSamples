using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileMvcSamples.Controllers
{
    public class CSSLayoutBootcampController : Controller
    {
        public ActionResult WithoutAReset()
        {
            return View();
        }

        public ActionResult WithAReset()
        {
            return View();
        }
    }
}
