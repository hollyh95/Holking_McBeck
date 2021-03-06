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

    public partial class CompoundSample
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompoundSample()
        {
            this.SampleTests = new HashSet<SampleTest>();
        }

        public int CompoundSampleID { get; set; }

        public Nullable<int> LabsTestID { get; set; }

        [DisplayName("Compound Sequence Code")]
        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Compound Sequence Code must be a number.")]
        public Nullable<int> CompoundSequenceCode { get; set; }

        [DisplayName("Quantity in milligrams")]
        [Required]
        public Nullable<int> Quantity_MG_ { get; set; }

        [DisplayName("Date Arrived")]
        [Required]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid date.")]
        public Nullable<System.DateTime> DateArrived { get; set; }

        public Nullable<int> EmpID { get; set; }

        [DisplayName("Date Due")]
        [Required]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid date.")]
        public Nullable<System.DateTime> DateDue { get; set; }

        [DisplayName("Appearance")]
        [Required]
        [StringLength(30, ErrorMessage = "Field must be no longer than 30 characters.")]
        public string Appearance { get; set; }

        [DisplayName("Weight Measured by Customer in grams")]
        [Required]
        public Nullable<decimal> CustomerWeight { get; set; }

        [DisplayName("Molecular Mass g/mol")]
        [Required]
        public Nullable<decimal> MolecularMass { get; set; }

        [DisplayName("Recept Confirmation Date and Time")]
        [DataType(DataType.DateTime, ErrorMessage = "Please enter a valid date and time.")]
        public Nullable<System.DateTime> ReceiptConfirmationDateTime { get; set; }

        [DisplayName("Actual Weight (If customer measured incorrectly (grams)")]
        public Nullable<decimal> ActualWeight { get; set; }

        [DisplayName("Is Solubilized")]
        [Required]
        public Nullable<int> Solubilized { get; set; }

        public virtual Compound Compound { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SampleTest> SampleTests { get; set; }
    }
}
