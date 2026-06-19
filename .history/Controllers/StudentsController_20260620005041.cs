using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using University_Management_System.Data;
using University_Management_System.Models;

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

        public async Task<IActionResult> Create()
        {
            ViewBag.Departments = new SelectList(
                await _db.Departments.ToListAsync(),
                "DeptId",
                "Name"
            );
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Departments = new SelectList(
                    await _db.Departments.ToListAsync(),
                    "DeptId",
                    "Name"
                );
                return View(model);
            }
            _db.Students.Add(model);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Student registered successfully.";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var student = await _db.Students.FindAsync(id);
            if (student == null)
                return NotFound();
            ViewBag.Departments = new SelectList(
                await _db.Departments.ToListAsync(),
                "DeptId",
                "Name",
                student.DepartmentId
            );
            return View(student);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student model)
        {
            if (id != model.Id)
                return BadRequest();
            if (!ModelState.IsValid)
            {
                ViewBag.Departments = new SelectList(
                    await _db.Departments.ToListAsync(),
                    "DeptId",
                    "Name",
                    model.DepartmentId
                );
                return View(model);
            }
            _db.Students.Update(model);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Student updated successfully.";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _db.Students.FindAsync(id);
            if (student == null)
                return NotFound();
            _db.Students.Remove(student);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Student deleted successfully.";
            return RedirectToAction(nameof(Index));
        }
    }
}
