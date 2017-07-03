using FirstWeekProject.Models;
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
        List<Contact> contactList = new List<Contact>();

        var contact1 = new Contact();
        contact1.Name = "Petras";
        contact1.LastName = "Petraitis";
        contact1.EmailAddress = "P.Petraitis@gmail.com";
        contact1.Phone = "8689112455";
        contactList.Add(contact1);


            var contact2 = new Contact();
            contact2.Name = "Jonas";
            contact2.LastName = "Jonaitis";
            contact2.EmailAddress = "J.Jonaitis@gmail.com";
            contact2.Phone = "+3706002455";
            contactList.Add(contact2);

            var contact3 = new Contact();
            contact3.Name = "Benas";
            contact3.LastName = "Benaitis";
            contact3.EmailAddress = "BenasB@gmail.com";
            contact3.Phone = "868152466";
            contactList.Add(contact3);


            var contact4 = new Contact();
            contact4.Name = "Robertas";
            contact4.LastName = "Jonaitis";
            contact4.EmailAddress = "RobertasJonaitis@gmail.com";
            contact4.Phone = "86824579";
            contactList.Add(contact4);
            return View(contactList);

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