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
    
    public partial class SampleTestMaterial
    {
        public int MaterialID { get; set; }
        public int SampleTestID { get; set; }
        public Nullable<int> MaterialAmountActual { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual SampleTest SampleTest { get; set; }
    }
}
