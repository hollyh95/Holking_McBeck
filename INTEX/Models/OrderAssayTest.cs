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

    public partial class OrderAssayTest
    {
        public int OrderAssayID { get; set; }
        public int TestID { get; set; }
        public Nullable<int> TestConditionID { get; set; }

        [DisplayName("Test Conclusive")]
        public Nullable<int> TestConclusive { get; set; }

        public Nullable<int> StatusID { get; set; }

        public virtual OrderAssay OrderAssay { get; set; }
        public virtual Status Status { get; set; }
        public virtual Test Test { get; set; }
        public virtual TestCondition TestCondition { get; set; }
    }
}
