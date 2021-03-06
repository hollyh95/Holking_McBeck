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

    public partial class Payment
    {
        public int PaymentID { get; set; }

        public Nullable<int> InvoiceID { get; set; }

        [DisplayName("Payment Amount")]
        [Required]
        [DataType(DataType.Currency, ErrorMessage = "Enter the payment amount in US Dollars.")]
        public Nullable<decimal> PaymentAmt { get; set; }

        [DisplayName("Payment Date Received")]
        [Required]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid date.")]
        public Nullable<System.DateTime> PaymentDate { get; set; }

        public Nullable<int> PaymentTypeID { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual PaymentType PaymentType { get; set; }
    }
}
