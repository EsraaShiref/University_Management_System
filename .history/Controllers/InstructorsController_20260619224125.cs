using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University_Management_System.Data;

namespace University_Management_System.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly AppDbContext _db;
        public InstructorsController(AppDbContext db) => _db = db;

        public async Task<IActionResult> Index()
        {
            var instructors = await _db.Instructors
                .Include(i => i.Department)
                .Include(i => i.CourseInstructors)
                    .ThenInclude(ci => ci.Course)
                .ToListAsync();
            return View(instructors);
        }
    }
}