﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a num: ");
            //int num = Convert.ToInt16(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
                num += 100;
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Number is Odd");
                num += 50;
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}