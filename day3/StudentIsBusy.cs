using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class StudentIsBusy:Exception
    {

        public StudentIsBusy(string message):base(message)
        {
        }
    }
}
