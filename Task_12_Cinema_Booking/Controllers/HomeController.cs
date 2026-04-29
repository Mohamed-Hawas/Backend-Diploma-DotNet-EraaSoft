using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Task_12_Cinema_Booking.Models;
using Task_12_Cinema_Booking.Data;
using Task_12_Cinema_Booking.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Task_12_Cinema_Booking.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var movies = _context.Movies
                .Include(m => m.Category)
                .Take(8).ToList();
            return View(movies);
        }

        public IActionResult Details(int id)
        {
            var movie = _context.Movies
                .Include(m => m.Category)
                .Include(m => m.Actors)
                .Include(m => m.Cinema)
                .FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            var viewModel = new MovieWithCategory
            {
                Movie = movie,
                Category = movie.Category,
                Cinema = movie.Cinema,
                Actors = movie.Actors
            };
            return View(viewModel);
        }
        public IActionResult CategoryMovies(int id)
        {
            var movies = _context.Movies
                .Include(m => m.Category)
                .Where(m => m.CategoryId == id)
                .ToList();
            if (movies == null || movies.Count == 0)
            {
                return NotFound();
            }
            return View(movies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
