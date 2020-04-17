using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_Udemy_2020.Models;
using Vidly_Udemy_2020.ViewModels;

namespace Vidly_Udemy_2020.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Inception" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" },
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie     = movie,
                Customers = customers
            };

            return View( viewModel );

            // Dont use ViewData or ViewBag!!!
            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;
            //return View();

            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model // <- ViewData is a special dictionary

            //return View( movie ); // Without viewData


            //return Content( "Hello World!" );
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction( "Index", "Home", new { page = 1, sortBy = "name" } );



        }

        public ActionResult Edit( int id )
        {
            return Content( "id=" + id );
        }

        public ActionResult Index( int? pageIndex, string sortBy )
        {
            if ( !pageIndex.HasValue )
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content( String.Format( "pageindex={0}&sortBy={1}", pageIndex, sortBy ) );
        }

        [Route( "movies/release/{year}/{month:regex(\\d{4}):range(1, 12)}" )] // <- applying constraints to routing
        public ActionResult ByReleaseDate( int year, int month )
        {
            return Content( year + "/" + month );
        }  
    }
}