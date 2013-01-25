using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tiers.Enums;

namespace Tiers.Entities
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleType Role { get; set; }
    }
}
