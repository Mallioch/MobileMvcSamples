using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileMvcSamples.Controllers.ThirdPartyLibaries
{
    public class SenchaTouchController : Controller
    {
        public ActionResult Index()
        {
            return View(@"~\Views\ThirdPartyLibraries\SenchaTouch\Index.cshtml");
        }

        public ActionResult Detail(string id)
        {
            var vm = new DetailViewModel
            {
            };

            if (id == "food")
            {
                vm.Title = "Food";
                vm.Images.Add(new Image { Name = "Bacon", Url = "/content/images/bacon_500.jpg", Description = "This is bacon, the healthy meat." });
                vm.Images.Add(new Image { Name = "Dragonfruit", Url = "/content/images/dragonfruit_500.jpg", Description = "This is dragonfruit that I had in Cambodia. Pretty tasty." });
                vm.Images.Add(new Image { Name = "Meat", Url = "/content/images/meat_500.jpg", Description = "The best way to eat meat..." });
                vm.Images.Add(new Image { Name = "Lolwut Pear", Url = "/content/images/lolwut_500.jpg", Description = "It would be a bit strange to eat this pear." });
            }
            else
            {
                vm.Title = "Humor";
                vm.Images.Add(new Image { Name = "Hulk Hogan", Url = "/content/images/hogan_500.jpg", Description = "Hulk Hogan is pretty awesome." });
                vm.Images.Add(new Image { Name = "Mitt Romney", Url = "/content/images/mitt_500.jpg", Description = "I really have nothing to say here." });
            }

            return View(@"~\Views\ThirdPartyLibraries\SenchaTouch\Detail.cshtml", vm);
        }


        public class DetailViewModel
        {
            public DetailViewModel()
            {
                Images = new List<Image>();
            }

            public string Title { get; set; }
            public List<Image> Images { get; set; }
        }

        public class Image
        {
            public string Description { get; set; }
            public string Url { get; set; }
            public string Name { get; set; }
        }
    }
}
