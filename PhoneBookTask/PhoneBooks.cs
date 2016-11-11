using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookTask
{
    public class PhoneBooks
    {
        public List<Person> PersonsList { get; set; }

        static IEqualityComparer<Person> comparer = new PhonesComparer();

        //public HashSet<Person> personPhone { get; set; }

        public HashSet<Person> personPhone = new HashSet<Person>(comparer);

        public PhoneBooks()
        {
            PersonsList = new List<Person>();
            HashSet<Person> personPhone = new HashSet<Person>(comparer);
        }

        public void Add(Person person)
        {
            if (personPhone.Contains(person))
            {
                Console.WriteLine("Try again! Person is already added");
                throw new ArgumentException("Invalid argument");
            }
            else
            {
                PersonsList.Add(person);
            }
        }
    }
}
