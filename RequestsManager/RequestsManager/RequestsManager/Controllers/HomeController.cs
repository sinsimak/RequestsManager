using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RequestsManager.Model;

namespace RequestsManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Request model = new Request()
            {
                OrderDate = DateTime.Now
            };
            return View(model);
        }
    }
}
