using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission08_Group2_11.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission08_Group2_11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            return View("AddEdit");
        }

        /*[HttpPost]
        public IActionResult AddTask()
        {
            return View("AddEdit");
        }*/

        /*[HttpGet]
        public IActionResult Edit(int TaskId)
        {
            ViewBag.Categories = movieContext.Categories.ToList();
            var movieForm = movieContext.Movies.Single(x => x.MovieId == MovieId);
            return View("AddMovie", movieForm);
        }

        [HttpPost]
        public IActionResult Edit(Movie mov)
        {
            movieContext.Update(mov);
            movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int MovieId)
        {
            var movie = movieContext.Movies.Single(x => x.MovieId == MovieId);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie mov)
        {
            movieContext.Movies.Remove(mov);
            movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }*/

        public IActionResult Quadrant()
        {
            /*var q1 = movieContext.Responses.Include(x => x.Category).ToList();
            var q2 = movieContext.Responses.Include(x => x.Category).ToList();
            var q3 = movieContext.Responses.Include(x => x.Category).ToList();
            var q4 = movieContext.Responses.Include(x => x.Category).ToList();*/
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
