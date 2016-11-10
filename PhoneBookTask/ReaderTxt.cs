using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PhoneBookTask
{
    public class ReaderTxt : IReader
    {
        public string ReadFrom(string source)
        {
            string outputString = "";
            using (StreamReader streamRead = new StreamReader(source))
            {
                outputString = streamRead.ReadToEnd();
            }
            return outputString;
        }
    }
}
