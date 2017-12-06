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
    
    public partial class CompoundSample
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompoundSample()
        {
            this.SampleTests = new HashSet<SampleTest>();
        }
    
        public int CompoundSampleID { get; set; }
        public Nullable<int> LabsTestID { get; set; }
        public Nullable<int> CompoundSequenceCode { get; set; }
        public Nullable<int> Quantity_MG_ { get; set; }
        public Nullable<System.DateTime> DateArrived { get; set; }
        public Nullable<int> EmpID { get; set; }
        public Nullable<System.DateTime> DateDue { get; set; }
        public string Appearance { get; set; }
        public Nullable<decimal> CustomerWeight { get; set; }
        public Nullable<decimal> MolecularMass { get; set; }
        public Nullable<System.DateTime> ReceiptConfirmationDateTime { get; set; }
        public Nullable<decimal> ActualWeight { get; set; }
        public Nullable<int> Solubilized { get; set; }
    
        public virtual Compound Compound { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SampleTest> SampleTests { get; set; }
    }
}
