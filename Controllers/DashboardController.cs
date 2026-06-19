using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University_Management_System.Data;
using University_Management_System.Models.ViewModels;

namespace University_Management_System.Controllers
{
    public class DashboardController : Controller
    {
        private readonly AppDbContext _db;

        public DashboardController(AppDbContext db) => _db = db;

        public async Task<IActionResult> Index()
        {
            var vm = new DashboardViewModel
            {
                TotalStudents = await _db.Students.CountAsync(),
                TotalCourses = await _db.Courses.CountAsync(),
                TotalInstructors = await _db.Instructors.CountAsync(),
                TotalDepartments = await _db.Departments.CountAsync(),
                RecentStudents = await _db
                    .Students.Include(s => s.Department)
                    .Take(5)
                    .ToListAsync(),
                RecentCourses = await _db.Courses.Include(c => c.Enrollments).Take(5).ToListAsync(),
            };
            return View(vm);
        }
    }
}
