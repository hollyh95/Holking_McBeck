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

    public partial class SampleTestEquipment
    {
        public int EquipmentID { get; set; }

        public int SampleTestID { get; set; }

        [DisplayName("Hours Used")]
        public Nullable<decimal> HoursUsed { get; set; }

        public virtual Equipment Equipment { get; set; }
        public virtual SampleTest SampleTest { get; set; }
    }
}
