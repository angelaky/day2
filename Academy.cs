using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationSecond
{
    class Academy
    {
        public static List<Student> students { get; private set; } = new List<Student>();
        public static List<Course> courses { get; private set; } = new List<Course>();

        public static void signedStudentForCourse(int studentID, int courseID)
        {
            bool checkCourceExists = courses.Any(x => x.IDCourse == courseID);
            bool checkStudentExists = students.Any(x => x.ID == studentID);

            if (!checkCourceExists)
            {
                
                Console.WriteLine("Course does not exist");
            }
            else if (!checkStudentExists)
            {
                Console.WriteLine("Student does not exist");
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

        public static void AddStudent(string name, int age)
        {
            Student student = new Student(name, age);
            students.Add(student);
        }


    }
}
