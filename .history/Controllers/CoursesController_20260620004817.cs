using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University_Management_System.Data;
using University_Management_System.Models;

namespace University_Management_System.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _db;

        public CoursesController(AppDbContext db) => _db = db;

        public async Task<IActionResult> Index()
        {
            var courses = await _db
                .Courses.Include(c => c.StudentCourses)
                .Include(c => c.CourseInstructors)
                    .ThenInclude(ci => ci.Instructor)
                .ToListAsync();
            return View(courses);
        }

        public IActionResult Create() => View();

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course model)
        {
            if (!ModelState.IsValid)
                return View(model);
            _db.Courses.Add(model);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Course created successfully.";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var course = await _db.Courses.FindAsync(id);
            if (course == null)
                return NotFound();
            return View(course);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Course model)
        {
            if (id != model.CrsId)
                return BadRequest();
            if (!ModelState.IsValid)
                return View(model);
            _db.Courses.Update(model);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Course updated successfully.";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var course = await _db.Courses.FindAsync(id);
            if (course == null)
                return NotFound();
            _db.Courses.Remove(course);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Course deleted successfully.";
            return RedirectToAction(nameof(Index));
        }
    }
}
