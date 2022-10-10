using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MilkShale.Data.Models
{
    public partial class LoginUser
    {
        public long Id { get; set; }
        public Guid UserId { get; set; }
        public string SessionId { get; set; }
        public bool IsLogin { get; set; }
        public string PageName { get; set; }
        public DateTime? LastActivityOn { get; set; }

        public virtual User User { get; set; }
    }
}
