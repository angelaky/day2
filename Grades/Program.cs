using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Grades.Education;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of courses: ");
            int coursesNumber = int.Parse(Console.ReadLine());
            CoursesList(coursesNumber);

            Console.WriteLine("Enter number of students: ");
            int studentsNumber = int.Parse(Console.ReadLine());
            StudentsList(studentsNumber);

            Console.WriteLine("\nEnter students to courses task score. Format: <studentId courseId taskName//score> \nTo finish enter  \"quit\"");

            TasksList();

            printAcademy();



        }

        public static void CoursesList(int count)
        {
            Console.WriteLine("Enter courses in format <name>//<capacity>");
            for (int i = 0; i < count; i++)
            {
                Console.Write("\nCourse " + (i + 1) + "\n");
                string[] courseDetails = Console.ReadLine().Split(new string[] { "//" }, StringSplitOptions.None);
                string cName = courseDetails[0];
                int cCapacity = int.Parse(courseDetails[1]);

                Academy.AddCourseWithoutDuration(cName, cCapacity);
            }
        }

        public static void StudentsList(int count)
        {
            Console.WriteLine("Enter students in format <name>//<course ID>");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Student " + (i + 1));
                string[] studentsDetails = Console.ReadLine().Split(new string[] { "//" }, StringSplitOptions.None);
                string sName = studentsDetails[0];
                Academy.AddStudentOnlyName(sName, int.Parse(studentsDetails[1]));

            }
        }

        public static void TasksList()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("quit")) break;

                string[] line = input.Split(new char[0]);
                int studentId = int.Parse(line[0]);
                int courseId = int.Parse(line[1]);
                string[] taskscore = line[2].Split(new string[] { "//" }, StringSplitOptions.None);
                string name = taskscore[0];
                float score = float.Parse(taskscore[1]);
                try
                {
                    Education.Academy.AddTask(name, score, studentId, courseId);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void printAcademy()
        {
            
            var groupTasks = Academy.tasks.GroupBy(s => s.StudentID).ToList();
    //        List<Task> result = Academy.tasks.GroupBy(l => l.StudentID).Select(cl => new 
    //{
    //    ,
    //    Quantity = cl.Count().ToString(),
    //    Price = cl.Sum(c => c.Price).ToString(),
    //}).ToList();

            foreach (var c in groupTasks)
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
