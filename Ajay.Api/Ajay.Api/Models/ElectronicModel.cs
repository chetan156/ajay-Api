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
    
    public partial class ElectronicModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ElectronicModel()
        {
            this.OwnStocks = new HashSet<OwnStock>();
            this.Purchases = new HashSet<Purchase>();
            this.PurchaseSerialNoes = new HashSet<PurchaseSerialNo>();
            this.Stocks = new HashSet<Stock>();
            this.StockOrders = new HashSet<StockOrder>();
        }
    
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public Nullable<int> CatagoryId { get; set; }
        public Nullable<int> CompanyId { get; set; }
    
        public virtual Company Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OwnStock> OwnStocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase> Purchases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseSerialNo> PurchaseSerialNoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock> Stocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockOrder> StockOrders { get; set; }
    }
}
