using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TVInteractionDashboard.Data
{
    [Table("TV_Unit")]
    public class TV_Unit
    {
        public int UnitID { get; set; }
        public int LocationID { get; set; }
        public string TvPosition { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDT { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDT { get; set; }

        public TV_Location Location { get; set; }
        // public ICollection<TV_Interaction> Interactions { get; set; }
    }
}
