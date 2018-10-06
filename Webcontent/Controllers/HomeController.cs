using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webcontent.Models;
using Webcontent.Service;

namespace Webcontent.Controllers
{
    public class HomeController : Controller
    {
        FoodService service = new FoodService();
        public ActionResult Index()
        {
            FoodService service = new FoodService();
            var data = service.getFood();

            return View(data);
        }
        public ActionResult North()
        {
            FoodService service = new FoodService();
            var data = service.getFood().Where(w => w.Catagory == "N").ToList();

            return View("Index", data);
        }
        public ActionResult Northeast()
        {

            FoodService service = new FoodService();
            var data = (from ss in service.getFood() where ss.Catagory == "NE" select ss).ToList();

            return View("Index", data);
        }
        public ActionResult Central()
        {

            FoodService service = new FoodService();
            var data = service.getFood().Where(w => w.Catagory == "C").ToList();

            return View("Index", data);
        }
        public ActionResult South()
        {

            FoodService service = new FoodService();
            var data = service.getFood().Where(w => w.Catagory == "S").ToList();

            return View("Index", data);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Signup(Profile profile)
        {
            ViewBag.Message = "Your contact page.";
            profile = new Profile();
            return View("Index", profile);

        }

        public PartialViewResult Menu()
        {
            MasterService service = new MasterService();

            var menu = service.getMenu();
            return PartialView("_Menu", menu);
        }

    }
}