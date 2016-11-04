using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class ProgramComplex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers and action");
            string line1 = Console.ReadLine();
            string[] number1 = line1.Split(' ');
            Complex complex1 = new Complex(int.Parse(number1[0]), int.Parse(number1[1]));

            string line2 = Console.ReadLine();
            string[] number2 = line2.Split(' ');
            Complex complex2 = new Complex(int.Parse(number2[0]), int.Parse(number2[1]));

            string action = Console.ReadLine();
            if (action == "add")
            {
                Complex sum = complex1 + complex2;
                Console.WriteLine(sum.ToString());
            }
            else if (action == "sub")
            {
                Complex sub = complex1 - complex2;
                Console.WriteLine(sub.ToString());
            }
            else
            {
                Console.WriteLine("I can not understand you :-)");
            }


        }
    }
}
