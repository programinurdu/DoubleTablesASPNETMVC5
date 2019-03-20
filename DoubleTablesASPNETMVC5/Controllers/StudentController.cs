using DoubleTablesASPNETMVC5.Models.DB;
using DoubleTablesASPNETMVC5.ViewModels.Home;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DoubleTablesASPNETMVC5.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StudentsList()
        {
            StudentViewModels svm = new StudentViewModels();
            List<Student> students = svm.GetAllStudents();

            //return View(students);
            return Json(new { data = students }, JsonRequestBehavior.AllowGet);
        }


        // New Student Screen
        public ActionResult NewStudent()
        {
            return View();
        }
    }
}