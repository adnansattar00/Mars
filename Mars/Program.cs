﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var math = new Math();
            var result = math.Sum(10 , 10);
            Console.WriteLine("Sum is: " + result);
            var resultSubtract = math.Subtract(10 , 5);
            Console.WriteLine("Subtract is: " + resultSubtract);
            Console.ReadLine();
        }
    }
}
