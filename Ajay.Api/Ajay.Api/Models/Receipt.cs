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
    
    public partial class Receipt
    {
        public int ReceiptId { get; set; }
        public Nullable<System.DateTime> ReceiptDate { get; set; }
        public string ReceiptBy { get; set; }
        public Nullable<double> ReceiptAmount { get; set; }
        public Nullable<double> LateFeee { get; set; }
        public string ReceiptNaration { get; set; }
        public Nullable<System.DateTime> ReceiptCreatedDate { get; set; }
        public Nullable<int> SaleId { get; set; }
        public string ReceiptNo { get; set; }
        public string ReciptStatus { get; set; }
        public Nullable<int> DealerSaleId { get; set; }
    }
}
