using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileMvcSamples.Controllers.ThirdPartyLibaries
{
    public class KendoUIMobileController : Controller
    {
        public ActionResult Index()
        {
            return View(@"~\Views\ThirdPartyLibraries\KendoUIMobile\Index.cshtml");
        }

        public ActionResult Detail(string id)
        {
            var vm = new DetailViewModel
            {
            };

            if (id == "food")
            {
                vm.Title = "Food";
                vm.Images.Add("/content/images/bacon_500.jpg");
                vm.Images.Add("/content/images/dragonfruit_500.jpg");
                vm.Images.Add("/content/images/meat_500.jpg");
                vm.Images.Add("/content/images/lolwut_500.jpg");
            }
            else
            {
                vm.Title = "Humor";
                vm.Images.Add("/content/images/hogan_500.jpg");
                vm.Images.Add("/content/images/mitt_500.jpg");
            }

            return View(@"~\Views\ThirdPartyLibraries\KendoUIMobile\Detail.cshtml", vm);
        }

        public class DetailViewModel
        {
            public DetailViewModel()
            {
                Images = new List<string>();
            }

            public string Title { get; set; }
            public List<string> Images { get; set; }
        }
    }
}
