using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<char> alphabeta = new SortedSet<char>();
            alphabeta.Add('b');
            alphabeta.Add('c');
            alphabeta.Add('a');

            foreach (char val in alphabeta) 
            {
                Console.WriteLine(val);
            }
        }
    }
}
