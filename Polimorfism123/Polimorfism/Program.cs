﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation mo = new MathOperation();
            Console.WriteLine(mo.Add(2,3));
            Console.WriteLine(mo.Add(2.2, 3.3,5.5));
            Console.WriteLine(mo.Add(2.2m, 3.3m,5.5m));
        }
    }
}
