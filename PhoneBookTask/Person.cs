using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookTask
{
    public class Person
    {
        public string Name { get; set; }
        public string Town { get; set; }
        public string Phone { get; set; }

        public Person(string name, string town, string phone)
        {
            this.Name = name;
            this.Town = town;
            this.Phone = phone;
        }

    }
}
