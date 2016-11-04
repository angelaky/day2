using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationSecond
{
    class Student : Person
    {
        
        private static int currentID = 0;
        public bool signed { get; set; }
        public int ID { get; private set; }

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
    

    }
}
