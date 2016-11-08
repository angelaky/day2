using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> genericClass = new GenericClass<int>(5);
            Console.WriteLine(genericClass.ToString());
            //PrintObject("Stamat");
        }

        //private static void PrintObject(string name)
        //{
        //    Console.WriteLine("Printed object to Sting "+ name.ToString());
        //}
        private static void PrintObject<T>(T name)
        {
            Console.WriteLine("Printed object to Sting " + name.ToString());
        }
    }
}
