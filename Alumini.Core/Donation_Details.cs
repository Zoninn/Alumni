//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alumini.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Donation_Details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Donation_Details()
        {
            this.Donor_Details = new HashSet<Donor_Details>();
        }
    
        public long Donation_ID { get; set; }
        public string Donation_Title { get; set; }
        public string Donation_Description { get; set; }
        public Nullable<decimal> Donation_Amount { get; set; }
        public string Donation_Banner { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donor_Details> Donor_Details { get; set; }
    }
}