using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tiers.Entities
{
    public class Sprint
    {
        public string Name { get; set; }
        public Team Team { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
