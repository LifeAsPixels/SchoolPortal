// Controllers/CourseController.cs
using Microsoft.AspNetCore.Mvc;
using SchoolPortal.Models;

namespace SchoolPortal.Controllers
{
    public class CourseController : Controller
    {
        // Sample in-memory list of courses
        private static List<Course> courses = new List<Course>
        {
            new Course { Id = 1, Name = "Math 101", Description = "Basic Mathematics", Credits = 3 },
            new Course { Id = 2, Name = "History 201", Description = "World History", Credits = 4 },
            new Course { Id = 3, Name = "Science 301", Description = "Basic Science", Credits = 3 },
            new Course { Id = 4, Name = "English 101", Description = "Basic English", Credits = 3 },
            new Course { Id = 5, Name = "Computer Science 101", Description = "Introduction to Computer Science", Credits = 4 }
        };

        // Display all courses
        public IActionResult Index()
        {
            return View(courses); // Pass the list of courses to the view
        }

        // Show course details by ID
        public IActionResult Details(int id)
        {
            var course = courses.FirstOrDefault(c => c.Id == id); // Find the course by ID
            if (course == null)
                return NotFound(); // Return 404 if not found

            return View(course); // Pass the course to the view
        }
    }
}
