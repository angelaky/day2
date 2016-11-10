using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookTask
{
    public class Splitter : ISplitter
    {
        public string[] DoSplit(string input, string[] delimiter)
        {
            return input.Split(delimiter, StringSplitOptions.None);
        }
    }
}
