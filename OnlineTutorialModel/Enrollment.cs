using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTutorial.Model
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int StudentID { get; set; }
        [ForeignKey("StudentID")]
        public Student Student { get; set; }
        public int CourseID { get; set; }
        [ForeignKey("CourseID")]
        public Course Course { get; set; }
        
    }
}
