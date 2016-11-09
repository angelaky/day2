using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            Console.WriteLine("Enter text: ");
            //string line = Console.ReadLine();
            //string[] inputText = line.Split(new Char[] { ",", "\n", " ", ";", ":" , "?", "!","."}, StringSplitOptions.RemoveEmptyEntries);

            string line = System.IO.File.ReadAllText(@"C:\AA\test.txt");
            Console.WriteLine(line);
            string[] text = line.Split(new string[] { "," ,"\n", " ", ";", ":", "?", "!", "." ,"\r", "\t"}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in text)
            {
                if (!words.ContainsKey(item))
                {
                    words.Add(item, 1);
                }
                else
                {
                    words[item]++;
                } 
            }

            foreach (var item in words)
            {
                //Console.WriteLine(item);
                Console.WriteLine("Key : {0} Value : {1}", item.Key, item.Value);
            }

        }
    }
}
