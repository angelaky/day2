using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLStudents
{
    public class Students
    {

        private static int currentID = 0;
        public string Name { get; set; }
        public int ID { get; private set; }

        public Students(string name)
        {
            ID = currentID++ ;
            Name = name;
        }


    }
}
