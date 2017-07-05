using FirstWeekProject.Data.Models;
using FirstWeekProject.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWeekProject.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var contacts = Contacts.GetAll();
                    
            return View(contacts);

        }

        public ActionResult About()
        {
            ViewBag.Message = " You can found your contact faster.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}