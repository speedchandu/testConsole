﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            if (!Convert.ToBoolean(Session["Islogged"]))
                return RedirectToAction("Login", "User");
                    
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TestPage()
        {
            return View();
        }

        public ActionResult TestPageOne()
        {
            return View("TestPage");
        }
    }
}