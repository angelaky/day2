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
        public static List<Course> cources { get; private set; } = new List<Course>();

        public static void signedStudentForCourse(int studentID, int courseID)
        {
            var resultcourse = cources.Find(x => x.ID == courseID);
            var resultstudent = students.Find(x => x.ID == studentID);
            resultcourse.AddStudent(resultstudent);
        }


    }
}
