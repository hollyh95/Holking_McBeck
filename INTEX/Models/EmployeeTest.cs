//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INTEX.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class EmployeeTest
    {
        public int EmpID { get; set; }
        public int SampleTestID { get; set; }

        [DisplayName("Hours Worked")]
        [Required]
        public Nullable<int> HoursWorked { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual SampleTest SampleTest { get; set; }
    }
}
