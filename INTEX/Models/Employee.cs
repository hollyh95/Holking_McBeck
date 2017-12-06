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

    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.CompoundSamples = new HashSet<CompoundSample>();
            this.EmployeeTests = new HashSet<EmployeeTest>();
        }

        public int EmpID { get; set; }

        [DisplayName("First Name")]
        [RegularExpression(@"^[A-Z]{1}([a-zA-Z\d\s]*$)", ErrorMessage = "Name field accepts numbers and letters beginning with a capiltal letter.")]
        [Required]
        [StringLength(30, ErrorMessage = "Field must be no longer than 30 characters.")]
        public string EmpFirstName { get; set; }

        [DisplayName("Last Name")]
        [RegularExpression(@"^[A-Z]{1}([a-zA-Z\d\s]*$)", ErrorMessage = "Name field accepts numbers and letters beginning with a capiltal letter.")]
        [Required]
        [StringLength(30, ErrorMessage = "Field must be no longer than 30 characters.")]
        public string EmpLastName { get; set; }

        [DisplayName("Date of Birth")]
        [Required]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid date.")]
        public Nullable<System.DateTime> EmpDOB { get; set; }

        [DisplayName("Taxpayer Identification Number (SSN in USA)")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Please enter only the numberic digits.")]
        [Required]
        [StringLength(30, ErrorMessage = "Field must be no longer than 30 characters.")]
        public string EmpSSN { get; set; }

        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter a valid phone number.")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Please enter only the phone number digits.")]
        [Required]
        [StringLength(30, ErrorMessage = "Field must be no longer than 30 characters.")]
        public string EmpPhone { get; set; }

        [DisplayName("Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email address.")]
        [Required]
        [StringLength(30, ErrorMessage = "Field must be no longer than 30 characters.")]
        public string EmpEmail { get; set; }

        [DisplayName("Street Address 1")]
        [Required]
        [StringLength(30, ErrorMessage = "Field must be no longer than 30 characters.")]
        public string EmpStreetAddress1 { get; set; }

        [DisplayName("Street Address 2")]
        [StringLength(30, ErrorMessage = "Field must be no longer than 30 characters.")]
        public string EmpStreetAddress2 { get; set; }

        public Nullable<int> LocID { get; set; }

        public Nullable<int> AuthID { get; set; }

        [DisplayName("Wage (Dollars per Hour)")]
        [Required]
        [DataType(DataType.Currency, ErrorMessage = "Please enter wage of employee in US dollars.")]
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
