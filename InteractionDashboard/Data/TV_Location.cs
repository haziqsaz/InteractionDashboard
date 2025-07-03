using System;
using System.Collections.Generic;
using TVInteractionDashboard.Data;

namespace TVInteractionDashboard.Data
{
    public class TV_Location
    {
        public int LocationID { get; set; }
        public int PlantID { get; set; }
        public string Location { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public TV_Plant Plant { get; set; }
        public ICollection<TV_Unit> Units { get; set; }
    }
}
