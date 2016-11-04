using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Education
{
    class Academy
    {
        public static List<Student> students { get; private set; } = new List<Student>();
        public static List<Course> courses { get; private set; } = new List<Course>();
        public static List<Task> tasks { get; private set; } = new List<Task>();

        public static void signedStudentForCourse(int studentID, int courseID)
        {
            bool checkCourceExists = courses.Any(x => x.IDCourse == courseID);
            bool checkStudentExists = students.Any(x => x.ID == studentID);

            if (!checkCourceExists)
            {
                throw new CourseNotFound("Course does not exist");                
            }
            else if (!checkStudentExists)
            {
                throw new StudentNotFound("Student does not exist");
            }
            else
            {
                var resultcourse = courses.Find(x => x.IDCourse == courseID);
                var resultstudent = students.Find(x => x.ID == studentID);
                resultcourse.AddStudent(resultstudent);

            }
            
        }

        public static void AddCourse(string name, int duration, int capacity)
        {
            Course course = new Course(name, duration, capacity);
            courses.Add(course);
        }

        public static void AddCourseWithoutDuration(string name, int capacity)
        {
            Course course = new Course(name, capacity);
            courses.Add(course);
        }

        public static void AddStudent(string name, int age)
        {
            Student student = new Student(name, age);
            students.Add(student);
        }

        public static void AddStudentOnlyName(string name, int courseID)
        {
            Student student = new Student(name);
            students.Add(student);
            var resultcourse = courses.Find(x => x.IDCourse == courseID);
            resultcourse.AddStudent(student);
        }

        public static void AddTask(string name, float score, int courseID, int studentID)
        {
            if (tasks.Any(x => x.Name == name && x.StudentID == studentID && x.CourseID == courseID))
                {
                throw new StudentIsBusy("Task with this name already exists");
            }               
                //    tasks.Add(task);           
                Task task = new Task(name, score, courseID, studentID);
            tasks.Add(task);
            //var resultstudent = students.Find(x => x.ID == studentID);
            //resultstudent.AddTask(task);
        }

    }
}
