using Bookify.Data;
using Bookify.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookify.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Home()
        {
            return View();
        }
        // POST: Employee/Register
        [HttpPost]
        public IActionResult Register(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Add(employee);
                _db.SaveChanges();
                return RedirectToAction("Home");
            }
            return View(employee);
        }

    }
}