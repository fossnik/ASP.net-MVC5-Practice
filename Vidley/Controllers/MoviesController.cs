using System.Collections.Generic;
using System.Web.Mvc;
using Vidley.Models;
using Vidley.ViewModels;

namespace Vidley.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
        // GET: Movies/Random   
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        //// movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    // record parameters from URL
        //    if (pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrEmpty(sortBy))
        //        sortBy = "Name";

        //    // return simple content (the URL parameters)
        //    return Content("pageIndex=" + pageIndex + "&sortBy=" + sortBy);
        //}

        //[Route("MoviesController/released/{year}/{month:regex(\\d{4}):range(1,12)")]
        //public ActionResult ByReleaseYear(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}