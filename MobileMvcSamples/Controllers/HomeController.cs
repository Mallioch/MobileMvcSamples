using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileMvcSamples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public enum ChapterStatus
        {
            NotStarted,
            InProgress,
            InEditing,
            Finished
        }
    }
}
