using Microsoft.AspNetCore.Mvc;
using Movie_Rental.Models;

namespace Movie_Rental.Controllers
{
    public class MoviesController : Controller
    {
        //get /m,ovies/random
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            return View(movie);
        }

        public ActionResult Edit(int MoviesId)
        {
            return Content("Id = " + MoviesId);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format(($"pageIndex={pageIndex} & sortBy= {sortBy}")));
        }
    }
}
