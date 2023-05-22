//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicalAutomationSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drug
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drug()
        {
            this.PatientOrderDetails = new HashSet<PatientOrderDetail>();
        }
    
        public int DrugID { get; set; }
        public string DrugName { get; set; }
        public string Manufacturer { get; set; }
        public string Substitutions { get; set; }
        public string Uses { get; set; }
        public string SideEffects { get; set; }
        public string NotRecommended { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public System.DateTime MfgDate { get; set; }
        public System.DateTime ExpDate { get; set; }
        public int QOH { get; set; }
        public string QOHType { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientOrderDetail> PatientOrderDetails { get; set; }
    }
}