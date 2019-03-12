using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoubleTablesASPNETMVC5.Models.DB
{
    public partial class Student
    {
        [Display(Name = "Gender:")]
        public string GenderDesc { get; set; }
    }
}