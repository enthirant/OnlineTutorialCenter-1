using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTutorial.Model
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string InstructorName { get; set; }
        public string InstructorPassword { get; set; }
        public string InstructorPhone { get; set; }
        public string InstructorEmail { get; set; }
        public string InstructorGender { get; set; }
        public int CourseID { get; set; }
        [ForeignKey("CourseID")]
        public Course Course { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
 