﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionInvestigation
{
    internal class MyCustomException : Exception
    {
        public MyCustomException(string message) 
            : base(message)
        { 
        }
    }
}
