using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomList mylist = new CustomList();
            //mylist.OnChange += (input) => Console.WriteLine("Hi");

            mylist.Add(5);
            mylist.Add(6);
            mylist.Add(7);
            mylist.Add(8);
            mylist.Add(9);
            
            Console.WriteLine(mylist.GetElement(0));
            Console.WriteLine(mylist.GetElement(1));
            Console.WriteLine(mylist.GetElement(2));
            Console.WriteLine(mylist.GetElement(3));
            Console.WriteLine(mylist.GetElement(4));

            mylist.Remove(5);
            Console.WriteLine(mylist.GetElement(0));
            Console.WriteLine(mylist.GetElement(1));
            Console.WriteLine(mylist.GetElement(2));
            Console.WriteLine(mylist.GetElement(3));
            
        }
    }
}
