using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University_Management_System.Data;

namespace University_Management_System.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _db;
        public CoursesController(AppDbContext db) => _db = db;

        public async Task<IActionResult> Index()
        {
            var courses = await _db.Course
                .Include(c => c.Enrollments)
                .Include(c => c.CourseInstructors)
                    .ThenInclude(ci => ci.Instructor)
                .ToListAsync();
            return View(courses);
        }
    }
}