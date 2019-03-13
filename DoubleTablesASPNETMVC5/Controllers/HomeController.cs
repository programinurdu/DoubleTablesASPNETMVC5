using DoubleTablesASPNETMVC5.Models.DB;
using DoubleTablesASPNETMVC5.ViewModels.Home;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DoubleTablesASPNETMVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult TutorialsList()
        {
            return View();
        }

        // GET: Home
        public ActionResult Index()
        {
            StudentViewModels svm = new StudentViewModels();
            List<Student> students = svm.GetAllStudents();

            return View(students);
        }

        public ActionResult LoadDropDownList()
        {
            return View();
        }

        public ActionResult Edit(int id=0)
        {
            if (id == 0) { return RedirectToAction("Index", "Home"); }

            StudentViewModels svm = new StudentViewModels();
            Student student = svm.GetStudentById(id);
            ViewData["Gender"] = student.Gender;

            return View("~/Views/Home/LoadDropDownList.cshtml", student);
        }
    }
}