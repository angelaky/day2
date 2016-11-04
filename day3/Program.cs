using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName;
            string inputAge;
            int inAge;
            Console.WriteLine("Enter your name: ");
            inputName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            inputAge = Console.ReadLine();
            inAge = Int16.Parse(inputAge);

            Person fPerson = new Person();
            Person sPerson = new Person(inputName);
            Person tPerson;

            try
            {
                tPerson = new Person(inputName, inAge);
                Person[] persons = new Person[] { fPerson, sPerson, tPerson };
                foreach (Person person in persons)
                {
                    person.PrintNameAge();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("BAD: " + e.Message );
            }
            

            

        }
    }
}
