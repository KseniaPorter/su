using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using zorroshop.Models;

namespace zorroshop.Controllers
{
    public class HomeController : Controller
    {
        Zorro zorro = new Zorro();


        public ActionResult Index()
        {

            IEnumerable<CustomerModel> customersM = zorro.customerModels;

            ViewBag.customerModels = customersM;
            return View();
        }
    }
}
