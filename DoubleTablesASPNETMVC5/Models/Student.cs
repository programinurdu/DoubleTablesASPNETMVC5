using System.ComponentModel.DataAnnotations;

namespace DoubleTablesASPNETMVC5.Models.DB
{
    public partial class Student
    {
        [Display(Name = "Gender:")]
        public string GenderDesc { get; set; }
    }
}