using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext mvContext { get; set; }
        //constructor

        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            mvContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Category = mvContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(MovieResponse ar)
        {
            if (ModelState.IsValid)
            {
                mvContext.Add(ar);
                mvContext.SaveChanges();
                return View("Confirmation");
            }
            else
            {
                ViewBag.Category = mvContext.Categories.ToList();
                return View();
            }
            
        }

        [HttpGet]

        public IActionResult ViewMovie()
        {
            var movies = mvContext.MovieResponses
                .Include(x => x.Category)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit (int movieid)
        {
            ViewBag.Category = mvContext.Categories.ToList();

            var movie = mvContext.MovieResponses.Single(x => x.MovieID == movieid);

            return View("MovieForm", movie);
        }


        [HttpPost]
        public IActionResult Edit(MovieResponse mr)
        {
            mvContext.Update(mr);
            mvContext.SaveChanges();
            return RedirectToAction("ViewMovie");
        }
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = mvContext.MovieResponses.Single(x => x.MovieID == movieid);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieResponse mr)
        {

            mvContext.MovieResponses.Remove(mr);
            mvContext.SaveChanges();

            return RedirectToAction("ViewMovie");

        }
    }
}
