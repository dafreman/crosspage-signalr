using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewTestingApplicationForReact.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SignalPage()
        {
            var uniqueGroup = Guid.NewGuid().ToString();
            ViewBag.GroupId = uniqueGroup;

            return View();
        }

        public ActionResult ReceiverPage(string groupId)
        {
            ViewBag.GroupId = groupId;

            return View();
        }
    }
}
