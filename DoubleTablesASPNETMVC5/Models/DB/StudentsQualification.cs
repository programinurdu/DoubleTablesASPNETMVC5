//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoubleTablesASPNETMVC5.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentsQualification
    {
        public int StudentQualificationId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string QualificationName { get; set; }
        public string Result { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
