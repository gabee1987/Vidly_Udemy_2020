using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_Udemy_2020.Models;

namespace Vidly_Udemy_2020.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Inception" };
            return View( movie );
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