using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineTutorial.Model;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace OnlineTutorial.Data
{
   public class OnlineTutorialContext :DbContext 
    {
        public OnlineTutorialContext() : base()
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<Material> Materials { get; set; }
        public DbSet<Quiz> Quizs { get; set; } 
        public DbSet<QuizContent> QuizContents { get; set; }
        public DbSet<Reply> Reply { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Response> Responses { get; set; }  
        public DbSet<Topic> Topics { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
