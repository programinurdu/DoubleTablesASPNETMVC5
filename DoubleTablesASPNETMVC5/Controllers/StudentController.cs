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

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult NewStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                StudentViewModels svm = new StudentViewModels();
                svm.AddNewStudent(student);
            }

            return View();
        }

        public ActionResult StudentQualification(int id=0)
        {
            if (id == 0) { return RedirectToAction("NewStudent", "Student"); }

            StudentViewModels svm = new StudentViewModels();
            List<StudentsQualification> qualifications = svm.GetStudentQualificationById(id);

            return View(qualifications);
        }
    }
}