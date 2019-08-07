using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class vehicle
    {
        abstract public object licensenumber { get; }
        abstract public object make { get; }
        abstract public object model { get;  }
        abstract public object price { get; }

    }
}
