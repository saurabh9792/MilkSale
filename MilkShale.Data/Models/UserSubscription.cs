using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MilkShale.Data.Models
{
    public partial class UserSubscription
    {
        public Guid UserSubscriptionId { get; set; }
        public Guid? OrderId { get; set; }
        public bool? IsCurrent { get; set; }
        public Guid UserId { get; set; }
        public DateTime PlanStartDate { get; set; }
        public DateTime? PlanEndDate { get; set; }
        public int? PlanDurationType { get; set; }
        public string PlanTypeName { get; set; }
        public Guid PlanReferenceId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreateadOn { get; set; }
        public int? PlanDuration { get; set; }
        public string PlanName { get; set; }

        public virtual User User { get; set; }
    }
}
