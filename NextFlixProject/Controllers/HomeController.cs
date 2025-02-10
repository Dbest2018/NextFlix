using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NextFlixProject.Models;

namespace NextFlixProject.Controllers
{
    public class HomeController : Controller
    {   
        private MovieContext Context {  get; set; }

        //Constructor accepts DB context object that's enabled by DI
        public HomeController(MovieContext ctx)
        {
            Context = ctx;
        }
        public IActionResult Index()
        {
            var movies = Context.Movies.Include(m => m.Genre).OrderBy(m => m.MovieName).ToList();
            return View(movies);
        }
    }
}
