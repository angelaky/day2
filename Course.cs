using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationSecond
{
    class Course
    {
        private string _name;
        private int _duration;
        private int _capacity;
        private static int currentID = 0;
        private List<Student> students;
        public int ID { get; private set; }

        public Course(string name, int duration, int capacity)
        {
            _name = name;
            _duration = duration;
            _capacity = capacity;
            this.ID = GetNextID();
        }

        protected int GetNextID()
        {
            return ++currentID;
        }

        public void AddStudent(Student student)
        {
            if (students.Contains(student))
            {
                throw new FormatException("Student is already signed up");
            }
            students.Add(student);
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
