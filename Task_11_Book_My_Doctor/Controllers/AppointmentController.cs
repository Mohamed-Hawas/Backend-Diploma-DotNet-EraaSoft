using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_11_Book_My_Doctor.Data;
using Task_11_Book_My_Doctor.ViewModels;

namespace Task_11_Book_My_Doctor.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _context = new();
        // GET: AppointmentController
        public ActionResult Index()
        {
            AppointmentCreateVM vm = new AppointmentCreateVM()
            {
                Doctors = _context.Doctors.Include(d => d.Appointments).ToList(),
                Departments = _context.Departments.ToList()

            };
            return View(vm);
        }

        // GET: AppointmentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AppointmentController/Create
        [HttpPost]
        public ActionResult Create(AppointmentCreateVM vm)
        {
            DateTime dateTime;
            if (!DateTime.TryParse(vm.Date + " " + vm.Time, out dateTime))
            {
                return View("Index",vm);
            }

            var patient = new Patient()
            {
                Name = vm.PatientName,
                Email = vm.PatientEmail,
            };

            _context.Patients.Add(patient);
            _context.SaveChanges();

            var appointment = new Appointment()
            {
                DoctorId = vm.DoctorId,
                PatientId = patient.Id,
                Date = dateTime,
            };

            _context.Appointments.Add(appointment);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        //// POST: AppointmentController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: AppointmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AppointmentController/Edit/5
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

        // GET: AppointmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AppointmentController/Delete/5
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
