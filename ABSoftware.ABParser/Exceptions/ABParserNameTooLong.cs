﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSoftware.ABParser.Exceptions
{
    public class ABParserNameTooLong : Exception
    {
        public ABParserNameTooLong() : base("The names on ABParser tokens/limits can only be 255 characters long at a maximum.") { }
    }
}
