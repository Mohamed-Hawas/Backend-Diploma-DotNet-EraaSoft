using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_11_Book_My_Doctor.Data;

namespace Task_11_Book_My_Doctor.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DoctorsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: DoctorsController
        public ActionResult Index()
        {
            var doctors = _context.Doctors
                .Include(d => d.Department)
                .Skip(0).Take(3).ToList();

            return View(doctors);
        }

        // GET: DoctorsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DoctorsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoctorsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoctorsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
