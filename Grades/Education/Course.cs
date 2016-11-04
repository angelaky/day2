using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Education
{
    class Course
    {
        public string Name { get; private set; }
        public int Duration { get; private set; }
        public int Capacity { get; private set; }
        private static int currentID = 0;
        public List<Student> students;
        //public List<Task> tasks;
        public int IDCourse { get; private set; }

        public Course(string name, int duration)
        {
            Name = name;
            Duration = duration;
            this.IDCourse = GetNextID();
            students = new List<Student>();
            //tasks = new List<Task>();
        }

        public Course(string name, int duration, int capacity):this(name, duration)
        {
            Capacity = capacity;
        }

        protected int GetNextID()
        {
            return currentID++;
        }

        public void AddStudent(Student student)
        {    
            if (student.signed)
            {
                throw new StudentIsBusy("Student is already signed up");
            }

            if (students.Count == Capacity)
            {
                throw new InvalidOperationException($"Course {Name} is already full!");
            }
            students.Add(student);
            student.signed = true;
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        //public void AddTask(Task task)
        //{
            
        //    if (tasks.Any(x => x.Name == task.Name))
        //    {
        //        throw new StudentIsBusy("Task with this name already exists");
        //    }
        //    tasks.Add(task);           
        //}

        public override string ToString()
        {
            return Name;
        }
    }
}
