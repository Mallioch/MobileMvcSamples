using MobileMvcSamples.Helpers;
using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace MobileMvcSamples.Controllers
{
    public class LeveragingNativeAPIsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Geolocation()
        {
            ViewData[DeviceCoverageHelper.DefaultSetName] = new DeviceCoverage
            {
                Android_2_1 = DeviceCoverageAmount.Yes,
                Android_2_2 = DeviceCoverageAmount.Yes,
                Android_2_3 = DeviceCoverageAmount.Yes,
                Android_4_1 = DeviceCoverageAmount.Yes,
                Android_4_1_Chrome = DeviceCoverageAmount.Yes,
                iOS_4 = DeviceCoverageAmount.Yes,
                iOS_5 = DeviceCoverageAmount.Yes,
                iOS_6 = DeviceCoverageAmount.Yes,
                iOS_7 = DeviceCoverageAmount.Yes,
                BlackBerry10 = DeviceCoverageAmount.Unknown,
                Firefox_Android = DeviceCoverageAmount.Yes,
                FirefoxOS = DeviceCoverageAmount.Yes,
                Opera_Classic_Android = DeviceCoverageAmount.Yes,
                Opera_Webkit_Android = DeviceCoverageAmount.Unknown,
                WindowsPhone7_5 = DeviceCoverageAmount.Yes,
                WindowsPhone8 = DeviceCoverageAmount.Yes,
                Desktop_Chrome = DeviceCoverageAmount.Yes,
                Desktop_Firefox = DeviceCoverageAmount.Yes,
                Desktop_InternetExplorer10 = DeviceCoverageAmount.Yes,
                Tablet_InternetExplorer10 = DeviceCoverageAmount.Yes,
                KindleFire_FirstGen = DeviceCoverageAmount.Unknown,
                KindleFire_HD = DeviceCoverageAmount.Yes,
                GalaxyNexus7 = DeviceCoverageAmount.Unknown
            };
            return View();
        }

        public ActionResult PhotoAccess()
        {
            ViewData[DeviceCoverageHelper.DefaultSetName] = new DeviceCoverage
            {
                Android_2_1 = DeviceCoverageAmount.Unknown,
                Android_2_2 = DeviceCoverageAmount.Unknown,
                Android_2_3 = DeviceCoverageAmount.Unknown,
                Android_4_1 = DeviceCoverageAmount.Yes,
                Android_4_1_Chrome = DeviceCoverageAmount.Yes,
                iOS_4 = DeviceCoverageAmount.No,
                iOS_5 = DeviceCoverageAmount.No,
                iOS_6 = DeviceCoverageAmount.Yes,
                iOS_7 = DeviceCoverageAmount.Yes,
                BlackBerry10 = DeviceCoverageAmount.Unknown,
                Firefox_Android = DeviceCoverageAmount.Unknown,
                FirefoxOS = DeviceCoverageAmount.Unknown,
                Opera_Classic_Android = DeviceCoverageAmount.Unknown,
                Opera_Webkit_Android = DeviceCoverageAmount.Unknown,
                WindowsPhone7_5 = DeviceCoverageAmount.No,
                WindowsPhone8 = DeviceCoverageAmount.No,
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

        [HttpPost]
        public ActionResult PhotoAccess(string fileData)
        {
            string fileName = Guid.NewGuid().ToString() + ".jpg";
            string path = Server.MapPath(@"~/content/" + fileName);

            //If posting the file, this works
            foreach (string file in this.HttpContext.Request.Files)
            {
                var hpf = Request.Files[file] as HttpPostedFileBase;
                hpf.SaveAs(path);
                return Redirect("/leveragingnativeapis/photoaccess?filename=" + fileName);
            }

            //If sending a base64 encoded string, this works
            fileData = fileData.Replace("data:image/jpeg;base64,", String.Empty);

            byte[] filebytes = Convert.FromBase64String(fileData);
            using (FileStream fs = new FileStream(path,
                                           FileMode.OpenOrCreate,
                                           FileAccess.Write,
                                           FileShare.None))
            {
                //fs.Write(filebytes, 0, filebytes.Length);
            }


            return Json(fileName);
        }

        public ActionResult NetworkInfo()
        {
            ViewData[DeviceCoverageHelper.DefaultSetName] = new DeviceCoverage
            {
                Android_2_1 = DeviceCoverageAmount.Partial,
                Android_2_2 = DeviceCoverageAmount.Yes,
                Android_2_3 = DeviceCoverageAmount.Yes,
                Android_4_1 = DeviceCoverageAmount.Yes,
                Android_4_1_Chrome = DeviceCoverageAmount.Yes,
                iOS_4 = DeviceCoverageAmount.Yes,
                iOS_5 = DeviceCoverageAmount.Yes,
                iOS_6 = DeviceCoverageAmount.Yes,
                iOS_7 = DeviceCoverageAmount.Yes,
                BlackBerry10 = DeviceCoverageAmount.Unknown,
                Firefox_Android = DeviceCoverageAmount.Yes,
                FirefoxOS = DeviceCoverageAmount.Yes,
                Opera_Classic_Android = DeviceCoverageAmount.Partial,
                Opera_Webkit_Android = DeviceCoverageAmount.Partial,
                WindowsPhone7_5 = DeviceCoverageAmount.Partial,
                WindowsPhone8 = DeviceCoverageAmount.Unknown,
                Desktop_Chrome = DeviceCoverageAmount.Yes,
                Desktop_Firefox = DeviceCoverageAmount.Partial,
                Desktop_InternetExplorer10 = DeviceCoverageAmount.Yes,
                Tablet_InternetExplorer10 = DeviceCoverageAmount.Yes,
                KindleFire_FirstGen = DeviceCoverageAmount.Yes,
                KindleFire_HD = DeviceCoverageAmount.Partial,
                GalaxyNexus7 = DeviceCoverageAmount.Yes
            };

            return View();
        }

        public ActionResult PhoneAndEmail()
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
                WindowsPhone8 = DeviceCoverageAmount.Unknown,
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

        public ActionResult Maps()
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
                WindowsPhone8 = DeviceCoverageAmount.Unknown,
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
    }
}
