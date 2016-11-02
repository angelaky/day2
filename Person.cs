using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationSecond
{
 class Person
        {
            public string _name;
            public int _age;

           
            public string Name { get; set; }
            public int Age { get; set; }

        public Person()
        {
            _name = "No name";
            _age = 1;
        }

        public Person(string name):this()
        {
            _name = name;
        }

        public Person(string name, int age):this(name)
        {
            _age = age;
            if (_age < 0)
            {
                throw new FormatException("Wrong Age");
            } 
        }

        public void PrintNameAge()
        {
            Console.WriteLine("Name {0} age {1}", _name, _age);
        }

    }
    }

