using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2.Education;

namespace App2
{
    class ProgramBigTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of courses: ");
            int coursesNumber = int.Parse(Console.ReadLine());
            CoursesList(coursesNumber);

            Console.WriteLine("Enter number of students: ");
            int studentsNumber = int.Parse(Console.ReadLine());
            StudentsList(studentsNumber);

            Console.WriteLine("\nEnter students to courses. Format: <studentID courseId> \n To finish enter  \"quit\"");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("quit")) break;

                string[] line = input.Split(new char[0]);
                int studentId = int.Parse(line[0]);
                int courseId = int.Parse(line[1]);
                try
                {
                    Education.Academy.signedStudentForCourse(studentId, courseId);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            printAcademy();

        }

        
            public static void CoursesList(int count)
        {
            Console.WriteLine("Enter courses in format <name>//<duration>//<capacity>");
            for (int i = 0; i < count; i++)
            {
                Console.Write("\nCourse " + (i + 1) + "\n");
                string[] courseDetails = Console.ReadLine().Split(new string[] { "//" }, StringSplitOptions.None);
                string cName = courseDetails[0];
                int cDuration = int.Parse(courseDetails[1]);
                int cCapacity = int.Parse(courseDetails[2]);

                Academy.AddCourse(cName, cDuration, cCapacity);
            }
        }

        public static void StudentsList(int count)
        {
            Console.WriteLine("Enter students in format <name>//<age>");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Student " + (i + 1));
                string[] studentsDetails = Console.ReadLine().Split(new string[] { "//" }, StringSplitOptions.None);
                string sName = studentsDetails[0];
                int sAge = int.Parse(studentsDetails[1]);

                Academy.AddStudent(sName, sAge);
            }
        }

        public static void printAcademy()
        {
            List<Course> orderedCourses = Academy.courses.OrderBy(c => c._name).ToList();

            foreach (var c in orderedCourses)
            {
                Console.WriteLine($"{c._name} - {c._duration} hours");
                List<Student> orderedStudents = c.students.OrderBy(s => s._age).ToList();

                foreach (var s in orderedStudents)
                {
                    s.PrintNameAge();
                }
            }
        }

    }
}

    
