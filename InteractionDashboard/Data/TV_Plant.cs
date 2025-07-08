using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TVInteractionDashboard.Data;

namespace TVInteractionDashboard.Data
{
    [Table("TV_Plant")]
    public class TV_Plant
    {
        public int PlantID { get; set; }
        public string Plant { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<TV_Location> Locations { get; set; }
    }
}
