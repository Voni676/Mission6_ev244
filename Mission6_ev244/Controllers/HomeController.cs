using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6_ev244.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_ev244.Controllers
{
    public class HomeController : Controller
    {
       
        private MovieContext daContext { get; set; }

        public HomeController(MovieContext mc)
        {
        
            daContext = mc;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            ViewBag.Categories = daContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Form(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                daContext.Add(ar);
                daContext.SaveChanges();
                return View("Conformation", ar);
            }
            else
            {
                ViewBag.Categories = daContext.Categories.ToList();

                return View();
            }
        }
       

        public IActionResult MyPodcasts()
        {
            return View();
        }

        public IActionResult ListMovies()
        {
            var applications = daContext.responses
                .Include(x => x.Category)
                .OrderBy(y => y.Title)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = daContext.Categories.ToList();

            var form = daContext.responses.Single(x => x.MovieId == movieid);

            return View("Form", form);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse blah)
        {
            daContext.Update(blah);
            daContext.SaveChanges();
            // redirects to ListMovies Action above
            return RedirectToAction("ListMovies");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var form = daContext.responses.Single(x => x.MovieId == movieid);

            return View(form);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            daContext.responses.Remove(ar);
            daContext.SaveChanges();

            return RedirectToAction("ListMovies");

            return View();
        }

    }
}
