using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MilkShale.Data.Models
{
    public partial class User
    {
        public User()
        {
            LoginUser = new HashSet<LoginUser>();
            PasswordResetLinkForUser = new HashSet<PasswordResetLinkForUser>();
            UserModulePermission = new HashSet<UserModulePermission>();
            UserSubscription = new HashSet<UserSubscription>();
        }

        public Guid UserId { get; set; }
        public string SaltKey { get; set; }
        public int? UserRoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public string ProfileImage { get; set; }
        public string IpAddress { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsVerified { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int UserType { get; set; }
        public string CountryCode { get; set; }
        public int? ContinueFailedLogin { get; set; }
        public DateTime LastPasswordChangedOn { get; set; }

        public virtual UserRole UserRole { get; set; }
        public virtual ICollection<LoginUser> LoginUser { get; set; }
        public virtual ICollection<PasswordResetLinkForUser> PasswordResetLinkForUser { get; set; }
        public virtual ICollection<UserModulePermission> UserModulePermission { get; set; }
        public virtual ICollection<UserSubscription> UserSubscription { get; set; }
    }
}
