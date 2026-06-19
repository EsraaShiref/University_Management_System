using Microsoft.EntityFrameworkCore;
using University_Management_System.Models;

namespace University_Management_System.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ── Enrollment (Student ↔ Course) composite PK ──
            modelBuilder.Entity<StudentCourse>().HasKey(e => new { e.StudentId, e.CourseId });

            modelBuilder
                .Entity<StudentCourse>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder
                .Entity<StudentCourse>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId);

            // ── CourseInstructor (Course ↔ Instructor) composite PK ──
            modelBuilder
                .Entity<CourseInstructor>()
                .HasKey(ci => new { ci.CourseId, ci.InstructorId });

            modelBuilder
                .Entity<CourseInstructor>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.CourseInstructors)
                .HasForeignKey(ci => ci.CourseId);

            modelBuilder
                .Entity<CourseInstructor>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.CourseInstructors)
                .HasForeignKey(ci => ci.InstructorId);

            // ── Department PK name ──
            modelBuilder.Entity<Department>().HasKey(d => d.DeptId);

            // ── Instructor PK name ──
            modelBuilder.Entity<Instructor>().HasKey(i => i.InsId);

            // ── Course PK name ──
            modelBuilder.Entity<Course>().HasKey(c => c.CrsId);

            // ── Decimal precision ──
            modelBuilder.Entity<Instructor>().Property(i => i.Salary).HasPrecision(10, 2);

            // ── SEED DATA ──────────────────────────────────────────────
            modelBuilder
                .Entity<Department>()
                .HasData(
                    new Department
                    {
                        DeptId = 1,
                        Name = "Computer Science",
                        Location = "Building A, Floor 2",
                        PhoneNumber = "555-0101",
                    },
                    new Department
                    {
                        DeptId = 2,
                        Name = "Mathematics",
                        Location = "Building B, Floor 1",
                        PhoneNumber = "555-0102",
                    },
                    new Department
                    {
                        DeptId = 3,
                        Name = "Electrical Engineering",
                        Location = "Building C, Floor 3",
                        PhoneNumber = "555-0103",
                    }
                );

            modelBuilder
                .Entity<Instructor>()
                .HasData(
                    new Instructor
                    {
                        InsId = 1,
                        Name = "Dr. Sarah Mitchell",
                        Age = 45,
                        Salary = 85000,
                        Degree = "PhD Computer Science",
                        Email = "s.mitchell@uni.edu",
                        Address = "12 Oak Street",
                        DepartmentId = 1,
                    },
                    new Instructor
                    {
                        InsId = 2,
                        Name = "Dr. James Okonkwo",
                        Age = 52,
                        Salary = 92000,
                        Degree = "PhD Mathematics",
                        Email = "j.okonkwo@uni.edu",
                        Address = "34 Maple Avenue",
                        DepartmentId = 2,
                    },
                    new Instructor
                    {
                        InsId = 3,
                        Name = "Dr. Lena Hoffmann",
                        Age = 38,
                        Salary = 78000,
                        Degree = "PhD Electrical Eng.",
                        Email = "l.hoffmann@uni.edu",
                        Address = "56 Pine Road",
                        DepartmentId = 3,
                    },
                    new Instructor
                    {
                        InsId = 4,
                        Name = "Dr. Omar Farouk",
                        Age = 41,
                        Salary = 81000,
                        Degree = "PhD Computer Science",
                        Email = "o.farouk@uni.edu",
                        Address = "78 Cedar Lane",
                        DepartmentId = 1,
                    },
                    new Instructor
                    {
                        InsId = 5,
                        Name = "Prof. Amina Yusuf",
                        Age = 36,
                        Salary = 74000,
                        Degree = "MSc Mathematics",
                        Email = "a.yusuf@uni.edu",
                        Address = "90 Birch Blvd",
                        DepartmentId = 2,
                    }
                );

            modelBuilder
                .Entity<Course>()
                .HasData(
                    new Course
                    {
                        CrsId = 1,
                        Name = "Data Structures",
                        Description = "Core concepts of data organization",
                        Topics = "Arrays,Linked Lists,Trees,Graphs",
                        HighestDegree = "A",
                        LowestDegree = "D",
                    },
                    new Course
                    {
                        CrsId = 2,
                        Name = "Calculus I",
                        Description = "Differential and integral calculus",
                        Topics = "Limits,Derivatives,Integrals",
                        HighestDegree = "A",
                        LowestDegree = "D",
                    },
                    new Course
                    {
                        CrsId = 3,
                        Name = "Digital Circuits",
                        Description = "Logic gates and circuit design",
                        Topics = "Boolean Algebra,Gates,Flip-Flops",
                        HighestDegree = "A",
                        LowestDegree = "D",
                    },
                    new Course
                    {
                        CrsId = 4,
                        Name = "Algorithms",
                        Description = "Design and analysis of algorithms",
                        Topics = "Sorting,Searching,Dynamic Programming",
                        HighestDegree = "A",
                        LowestDegree = "D",
                    },
                    new Course
                    {
                        CrsId = 5,
                        Name = "Linear Algebra",
                        Description = "Matrices, vectors and linear systems",
                        Topics = "Matrices,Vectors,Eigenvalues",
                        HighestDegree = "A",
                        LowestDegree = "D",
                    }
                );

            modelBuilder
                .Entity<Student>()
                .HasData(
                    new Student
                    {
                        Id = 1,
                        Name = "Ahmed Hassan",
                        DepartmentId = 1,
                    },
                    new Student
                    {
                        Id = 2,
                        Name = "Sara El-Sayed",
                        DepartmentId = 1,
                    },
                    new Student
                    {
                        Id = 3,
                        Name = "Mohamed Ali",
                        DepartmentId = 2,
                    },
                    new Student
                    {
                        Id = 4,
                        Name = "Nour Khalil",
                        DepartmentId = 3,
                    },
                    new Student
                    {
                        Id = 5,
                        Name = "Youssef Ibrahim",
                        DepartmentId = 2,
                    },
                    new Student
                    {
                        Id = 6,
                        Name = "Fatma Mostafa",
                        DepartmentId = 1,
                    },
                    new Student
                    {
                        Id = 7,
                        Name = "Omar Adel",
                        DepartmentId = 3,
                    },
                    new Student
                    {
                        Id = 8,
                        Name = "Aya Sherif",
                        DepartmentId = 2,
                    }
                );

            modelBuilder
                .Entity<StudentCourse>()
                .HasData(
                    new StudentCourse
                    {
                        StudentId = 1,
                        CourseId = 1,
                        EnrolledOn = new DateTime(2024, 9, 1),
                    },
                    new StudentCourse
                    {
                        StudentId = 1,
                        CourseId = 4,
                        EnrolledOn = new DateTime(2024, 9, 1),
                    },
                    new StudentCourse
                    {
                        StudentId = 2,
                        CourseId = 1,
                        EnrolledOn = new DateTime(2024, 9, 1),
                    },
                    new StudentCourse
                    {
                        StudentId = 2,
                        CourseId = 2,
                        EnrolledOn = new DateTime(2024, 9, 1),
                    },
                    new StudentCourse
                    {
                        StudentId = 3,
                        CourseId = 2,
                        EnrolledOn = new DateTime(2024, 9, 1),
                    },
                    new StudentCourse
                    {
                        StudentId = 3,
                        CourseId = 5,
                        EnrolledOn = new DateTime(2024, 9, 1),
                    },
                    new StudentCourse
                    {
                        StudentId = 4,
                        CourseId = 3,
                        EnrolledOn = new DateTime(2024, 9, 1),
                    },
                    new StudentCourse
                    {
                        StudentId = 5,
                        CourseId = 2,
                        EnrolledOn = new DateTime(2024, 9, 1),
                    },
                    new StudentCourse
                    {
                        StudentId = 5,
                        CourseId = 5,
                        EnrolledOn = new DateTime(2024, 9, 1),
                    },
                    new StudentCourse
                    {
                        StudentId = 6,
                        CourseId = 1,
                        EnrolledOn = new DateTime(2024, 9, 1),
                    },
                    new StudentCourse
                    {
                        StudentId = 7,
                        CourseId = 3,
                        EnrolledOn = new DateTime(2024, 9, 1),
                    },
                    new StudentCourse
                    {
                        StudentId = 8,
                        CourseId = 2,
                        EnrolledOn = new DateTime(2024, 9, 1),
                    }
                );

            modelBuilder
                .Entity<CourseInstructor>()
                .HasData(
                    new CourseInstructor { CourseId = 1, InstructorId = 1 },
                    new CourseInstructor { CourseId = 1, InstructorId = 4 },
                    new CourseInstructor { CourseId = 2, InstructorId = 2 },
                    new CourseInstructor { CourseId = 3, InstructorId = 3 },
                    new CourseInstructor { CourseId = 4, InstructorId = 1 },
                    new CourseInstructor { CourseId = 5, InstructorId = 2 },
                    new CourseInstructor { CourseId = 5, InstructorId = 5 }
                );
        }
    }
}
