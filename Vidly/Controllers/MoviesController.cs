using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private List<Movie> movies = new List<Movie>
        {
            new Movie {Name = "Shrek", Id = 1, Rating = 2},
            new Movie {Name = "Indiana Jones", Id = 2, Rating = 5},
            new Movie {Name = "Star Wars ep. IV: A New Hope", Id = 3, Rating = 4},
        };

        

        /** List movies */
        public ActionResult Index()
        {
            var viewModel = new MovieIndexViewModel
            {
                Movies = movies
            };
            return View(viewModel);
        }

        /** Detail a single movie */
        public ActionResult Detail(string show, int id)
        {
            if (show.Equals("show"))
            {
                
            }
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer1"},
                new Customer { Name = "Customer2"}
            };

            var viewModel = new MovieDetailViewModel
            {
                Movie = movies.Find(x => x.Id == id),
                Customers = customers
            };
            return View(viewModel);
        }
        
        /** Show a random movie from the list */
        public ActionResult Random()
        {
            var id = new Random().Next(1, 3);
            return RedirectToAction("Detail", "Movies", new { show = "show", id});
        }

        /** Prints out the release date */
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}