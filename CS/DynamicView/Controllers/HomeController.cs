using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Q533692.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";

            return View();
        }

        public ActionResult GridViewPartial() {
            var model = Enumerable.Range(0, 10).Select(i => new { ID = i, Text = "Some text " + i });
            return new DynamicPartial(model);
        }
    }
}