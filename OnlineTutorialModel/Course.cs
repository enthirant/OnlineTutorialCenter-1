using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTutorial.Model
{
   public class Course
    { 
        public int CourseID { get; set; } 
        public string CourseName { get; set; }

        public string CourseDuration { get; set; }
        public decimal CourseFee { get; set; }
        public int InstructorID { get; set; }
        [ForeignKey("InstructorID")]
        public Instructor Instructor { get; set; }
        public int ScheduleID { get; set; }
        [ForeignKey("ScheduleID")]
        public Schedule Schedule { get; set; }

        public int MaterialID { get; set; }
        [ForeignKey("MaterialID")]
        public Material Material { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }

        public virtual ICollection<Quiz> Quizs { get; set; }

        public virtual ICollection<Material> Materials { get; set; }

    }
}
