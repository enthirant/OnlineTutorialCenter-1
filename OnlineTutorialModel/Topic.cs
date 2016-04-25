using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutorial.Model
{
    public class Topic
    {
        public int TopicID { get; set; }
        public DateTime TopicDate { get; set; }
        public string TopicContent { get; set; } 
        public int ForumID { get; set; }
        [ForeignKey("ForumID")]
        public Forum Forum { get; set; }
        
    } 

}
