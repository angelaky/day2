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

        HashSet<Person> personPhone = new HashSet<Person>(comparer);

        public PhoneBooks()
        {
            PersonsList = new List<Person>();            
        }

        public void Add(Person person)
        {
            if (personPhone.Contains(person))
            {
                Console.WriteLine("Try again! Person is already added");
            }
            else
            {
                PersonsList.Add(person);
            }
        }
    }
}
