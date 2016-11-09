using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyValuePair<int, int> ids = new KeyValuePair<int, int>(5,6);
            Console.WriteLine(ids.Key);

            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(5, "Eli");
            students.Add(6, "Gosho");
            students.Add(7, "Stamat");

            Console.WriteLine(students[5]);

            foreach (var item in students)
            {
                Console.WriteLine(item);
                Console.WriteLine("Key : {0} ---, Value : {1} ----",item.Key,item.Value);
            }

            if (students.ContainsKey(27))
            {
                Console.WriteLine(students[27]);
            }

            

        }
    }
}
