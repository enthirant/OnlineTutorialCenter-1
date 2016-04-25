using OnlineTutorial.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutorailCenter.DAL
{
    public class DbInitailizer : DropCreateDatabaseIfModelChanges<OnlineTutorialContext>
    {
        protected override void Seed(OnlineTutorialContext context)
        {
            var students = new List<Student>
            {
                new Student {StudentName="Surenthiran",StudentPassword="Thiran",StudentEmail="enthirant@gmail.com",StudentGender="Male",StudentPhone="12345" },
                new Student {StudentName="Deepak",StudentPassword="Deepak",StudentEmail="Deepak@gmail.com",StudentGender="Male",StudentPhone="6789" },
                new Student {StudentName="Bavithra",StudentPassword="Bavithra",StudentEmail="Bavithra@gmail.com",StudentGender="Female",StudentPhone="6789" }
            };
            foreach (var temp in students)
            {
                context.Students.Add(temp);
            }
            context.SaveChanges();

            var instructor = new List<Instructor>
            {
                new Instructor {InstructorName="Mohan",InstructorPassword="Mohan",InstructorPhone="1234",InstructorEmail="Mohan@gmail.com",InstructorGender="Male" },
                new Instructor {InstructorName="Koushik",InstructorPassword="Koushik",InstructorPhone="1234",InstructorEmail="Koushik@gmail.com",InstructorGender="Male" },
                new Instructor {InstructorName="Sanskar",InstructorPassword="Sanskar",InstructorPhone="1234",InstructorEmail="Sanskar@gmail.com",InstructorGender="Male" },
                new Instructor {InstructorName="Bavi",InstructorPassword="Bavi",InstructorPhone="1234",InstructorEmail="Bavi@gmail.com",InstructorGender="Female" }

            };
            foreach(var temp in instructor)
            {
                context.Instructors.Add(temp);
            }
            context.SaveChanges();


            var courses = new List<Course>
            {
                new Course {CourseID=100,CourseName="C# Dot Net" ,CourseDuration="3 Months",CourseFee=5250.3512M,InstructorID = 1,ScheduleID=100},
                new Course {CourseID=101,CourseName="VB Dot Net" ,CourseDuration="3 Months",CourseFee=5250.3512M,InstructorID = 2,ScheduleID=200},
                new Course {CourseID=102,CourseName="Java" ,CourseDuration="3 Months",CourseFee=5250.3512M,InstructorID = 3,ScheduleID=300},
                new Course {CourseID=103,CourseName="Python" ,CourseDuration="3 Months",CourseFee=5250.3512M,InstructorID = 4,ScheduleID=400}
            };
            
            foreach(var temp in courses)
            {
                context.Courses.Add(temp);
            }
            context.SaveChanges();

            var enrollment = new List<Enrollment>
            {
                new Enrollment {EnrollmentID=10000,EnrollmentDate=DateTime.Parse("2016-04-29"),CourseID=100,StudentID=2 },
                new Enrollment {EnrollmentID=10001,EnrollmentDate=DateTime.Parse("2016-03-29"),CourseID=100,StudentID=1 },
                new Enrollment {EnrollmentID=10002,EnrollmentDate=DateTime.Parse("2016-03-21"),CourseID=100,StudentID=3 },
                new Enrollment {EnrollmentID=10003,EnrollmentDate=DateTime.Parse("2016-04-02"),CourseID=101,StudentID=2 },
                new Enrollment {EnrollmentID=10004,EnrollmentDate=DateTime.Parse("2016-02-19"),CourseID=102,StudentID=2 },
                new Enrollment {EnrollmentID=10005,EnrollmentDate=DateTime.Parse("2016-01-19"),CourseID=102,StudentID=4 },
                new Enrollment {EnrollmentID=10006,EnrollmentDate=DateTime.Parse("2016-02-24"),CourseID=103,StudentID=2 },
                new Enrollment {EnrollmentID=10007,EnrollmentDate=DateTime.Parse("2016-02-05"),CourseID=103,StudentID=1 },
                new Enrollment {EnrollmentID=10008,EnrollmentDate=DateTime.Parse("2016-03-16"),CourseID=102,StudentID=1 }
            };
            foreach(var item in enrollment)
            {
                context.Enrollments.Add(item);
            }
            context.SaveChanges();

            var schedule = new List<Schedule>
            {
                new Schedule {ScheduleID=101,ScheduleDate=DateTime.Parse("2016-03-01"),ScheduleStart=DateTime.Parse("2016-03-01"),ScheduleEnd=DateTime.Parse("2016-06-01") },
                new Schedule {ScheduleID=101,ScheduleDate=DateTime.Parse("2016-03-01"),ScheduleStart=DateTime.Parse("2016-03-01"),ScheduleEnd=DateTime.Parse("2016-06-01") },
                new Schedule {ScheduleID=101,ScheduleDate=DateTime.Parse("2016-04-01"),ScheduleStart=DateTime.Parse("2016-04-01"),ScheduleEnd=DateTime.Parse("2016-07-01") },
                new Schedule {ScheduleID=101,ScheduleDate=DateTime.Parse("2016-05-01"),ScheduleStart=DateTime.Parse("2016-05-01"),ScheduleEnd=DateTime.Parse("2016-08-01") },
                new Schedule {ScheduleID=101,ScheduleDate=DateTime.Parse("2016-06-01"),ScheduleStart=DateTime.Parse("2016-06-01"),ScheduleEnd=DateTime.Parse("2016-09-01") },
                new Schedule {ScheduleID=101,ScheduleDate=DateTime.Parse("2016-04-01"),ScheduleStart=DateTime.Parse("2016-04-21"),ScheduleEnd=DateTime.Parse("2016-07-01") },
                new Schedule {ScheduleID=101,ScheduleDate=DateTime.Parse("2016-04-01"),ScheduleStart=DateTime.Parse("2016-04-12"),ScheduleEnd=DateTime.Parse("2016-07-12") },
                new Schedule {ScheduleID=101,ScheduleDate=DateTime.Parse("2016-04-11"),ScheduleStart=DateTime.Parse("2016-04-21"),ScheduleEnd=DateTime.Parse("2016-07-28") },
                new Schedule {ScheduleID=101,ScheduleDate=DateTime.Parse("2016-03-21"),ScheduleStart=DateTime.Parse("2016-03-31"),ScheduleEnd=DateTime.Parse("2016-07-01") },
                new Schedule {ScheduleID=101,ScheduleDate=DateTime.Parse("2016-03-28"),ScheduleStart=DateTime.Parse("2016-04-01"),ScheduleEnd=DateTime.Parse("2016-07-01") },
                new Schedule {ScheduleID=101,ScheduleDate=DateTime.Parse("2016-03-12"),ScheduleStart=DateTime.Parse("2016-03-19"),ScheduleEnd=DateTime.Parse("2016-06-01") },
                new Schedule {ScheduleID=101,ScheduleDate=DateTime.Parse("2016-03-19"),ScheduleStart=DateTime.Parse("2016-03-27"),ScheduleEnd=DateTime.Parse("2016-05-01") },
                new Schedule {ScheduleID=101,ScheduleDate=DateTime.Parse("2016-04-03"),ScheduleStart=DateTime.Parse("2016-04-15"),ScheduleEnd=DateTime.Parse("2016-05-01") },
                new Schedule {ScheduleID=101,ScheduleDate=DateTime.Parse("2016-03-08"),ScheduleStart=DateTime.Parse("2016-03-16"),ScheduleEnd=DateTime.Parse("2016-05-01") }
             };
            foreach(var temp in schedule)
            {
                context.Schedules.Add(temp);
            }
            context.SaveChanges();

            var material = new List<Material>
            {
                new Material { MaterialFormat = "Word Document", MaterialName = "Lesson1", MaterialUploadDate = DateTime.Parse("2016-03-05"), CourseID = 101 },
                new Material { MaterialFormat = "Video Tutorial", MaterialName = "Lessons", MaterialUploadDate = DateTime.Parse("2016-03-05"), CourseID = 101 },
                new Material { MaterialFormat = "Word Document", MaterialName = "Lesson1", MaterialUploadDate = DateTime.Parse("2016-03-05"), CourseID = 102 },
                new Material { MaterialFormat = "Word Document", MaterialName = "Lesson1", MaterialUploadDate = DateTime.Parse("2016-03-05"), CourseID = 103 },
             };
            foreach(var temp in material)
            {
                context.Materials.Add(temp);
            }
            context.SaveChanges();

            var quiz = new List<Quiz>
            {
                new Quiz {QuizID=1,QuizDescription="C# Dot Net Lesson1 Quiz",QuizTitle="Dot Net",CourseID=100 },
                new Quiz {QuizID=2,QuizDescription="VB Dot Net Lesson1 Quiz",QuizTitle="Dot Net",CourseID=101 },
                new Quiz {QuizID=3,QuizDescription="Java Lesson1 Quiz",QuizTitle="Dot Net",CourseID=102 },
                new Quiz {QuizID=4,QuizDescription="Python Lesson1 Quiz",QuizTitle="Dot Net",CourseID=103 },
                new Quiz {QuizID=5,QuizDescription="Dot Net Lesson1 Quiz",QuizTitle="Dot Net",CourseID=101 },
                new Quiz {QuizID=6,QuizDescription="Java Quiz",QuizTitle="Java",CourseID=103 },
            };
            foreach(var temp in quiz)
            {
                context.Quizs.Add(temp);
            }context.SaveChanges();

            var quizcontent = new List<QuizContent>
            {
                new QuizContent {QuizID=1,QuizContentID=1,QuizQuestion="How many Types of Client validation Controls",QuizAnswer="C",QuizOption="A" },
                new QuizContent {QuizID=2,QuizContentID=2,QuizQuestion="How many Types of Client validation Controls",QuizAnswer="C",QuizOption="A" },
                new QuizContent {QuizID=3,QuizContentID=3,QuizQuestion="How many Types of Client validation Controls",QuizAnswer="C",QuizOption="A" },
                new QuizContent {QuizID=4,QuizContentID=4,QuizQuestion="How many Types of Client validation Controls",QuizAnswer="C",QuizOption="A" },
                new QuizContent {QuizID=5,QuizContentID=5,QuizQuestion="How many Types of Client validation Controls",QuizAnswer="C",QuizOption="A" },
                new QuizContent {QuizID=6,QuizContentID=6,QuizQuestion="How many Types of Client validation Controls",QuizAnswer="C",QuizOption="A" },

            };
            foreach(var s in quizcontent)
            {
                context.QuizContents.Add(s);
            }
            context.SaveChanges();
            var forum = new List<Forum> 
            {
                new Forum {ForumID=1,CourseID=1 },
                new Forum {ForumID=2,CourseID=2 },
                new Forum {ForumID=3,CourseID=3 }

            };

            foreach(var s in forum)
            {
               context.Forums.Add(s);

            } 
            context.SaveChanges();
            var topic = new List<Topic>
            {
                new Topic {TopicID=1,TopicContent="DotNet",TopicDate=DateTime.Parse("2016-04-14"),ForumID=1},
                new Topic {TopicID=2,TopicContent="DotNet",TopicDate=DateTime.Parse("2016-04-14"),ForumID=2},
                new Topic {TopicID=3,TopicContent="DotNet",TopicDate=DateTime.Parse("2016-04-14"),ForumID=3},
            };
            foreach(var s in topic)
            {
                context.Topics.Add(s);
            }context.SaveChanges();
            var reply = new List<Reply>
            {
                new Reply {ReplyDate=DateTime.Parse("2016-04-18"),TopicID=1,StudentID=1,ReplyOption="C"},
                new Reply {ReplyDate=DateTime.Parse("2016-04-18"),TopicID=2,StudentID=2,ReplyOption="A" },
                new Reply {ReplyDate=DateTime.Parse("2016-04-18"),TopicID=3,StudentID=3,ReplyOption="D" },
                new Reply {ReplyDate=DateTime.Parse("2016-04-18"),TopicID=1,StudentID=4,ReplyOption="B" },
                new Reply {ReplyDate=DateTime.Parse("2016-04-18"),TopicID=2,StudentID=5,ReplyOption="B" },
            };
            foreach (var s in reply)
            {
                context.Reply.Add(s);

            }context.SaveChanges();

            var response = new List<Response>
            {
                new Response {QuizContentID=1,ResponseChosen="C" },
                new Response {QuizContentID=1,ResponseChosen="C" },
                new Response {QuizContentID=1,ResponseChosen="C" },
                new Response {QuizContentID=1,ResponseChosen="C" },
            };
            foreach(var s in response)
            {
                context.Responses.Add(s);
            }context.SaveChanges();
        }

        
    }

}
