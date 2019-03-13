using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoubleTablesASPNETMVC5.Models.DB
{
    [MetadataType(typeof(StudentMetaData))]
    public partial class Student
    {
        [Display(Name = "Gender")]
        public string GenderDesc { get; set; }
    }

    public class StudentMetaData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentMetaData()
        {
            this.StudentsQualifications = new HashSet<StudentsQualification>();
        }

        public int StudentId { get; set; }

        [Display(Name = "Full Name:")]
        public string FullName { get; set; }

        [Display(Name = "Email:")]
        public string Email { get; set; }

        [Display(Name = "Gender:")]
        [UIHint("GenderDropDownList")]
        public Nullable<int> Gender { get; set; }

        [Display(Name = "Mobile:")]
        public string Mobile { get; set; }

        [Display(Name = "Telephone:")]
        public string Telephone { get; set; }

        [Display(Name = "Notes:")]
        public string Notes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentsQualification> StudentsQualifications { get; set; }

    }

}