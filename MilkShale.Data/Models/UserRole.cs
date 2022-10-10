using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MilkShale.Data.Models
{
    public partial class UserRole
    {
        public UserRole()
        {
            User = new HashSet<User>();
            UserModulePermission = new HashSet<UserModulePermission>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<UserModulePermission> UserModulePermission { get; set; }
    }
}
