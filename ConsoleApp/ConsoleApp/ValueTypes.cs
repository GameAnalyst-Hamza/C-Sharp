﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            int result = a + b;

            Console.WriteLine("Sum is: " + result);

            Console.ReadLine();
        }
    }
}