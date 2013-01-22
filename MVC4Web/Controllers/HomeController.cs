using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NServiceBus;
using ViewModels;

namespace MVC4Web.Controllers
{
    public class HomeController : AsyncController
    {
        public IBus Bus { get; set; }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";
            var model = new ViewModels.Blog();
            return View(model);
        }

        
        [HttpPost]
        public ActionResult About(Blog model)
        {
            var cmd = new Messages.Command {Id = Guid.NewGuid()};
            Bus.Send(cmd);
            return View(model);
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
