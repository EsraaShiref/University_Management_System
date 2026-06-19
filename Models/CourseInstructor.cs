namespace University_Management_System.Models
{
    public class CourseInstructor
    {
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; } = null!;
    }
}