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

    public partial class TestCondition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestCondition()
        {
            this.AssayTestCatalogs = new HashSet<AssayTestCatalog>();
            this.OrderAssayTests = new HashSet<OrderAssayTest>();
        }

        public int TestConditionID { get; set; }

        [DisplayName("Test Condition Description")]
        [Required]
        [StringLength(30, ErrorMessage = "Field must be no longer than 30 characters.")]
        public string TestConditionDesc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssayTestCatalog> AssayTestCatalogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderAssayTest> OrderAssayTests { get; set; }
    }
}
