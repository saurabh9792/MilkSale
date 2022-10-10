using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MilkShale.Data.Models
{
    public partial class UserModulePermission
    {
        public int UserModulePermissionId { get; set; }
        public Guid UserId { get; set; }
        public int RoleId { get; set; }
        public int UserModuleId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual UserRole Role { get; set; }
        public virtual User User { get; set; }
    }
}
