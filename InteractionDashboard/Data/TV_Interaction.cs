using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TVInteractionDashboard.Data
{
    [Keyless]
    [Table("TV_Interaction")]
    public class TV_Interaction
    {
        public int UnitID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Duration { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDT { get; set; }
    }
}
