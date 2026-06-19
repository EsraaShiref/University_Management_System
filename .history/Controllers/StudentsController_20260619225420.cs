using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University_Management_System.Data;

namespace University_Management_System.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _db;

        public StudentsController(AppDbContext db) => _db = db;

        public async Task<IActionResult> Index()
        {
            var students = await _db
                .Students.Include(s => s.Department)
                .Include(s => s.Enrollments)
                .ToListAsync();
            return View(students);
        }
    }
}
