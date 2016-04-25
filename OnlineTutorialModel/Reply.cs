using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutorial.Model
{
    public class Reply
    {
        public int ReplyID { get; set; }
        public DateTime ReplyDate { get; set; }
        public string ReplyOption { get; set; }
        public int TopicID { get; set; }
        [ForeignKey("TopicID")]
        public Topic Topic { get; set; }
        public int StudentID { get; set; }
        [ForeignKey("StudentID")]
        public Student Student { get; set; }
        
    }
}
