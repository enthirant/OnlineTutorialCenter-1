using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutorial.Model
{
    public class Material
    {
        public int MaterialID { get; set; }

        public string MaterialName { get; set; }
        public string MaterialFormat { get; set; }
        public DateTime MaterialUploadDate { get; set; }
        public int CourseID { get; set; }
        [ForeignKey("CourseID")]

        public Course Course { get; set; }
    }
}
