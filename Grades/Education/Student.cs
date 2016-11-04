using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Education
{
    class Student : Person
    {
        
        private static int currentID = 0;
        public bool signed { get; set; }
        public int ID { get; private set; }
        //public List<Task> tasks;

        public Student(string name) : base(name)
        {
            ID = GetNextID();
            signed = false;
            //tasks = new List<Task>();
        }

        public Student(string name, int age) : base(name, age)
        {
            ID = GetNextID();
            signed = false;
        }

        protected int GetNextID()
        {            
            return currentID++;
        }

        public override string ToString()
        {
            return _name;
        }

        //public void AddTask(Task task)
        //{
        //    tasks.Add(task);
        //}

    }
}
