using System.Diagnostics;
using BelajarView.Models;
using Microsoft.AspNetCore.Mvc;

namespace BelajarView.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<Student> listStudents = new List<Student>()
            {
               new Student() { Id = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student() { Id = 102, Name = "Smith", Branch = "ETC", Section = "B", Gender = "Male" },
               new Student() { Id = 103, Name = "David", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student() { Id = 104, Name = "Sara", Branch = "CSE", Section = "A", Gender = "Female" },
               new Student() { Id = 105, Name = "Pam", Branch = "ETC", Section = "B", Gender = "Female" }
            };
            return View(listStudents);
        }
        public ViewResult Details(int Id)
        {
            var studentDetails = new Student() { Id = Id, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" };
            return View(studentDetails);
        }
        public ViewResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public ViewResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
