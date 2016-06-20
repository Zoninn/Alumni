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
    
    public partial class Event_UserSelections
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event_UserSelections()
        {
            this.Events_UserBookings = new HashSet<Events_UserBookings>();
            this.Event_UserPayments = new HashSet<Event_UserPayments>();
        }
    
        public int EventSelectionId { get; set; }
        public Nullable<int> EventId { get; set; }
        public Nullable<long> UserId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> UserBookingDate { get; set; }
    
        public virtual Def_Events Def_Events { get; set; }
        public virtual UserDetail UserDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Events_UserBookings> Events_UserBookings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event_UserPayments> Event_UserPayments { get; set; }
    }
}
