namespace University_Management_System.Models
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;

        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;

        // Extra payload you can add later (grade, date, etc.)
        public DateTime EnrolledOn { get; set; } = DateTime.UtcNow;
    }
}