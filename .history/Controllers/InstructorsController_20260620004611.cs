using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using University_Management_System.Data;
using University_Management_System.Models;

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
                .Include(i => i.CourseInstructors).ThenInclude(ci => ci.Course)
                .ToListAsync();
            return View(instructors);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Departments = new SelectList(await _db.Departments.ToListAsync(), "DeptId", "Name");
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Instructor model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Departments = new SelectList(await _db.Departments.ToListAsync(), "DeptId", "Name");
                return View(model);
            }
            _db.Instructors.Add(model);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Instructor added successfully.";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var instructor = await _db.Instructors.FindAsync(id);
            if (instructor == null) return NotFound();
            ViewBag.Departments = new SelectList(await _db.Departments.ToListAsync(), "DeptId", "Name", instructor.DepartmentId);
            return View(instructor);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Instructor model)
        {
            if (id != model.InsId) return BadRequest();
            if (!ModelState.IsValid)
            {
                ViewBag.Departments = new SelectList(await _db.Departments.ToListAsync(), "DeptId", "Name", model.DepartmentId);
                return View(model);
            }
            _db.Instructors.Update(model);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Instructor updated successfully.";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var instructor = await _db.Instructors.FindAsync(id);
            if (instructor == null) return NotFound();
            _db.Instructors.Remove(instructor);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Instructor deleted successfully.";
            return RedirectToAction(nameof(Index));
        }
    }
}