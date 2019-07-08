using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yon.Models;
using System.Data.Entity;
using Yon.ViewModels;

namespace Yon.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();
            return View(movies);
        }
        public ActionResult Detail(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            IEnumerable<Genre> genres = _context.Genres.ToList();
            MovieFormViewModel MovieViewModel = new MovieFormViewModel
            {
                Genres = genres
            };
            if (id != 0)
                MovieViewModel.Movie = _context.Movies.Single(m => m.Id == id);
            return View("MovieForm", MovieViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if(!ModelState.IsValid)
            {
                var movieViewModel = new MovieFormViewModel
                {
                    Genres = _context.Genres.ToList(),
                    Movie = movie
                };
                return View("MovieForm",movieViewModel);
            }
            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.DateReleased = movie.DateReleased;
                movieInDb.DateAdded = movie.DateAdded;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.GenreId = movie.GenreId;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
    }
}