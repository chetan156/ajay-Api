//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajay.Api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMIDetailsDummy
    {
        public int EmiId { get; set; }
        public Nullable<int> SaleId { get; set; }
        public Nullable<double> EmiAmount { get; set; }
        public Nullable<System.DateTime> EmiDate { get; set; }
        public Nullable<System.DateTime> NextEmiDate { get; set; }
    
        public virtual Sale Sale { get; set; }
    }
}
