using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            // GenericClass<int> genericClass = new GenericClass<int>(5);
            ListGeneric<int> genericList = new ListGeneric<int>();

            genericList.Add(4);
            genericList.Add(7);
            genericList.Add(8);

            genericList.Remove(7);

            Console.WriteLine(genericList.GetElement(1));

        }
    }
}
