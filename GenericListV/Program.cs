using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListV
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            PrintCollection(list);
        }

        //private static void PrintCollection(List<int> list)
        //private static void PrintCollection(IEnumerable<int> list)
        private static void PrintCollection(IList<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
