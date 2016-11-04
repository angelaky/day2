using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationSecond
{
    class Course
    {
        public string _name;
        public int _duration;
        public int _capacity;
        private static int currentID = 0;
        public List<Student> students;
        public int IDCourse { get; private set; }

        public Course(string name, int duration, int capacity)
        {
            _name = name;
            _duration = duration;
            _capacity = capacity;
            this.IDCourse = GetNextID();
            students = new List<Student>();
        }

        protected int GetNextID()
        {
            return currentID++;
        }

        public void AddStudent(Student student)
        {    
            if (student.signed)
            {
                throw new InvalidOperationException("Student is already signed up");
            }

            if (students.Count == _capacity)
            {
                throw new InvalidOperationException($"Course {_name} is already full!");
            }
            students.Add(student);
            student.signed = true;
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
