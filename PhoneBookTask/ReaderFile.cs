using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookTask
{
    class ReaderFile : IReader
    {
        public string ReadFrom(string source)
        {
            string line;
            using (StreamReader reader = new StreamReader(source))
            {
                line = reader.ReadToEnd();
            }

            return line;
        }
    }
}
