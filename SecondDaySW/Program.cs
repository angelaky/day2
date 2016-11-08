using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDaySW
{
    class Program
    {
        public delegate void HelloDelegate(string name);
        static void Main(string[] args)
        {
            //Action<string> helloDelegate = Hello;
            Func<string, int> helloDelegate = Hello;
            //HelloDelegate helloDelegate = new HelloDelegate(Hello);
            helloDelegate("Viktor");
        }

        private static void MethodExecutor(Action<string> action)
        {
            action("pesho");
        }

        private static int Hello(string name)
        {
            Console.WriteLine(name);
            return 0;
        }
    }
}
