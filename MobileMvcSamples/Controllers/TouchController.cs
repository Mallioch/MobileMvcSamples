using System;
using System.Collections.Generic;
using System.IO;
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

        public ActionResult Signature()
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

        public ActionResult TouchableCanvasForIE()
        {
            return View();
        }

        public ActionResult Sandbox()
        {
            return View();
        }

        public ActionResult Sandbox2()
        {
            return View();
        }

        public ActionResult SimpleTouchSample()
        {
            return View();
        }

        public ActionResult SimpleTouchSampleImproved()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(string fileData)
        {
            string dataWithoutJpegMarker = fileData.Replace("data:image/jpeg;base64,", String.Empty);
            byte[] filebytes = Convert.FromBase64String(dataWithoutJpegMarker);
            string writePath = Path.Combine(Server.MapPath("~/upload"), Guid.NewGuid().ToString() + ".jpg");
            using (FileStream fs = new FileStream(writePath,
                                           FileMode.OpenOrCreate,
                                           FileAccess.Write,
                                           FileShare.None))
            {
                fs.Write(filebytes, 0, filebytes.Length);
            }

            return new EmptyResult();
        }
    }
}
