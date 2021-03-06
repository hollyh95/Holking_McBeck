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

    public partial class TestMaterial
    {
        public int TestID { get; set; }

        public int MaterialID { get; set; }

        [DisplayName("Estimated Material Amount (kilograms)")]
        [Required]
        public int MaterialAmountEst { get; set; }

        public virtual Material Material { get; set; }
        public virtual Test Test { get; set; }
    }
}
