using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutorial.Model
{
    public class Quiz
    {
        public int QuizID { get; set; }
        public string QuizTitle { get; set; }
        public String QuizDescription { get; set; }
        public int CourseID { get; set; }
        [ForeignKey("CourseID")]

        public Course Course { get; set; }


    }
}
