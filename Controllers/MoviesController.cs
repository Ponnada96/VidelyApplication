using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidelyApplication.Models;
using VidelyApplication.ViewModels;

namespace VidelyApplication.Controllers
{
    public class MoviesController : Controller
    {
        //GET: Movies
        public ActionResult GetMovies()
        {
            var movies = new Movies
            {
                Name = "Minions"
            };

            var custmers = new List<Customers>
            {
                new Customers{Name="prasadponnada",Id=123},
                new Customers{Name="ramu",Id=1223}
            };
            var randomMovie = new RandomMovieViewModel
            {
                Movie = movies,
                Customers = custmers
            };
            var randomMovieViewModel = new List<RandomMovieViewModel>();
            randomMovieViewModel.Add(randomMovie);

            return View(randomMovieViewModel);
            //return HttpNotFound("Good bute");
            //return new EmptyResult();
            //return RedirectToAction("About", "Home", new { id = 123, name = "durga" });
        }

        public ActionResult GetId(int? movieid)
        {
            return Content(string.Format("Id is {0}", movieid));
        }

        public ActionResult Get(int? pagenum, string data)
        {
            if (!pagenum.HasValue)
            {
                pagenum = 1;
            }
            if (string.IsNullOrWhiteSpace(data))
            {
                data = "DP";
            }
            return Content(string.Format("PageNum={0} & data={1}", pagenum, data));
        }

        //custom route
        [Route("movies/getmovies/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(string.Format("{0},{1}", year, month));
        }


    }
}