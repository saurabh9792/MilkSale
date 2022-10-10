using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MilkShale.Data.Models
{
    public partial class TimeZoneList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CurrentUtcOffset { get; set; }
        public bool IsCurrentlyDst { get; set; }
        public string ZoneId { get; set; }
    }
}
