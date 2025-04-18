// Models/Course.cs
namespace SchoolPortal.Models
{
    public class Course
    {
        public int Id { get; set; }             // Unique course identifier
        public string Name { get; set; }        // Name of the course
        public string Description { get; set; } // Description of the course
        public int Credits { get; set; }        // Number of credit hours
    }
}
