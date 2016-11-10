using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookTask
{
    public interface IReader
    {
        string ReadFrom(string source);
    }
}
