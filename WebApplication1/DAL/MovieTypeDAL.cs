using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class MovieTypeDAL
    {
        MovieStoreEntities db = new MovieStoreEntities();
        
        public bool InsertMovieType(MovieType movieType)
        {
            try
            {
                db.MovieTypes.Add(movieType);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }

        public IEnumerable<MovieType> GetAllMovies()
        {
            try
            {
                return db.MovieTypes.AsEnumerable();
            }
            catch (Exception)
            {
                throw;
            }
        }





    }
}