using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University_Management_System.Data;

namespace University_Management_System.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly AppDbContext _db;

        public DepartmentsController(AppDbContext db) => _db = db;

        public async Task<IActionResult> Index()
        {
            var departments = await _db
                .Departments.Include(d => d.Students)
                .Include(d => d.Instructors)
                .ToListAsync();
            return View(departments);
        }
    }
}
