﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            Console.WriteLine(Reverse(num));
        }

        static string Reverse(string toReverse)
        {
            string reversed = string.Empty;

            for (int i = toReverse.Length-1; i >=0; i--)
            {
                reversed += toReverse[i];
            }

            return reversed;
        }
    }
}
