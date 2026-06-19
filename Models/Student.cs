namespace University_Management_System.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // FK → Department
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        // Many-to-many → Course
        public ICollection<StudentCourse> Enrollments { get; set; } = new List<StudentCourse>();
    }
}