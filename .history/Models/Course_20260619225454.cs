namespace University_Management_System.Models
{
    public class Course
    {
        public int CrsId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Topics { get; set; } = string.Empty; // stored as comma-separated
        public string HighestDegree { get; set; } = string.Empty;
        public string LowestDegree { get; set; } = string.Empty;

        // Many-to-many → Student (via Enrollment)
        public ICollection<StudentCourse> Enrollments { get; set; } = new List<StudentCourse>();

        // Many-to-many → Instructor (via CourseInstructor)
        public ICollection<CourseInstructor> CourseInstructors { get; set; } =
            new List<CourseInstructor>();
    }
}
