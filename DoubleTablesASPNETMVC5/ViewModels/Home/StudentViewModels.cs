using DoubleTablesASPNETMVC5.Models.DB;
using DoubleTablesASPNETMVC5.ViewModels.Shared;
using System.Collections.Generic;
using System.Linq;

namespace DoubleTablesASPNETMVC5.ViewModels.Home
{
    public class StudentViewModels
    {
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (StudentDB2Context db = new StudentDB2Context())
            {
                List<Student> std = db.Students.ToList();
                List<ListTypesData> ltd = db.ListTypesDatas.Where(x => x.ListTypeId == (int)ListTypes.Gender).ToList();

                students =  std.Join(ltd,
                            ss => ss.Gender,
                            ld => ld.ListTypeDataId,
                            (ss, ld) => new Student()
                            {
                                StudentId = ss.StudentId,
                                FullName = ss.FullName,
                                GenderDesc = ld.Description,
                                Email = ss.Email,
                                Mobile = ss.Mobile,
                                Telephone = ss.Telephone,
                                Notes = ss.Notes
                            }).ToList();
            }

            return students;
        }

        public Student GetStudentById(int id)
        {
            Student student = new Student();

            using (StudentDB2Context db = new StudentDB2Context())
            {
                student = db.Students.Where(x => x.StudentId == id).FirstOrDefault();
            }

            return student;
        }
    }
}