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
    
    public partial class ProfessionalDetail
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Company { get; set; }
        public string Designation { get; set; }
        public string WorkedFrom { get; set; }
        public string WorkedTill { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual UserDetail UserDetail { get; set; }
    }
}
