using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CA2017.Models;

namespace CA2017.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            CommunityAssist2017Entities db = new CommunityAssist2017Entities();
            //var gt = (from b in db.GrantTypes
                      //select b).ToList();

            return View(db.GrantTypes.ToList());
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
    }
}