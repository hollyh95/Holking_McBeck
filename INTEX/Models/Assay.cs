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

    public partial class Assay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Assay()
        {
            this.AssayTestCatalogs = new HashSet<AssayTestCatalog>();
            this.OrderAssays = new HashSet<OrderAssay>();
            this.LiteratureReferences = new HashSet<LiteratureReference>();
        }
    
        public int AssayID { get; set; }

        [DisplayName("Assay Name")]
        public string AssayName { get; set; }

        [DisplayName("Assay Protocol")]
        public string AssayProtocol { get; set; }

        [DisplayName("Assay Estimated Days to Complete")]
        public Nullable<int> EstimatedDaysToComplete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssayTestCatalog> AssayTestCatalogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderAssay> OrderAssays { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LiteratureReference> LiteratureReferences { get; set; }
    }
}
