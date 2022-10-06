using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MilkShale.Core.Enum
{
    public enum UserRoles
    {
        [Description("Admin")]
        Admin = 1,

        [Description("User")]
        User = 2,

        [Description("Dairy Employee")]
        Employee = 3,

        [Description("Dairy member")]
        Member = 4,

        
    }
}
