using University_Management_System.Models;

namespace University_Management_System.Models.ViewModels
{
    public class DashboardViewModel
    {
        public int TotalStudents    { get; set; }
        public int TotalCourses     { get; set; }
        public int TotalInstructors { get; set; }
        public int TotalDepartments { get; set; }
        public List<Student> RecentStudents { get; set; } = new();
        public List<Course>  RecentCourses  { get; set; } = new();
    }
}