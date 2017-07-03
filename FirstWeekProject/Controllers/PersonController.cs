using FirstWeekProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWeekProject.Controllers
{
    public class PersonController : Controller
    {
        public class personController : Controller
        {
            static List<person> man = new List<person>();

            public ActionResult Index()
            {
                return View(man);
            }

            public ActionResult Details(person person)
            {
                return View(person);
            }

            public ActionResult Create()
            {
                return View();
            }

            [AcceptVerbs(HttpVerbs.Post)]
            public ActionResult Create(person person)
            {
                if (!ModelState.IsValid)
                {
                    return View("Create", person);
                }
                man.Add(person);
                return RedirectToAction("Index");
            }
        }
    }
}
