﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookTask
{
    public interface ISplitter
    {
        string[] DoSplit(string input, string[] delimiter);
    }
}
