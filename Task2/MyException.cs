using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MyException : ArgumentException
{
    public int Value { get; set; }


    public MyException(string message, int value) : base(message)
    {
        Value = value;
        HelpLink = "www.support.com";
    }


}
