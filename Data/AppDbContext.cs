using Microsoft.EntityFrameworkCore;
using University_Management_System.Models;

namespace University_Management_System.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ── Enrollment (Student ↔ Course) composite PK ──
            modelBuilder.Entity<StudentCourse>()
                .HasKey(e => new { e.StudentId, e.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId);

            // ── CourseInstructor (Course ↔ Instructor) composite PK ──
            modelBuilder.Entity<CourseInstructor>()
                .HasKey(ci => new { ci.CourseId, ci.InstructorId });

            modelBuilder.Entity<CourseInstructor>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.CourseInstructors)
                .HasForeignKey(ci => ci.CourseId);

            modelBuilder.Entity<CourseInstructor>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.CourseInstructors)
                .HasForeignKey(ci => ci.InstructorId);

            // ── Department PK name ──
            modelBuilder.Entity<Department>()
                .HasKey(d => d.DeptId);

            // ── Instructor PK name ──
            modelBuilder.Entity<Instructor>()
                .HasKey(i => i.InsId);

            // ── Course PK name ──
            modelBuilder.Entity<Course>()
                .HasKey(c => c.CrsId);

            // ── Decimal precision ──
            modelBuilder.Entity<Instructor>()
                .Property(i => i.Salary)
                .HasPrecision(10, 2);
        }
    }
}