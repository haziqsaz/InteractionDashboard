using System;
using System.Collections.Generic;
using TVInteractionDashboard.Data;

namespace TVInteractionDashboard.Data
{
    public class TV_Plant
    {
        public int PlantID { get; set; }
        public string Plant { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<TV_Location> Locations { get; set; }
    }
}
