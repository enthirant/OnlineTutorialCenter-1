using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineTutorial.Model;

namespace OnlineTutorial.Data
{
    public class OnlineTutorialRepository
    {
        OnlineTutorialContext db = new OnlineTutorialContext();

        public IEnumerable<Student> GetAllStudents()
        {
            return db.Students;
        }
        public IEnumerable<Student> FindMoviesByTitle(string name)
        {
            return db.Students.Where(m => m.StudentName.ToLower().Contains(name));
        }
    }
}
