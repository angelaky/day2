﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class StudentIsBusy:Exception
    {

        public StudentIsBusy(string message):base(message)
        {
        }
    }
}
