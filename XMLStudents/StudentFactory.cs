using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLStudents
{
    public class StudentFactory
    {
        public Students Create(string name)
        {
            return new Students(name);
        }
    }
}