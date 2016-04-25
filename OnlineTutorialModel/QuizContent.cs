using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutorial.Model
{
    public class QuizContent
    {
        public int QuizContentID { get; set; }
        public string QuizQuestion { get; set; }
        public string QuizAnswer { get; set; }
        public string QuizOption { get; set; }
        public int QuizID { get; set; }
        [ForeignKey("QuizID")]
        public Quiz Quiz { get; set; }

    }
}
