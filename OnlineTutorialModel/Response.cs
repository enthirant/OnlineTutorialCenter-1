using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutorial.Model
{
    public class Response
    {
        public int ResponseID { get; set; }
        public int QuizContentID { get; set; }
        public string ResponseChosen { get; set; }

        public virtual ICollection<QuizContent> QuizContents { get; set; }
    }
}
