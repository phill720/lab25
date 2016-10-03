using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab25.Models;

namespace lab25.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(UserInfo userInfo)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks",userInfo);
            }
            else
            {
                ViewBag.InvMessage = "Invalid Fields";
                return View();
            }
        }
    }
}