using FirstWeekProject.Data.Interfaces;
using FirstWeekProject.Data.Repository;
using System.Web.Mvc;

namespace FirstWeekProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactRepository _contactRepository;

        public HomeController()
        {
            _contactRepository = new ContactRepository();
        }

        public ActionResult Index()
        {
            var contacts = _contactRepository.GetAll();
                    
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