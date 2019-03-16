using DoubleTablesASPNETMVC5.Models.DB;
using DoubleTablesASPNETMVC5.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoubleTablesASPNETMVC5.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentViewModels svm = new StudentViewModels();
            List<Student> students = svm.GetAllStudents();

            return View(students);
        }
    }
}