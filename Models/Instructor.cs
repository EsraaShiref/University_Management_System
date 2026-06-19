namespace University_Management_System.Models
{
    public class Instructor
    {
        public int InsId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string Degree { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        // FK → Department
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        // Many-to-many → Course
        public ICollection<CourseInstructor> CourseInstructors { get; set; } = new List<CourseInstructor>();
    }
}