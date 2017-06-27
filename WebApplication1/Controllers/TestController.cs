using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    [Authorize(Roles ="Admin")]
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            ViewBag.Msg = "This is test call from Index page";

            return View();
        }

        public  ActionResult PageOne(string str)
        {
            ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            ViewBag.Msg = str;
            return View("Index");
        }

        public ActionResult PageTwo(string str1)
        {
            ViewBag.Layout = "~/Views/Shared/_LayoutNew.cshtml";
            ViewBag.Msg = str1;

            return View("Index");
        }

        [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CreateItem(string Fname, string Lname, string Email)
        {
            ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            ViewBag.Msg = Fname + " " + Lname + " " + Email;
            return View("Index");
        }
    }
}