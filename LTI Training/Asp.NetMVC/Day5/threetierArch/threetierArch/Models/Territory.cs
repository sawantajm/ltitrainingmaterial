using System;
using System.Collections.Generic;

namespace threetierArch.Models
{
    public partial class Territory
    {
        public Territory()
        {
            Employees = new HashSet<Employees>();
        }

        public string TerritoryId { get; set; } = null!;
        public string TerritoryDescription { get; set; } = null!;
        public int RegionId { get; set; }

        public virtual Region Region { get; set; } = null!;

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
