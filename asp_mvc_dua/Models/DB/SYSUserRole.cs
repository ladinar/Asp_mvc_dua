//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace asp_mvc_dua.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYSUserRole
    {
        public int SYSUserRoleID { get; set; }
        public int SYSUserID { get; set; }
        public int LOOKUPRoleID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public int RowCreatedSYSUserID { get; set; }
        public Nullable<System.DateTime> RowCreatedDateTime { get; set; }
        public int RowModifiedSYSUserID { get; set; }
        public Nullable<System.DateTime> RowModifiedDateTime { get; set; }
    
        public virtual LOOKUPRole LOOKUPRole { get; set; }
        public virtual SYSUser SYSUser { get; set; }
    }
}
