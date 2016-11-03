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
        public int ID { get; private set; }
        public string course { get; set; }

        public Student(string name, int age) : base(name, age)
        {
            this.ID = GetNextID();
        }

        protected int GetNextID()
        {            
            return ++currentID;
        }

        public override string ToString()
        {
            return _name;
        }
    

    }
}
