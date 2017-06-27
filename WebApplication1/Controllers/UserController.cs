using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLoginViewModel Um)
        {
            //Model Validation
            if (!ModelState.IsValid)
            {
                return View(Um);
            }
            else
            {
                //login ko code yaha lekhna parcha
                DAL.UserDAL ud = new DAL.UserDAL();
                if (ud.IfUserExists(Um.UserName))
                {
                    if (ud.Login(Um))
                    {
                        //session initialize ko code here
                        Session.Add("Islogged", true);
                        Session.Add("UserName", Um.UserName);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("NotMatch", "Password Doesnot match");
                        return View(Um);
                    }
                }
                else
                {
                    ModelState.AddModelError("DoesNotExists", "User doesnot exists");
                    return View(Um);
                }
            }
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(UserRegistrationViewModel Um)
        {
            //Model Validation
            if (!ModelState.IsValid)
            {
                return View(Um);
            }
            else
            {
                //Registration ko code yaha lekhna parcha
                DAL.UserDAL ud = new DAL.UserDAL();
                if (ud.IfUserExists(Um.UserName))
                {
                    ModelState.AddModelError("Exists", "Username already Exists.");
                    return View(Um);
                }
                else
                {
                    ud.CreateUser(Um);
                    return RedirectToAction("Index", "Home");
                }

            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}