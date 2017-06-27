
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MovieTypeEntryAjax(string movieType)
        {
            Thread.Sleep(10000);
            if (!string.IsNullOrWhiteSpace(movieType))
            {
                MovieType m = new MovieType();
                m.MovieType1 = movieType;
                new DAL.MovieTypeDAL().InsertMovieType(m);
                return Json("Successfully Inserted", JsonRequestBehavior.AllowGet);
            }
            else
            {
                Response.StatusCode = 400;
                return Json("Error inserting", JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult CategoryEntryAjax(string category)
        {
            if (!string.IsNullOrWhiteSpace(category))
            {
                Category m = new Category();
                m.CategoryName= category;
                new DAL.CategoryDAL().InsertCategoryType(m);
                return Json("Successfully added", JsonRequestBehavior.AllowGet);
            }
            else
                return Json("Error in insert", JsonRequestBehavior.AllowGet);
        }

        public ActionResult MovieTypeEntry(string movieType)
        {
            if (!string.IsNullOrWhiteSpace(movieType))
            {
                MovieType m = new MovieType();
                m.MovieType1 = movieType;
                new DAL.MovieTypeDAL().InsertMovieType(m);
                return RedirectToAction("Index", "Admin");
            }
            else
                return RedirectToAction("Index", "Admin");
        }

        public ActionResult MovieEntryForm()
        {
            
            IEnumerable<SelectListItem> lst = new DAL.MovieTypeDAL().GetAllMovies().Select(p => new SelectListItem { Text = p.MovieType1, Value = p.Id.ToString() });
            IEnumerable<SelectListItem> cateogrylist = new DAL.CategoryDAL().GetAllCategories().Select(p => new SelectListItem { Text = p.CategoryName, Value = p.Id.ToString() });
            ViewData["MovieType"] = lst;
            ViewData["Category"] = cateogrylist;
            return PartialView();
        }
    }
}