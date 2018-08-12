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
    
    public partial class Purchase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Purchase()
        {
            this.PurchaseSerialNoes = new HashSet<PurchaseSerialNo>();
        }
    
        public int PurchaseId { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public string PurchaseBillNo { get; set; }
        public Nullable<int> PurchaseModelId { get; set; }
        public Nullable<int> PurchaseQuantity { get; set; }
        public string PurchaseNaration { get; set; }
        public Nullable<int> PurchaseCatagoryId { get; set; }
        public Nullable<int> CompanyId { get; set; }
    
        public virtual Catagory Catagory { get; set; }
        public virtual Company Company { get; set; }
        public virtual ElectronicModel ElectronicModel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseSerialNo> PurchaseSerialNoes { get; set; }
    }
}
