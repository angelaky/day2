using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program1
    {
        static void Main(string[] args)
        {
            string line;
            List<Person> personList = new List<Person>();
            while (true)
            {
                line = Console.ReadLine().ToLower();
                if (line == "quit")
                {
                    break;
                }
                
                string[] rowPerson = line.Split(new string[] { "//" }, StringSplitOptions.None);
               
                if (int.Parse(rowPerson[1]) > 18)
                {
                    Person nextPerson = new Person(rowPerson[0], int.Parse(rowPerson[1]));
                    personList.Add(nextPerson);
                }
            };

            List<Person> newList = personList.OrderBy(x => x._name.Length).ToList();
            newList.ForEach((item => Console.Write(item._name + " "+ item._age)));


        }
    }
}
