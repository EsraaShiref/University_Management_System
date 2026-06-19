using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University_Management_System.Data;
using University_Management_System.Models;

namespace University_Management_System.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly AppDbContext _db;
        public DepartmentsController(AppDbContext db) => _db = db;

        // GET: /Departments
        public async Task<IActionResult> Index()
        {
            var departments = await _db.Departments
                .Include(d => d.Students)
                .Include(d => d.Instructors)
                .ToListAsync();
            return View(departments);
        }

        // GET: /Departments/Create
        public IActionResult Create() => View();

        // POST: /Departments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Department model)
        {
            if (!ModelState.IsValid) return View(model);
            _db.Departments.Add(model);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Department created successfully.";
            return RedirectToAction(nameof(Index));
        }

        // GET: /Departments/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var dept = await _db.Departments.FindAsync(id);
            if (dept == null) return NotFound();
            return View(dept);
        }

        // POST: /Departments/Edit/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Department model)
        {
            if (id != model.DeptId) return BadRequest();
            if (!ModelState.IsValid) return View(model);
            _db.Departments.Update(model);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Department updated successfully.";
            return RedirectToAction(nameof(Index));
        }

        // POST: /Departments/Delete/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var dept = await _db.Departments.FindAsync(id);
            if (dept == null) return NotFound();
            _db.Departments.Remove(dept);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Department deleted successfully.";
            return RedirectToAction(nameof(Index));
        }
    }
}