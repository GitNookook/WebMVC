using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webcontent.Models;
using Webcontent.Service;

namespace Webcontent.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.Title = ViewBag.Pagename = "Index";
            return View("Admin");
        }
        public ActionResult ManageFood()
        {
            ViewBag.Title = ViewBag.Pagename = "Hello Manage Food";
            return View("Admin");
        }
        [HttpPost]
        public JsonResult GetFood()
        {
            FoodService s = new FoodService();
            List<FoodModel> result22 = new List<FoodModel>();
            result22.AddRange(s.getFood());
            result22.AddRange(s.getFood());
            result22.AddRange(s.getFood());
            var obj = new
            {
                // data = s.getFood()
                data = result22
            };
            string json = JsonConvert.SerializeObject(obj);
            string json2 = JsonConvert.SerializeObject(s.getFood());
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult deleteFood(String id)
        {
            string result = "deleted id=" + id;
            var obj = new
            {
                data = result
            };

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

    }
}