﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class StudentNotFound:Exception
    {

        public StudentNotFound(string message):base(message)
        {
        }
    }
}
