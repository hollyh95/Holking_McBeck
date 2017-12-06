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

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Invoices = new HashSet<Invoice>();
            this.OrderAssays = new HashSet<OrderAssay>();
        }
    
        public int OrderID { get; set; }
        public Nullable<int> CustID { get; set; }

        [DisplayName("Order Comments")]
        public string OrderComments { get; set; }

        public Nullable<int> OrderStatusID { get; set; }

        [DisplayName("Order Discount (Dollars)")]
        public Nullable<decimal> OrderDiscount { get; set; }

        [DisplayName("Quoted Price")]
        public Nullable<decimal> QuotedPrice { get; set; }

        [DisplayName("Order Urgent")]
        public Nullable<int> OrderUrgency { get; set; }

        [DisplayName("Order Approved by Customer")]
        public Nullable<int> OrderApproval { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual OrderStatu OrderStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderAssay> OrderAssays { get; set; }
    }
}
