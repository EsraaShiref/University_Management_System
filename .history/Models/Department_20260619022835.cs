namespace University_Management_System.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        // One-to-many → Instructor
        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

        // One-to-many → Student
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}