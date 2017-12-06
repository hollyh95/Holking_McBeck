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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.CompoundSamples = new HashSet<CompoundSample>();
            this.EmployeeTests = new HashSet<EmployeeTest>();
        }
    
        public int EmpID { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public Nullable<System.DateTime> EmpDOB { get; set; }
        public string EmpSSN { get; set; }
        public string EmpPhone { get; set; }
        public string EmpEmail { get; set; }
        public string EmpStreetAddress1 { get; set; }
        public string EmpStreetAddress2 { get; set; }
        public Nullable<int> LocID { get; set; }
        public Nullable<int> AuthID { get; set; }
        public Nullable<decimal> Wage { get; set; }
        public string UserID { get; set; }
        public Nullable<int> EmpTypeID { get; set; }
    
        public virtual Authorization Authorization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompoundSample> CompoundSamples { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }
        public virtual Location Location { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeTest> EmployeeTests { get; set; }
    }
}
