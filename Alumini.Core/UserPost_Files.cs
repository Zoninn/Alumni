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
    
    public partial class UserPost_Files
    {
        public int FileId { get; set; }
        public Nullable<int> PostId { get; set; }
        public string FilePath { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual UserPost UserPost { get; set; }
    }
}
