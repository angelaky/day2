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
            
            ListGeneric<int> genericList = new ListGeneric<int>();

            genericList.Add(4);
            genericList.Add(7);
            genericList.Add(8);

            genericList.Remove(7);

            Console.WriteLine(genericList.GetElement(1));
            Console.WriteLine(genericList[1]);

            foreach (int value in genericList)
            {
                Console.WriteLine(value);
            }

        }
    }
}
