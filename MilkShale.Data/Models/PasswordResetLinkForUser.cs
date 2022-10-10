using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MilkShale.Data.Models
{
    public partial class PasswordResetLinkForUser
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime LinkSentOn { get; set; }
        public bool IsPasswordReset { get; set; }

        public virtual User User { get; set; }
    }
}
