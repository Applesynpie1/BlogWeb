using BlogWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult AdminDashboard()
        {
            return View();
        }
        public JsonResult LoadPosts()
        {
            using (var db = new BlogContext())
            {
                var postData = (from pData in db.poststbl
                               join uData in db.userstbl on pData.userID equals uData.userID
                               select new { uData, pData }).ToList();

                return Json(postData, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult LoadPieChartData()
        {
            using (var db = new BlogContext())
            {
                var getUsr = db.userstbl.Select(x => x).ToList();
                List<int> postCount = new List<int>();
                foreach (var item in getUsr)
                {
                    var pCount = db.poststbl.Where(x => x.userID == item.userID).Count();
                    postCount.Add(pCount);
                }
                var pieData = new
                {
                    Series = getUsr,
                    Data = postCount
                };
                return Json(pieData, JsonRequestBehavior.AllowGet);
            }
        }
    }
}