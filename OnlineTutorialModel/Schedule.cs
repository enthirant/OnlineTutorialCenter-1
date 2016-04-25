using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutorial.Model
{
    public class Schedule
    {
        public int ScheduleID { get; set; }
        public DateTime ScheduleDate { get; set; }
        public DateTime ScheduleStart { get; set; }
        public DateTime ScheduleEnd { get; set; }
    }
}
