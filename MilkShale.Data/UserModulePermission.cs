//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MilkShale.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserModulePermission
    {
        public int UserModulePermissionId { get; set; }
        public System.Guid UserId { get; set; }
        public int RoleId { get; set; }
        public int UserModuleId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
    
        public virtual User User { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
