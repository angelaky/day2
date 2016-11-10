using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            //Console.WriteLine("Enter text: ");
            //string line = Console.ReadLine();
            //string[] inputText = line.Split(new Char[] { ",", "\n", " ", ";", ":" , "?", "!","."}, StringSplitOptions.RemoveEmptyEntries);

            string line = File.ReadAllText(@"C:\AA\test.txt");
            //Console.WriteLine(line);
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

            //var sortedDict = from entry in words orderby words.Values ascending select entry;
            var sortedDict = words.OrderByDescending(x => x.Value);

            string outputTxt = "";

            foreach (var item in sortedDict)
            {
                //Console.WriteLine(item);
                //Console.WriteLine("Key : {0} Value : {1}", item.Key, item.Value);
                outputTxt = outputTxt+ item.Key + "-->"+ item.Value + Environment.NewLine;
            }

            File.WriteAllText(@"C:\AA\output.txt", outputTxt) ;



        }
    }
}
