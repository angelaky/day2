using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookTask
{
    public interface IWriter
    {
        void WriteTo(PhoneBooks phoneBook, String serializationType);
    }
}
