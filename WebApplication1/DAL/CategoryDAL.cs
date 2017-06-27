using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class CategoryDAL
    {
        MovieStoreEntities db = new MovieStoreEntities();

        public bool InsertCategoryType(Category cateogory)
        {
            try
            {
                db.Categories.Add(cateogory);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            try
            {
                return db.Categories.AsEnumerable();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}