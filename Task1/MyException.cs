﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MyException : ArgumentException
{
    public MyException()
    {

    }
    public MyException(string message)
        : base(message)
    { 
    }

}
