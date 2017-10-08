using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            Console.WriteLine(LastDigitName(num));
        }

        static string LastDigitName(long num)
        {
            long lastDigit = Math.Abs(num % 10);

            switch(lastDigit)
            {
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                case 0: return "zero";
                default: return "none"; // needs default to return a value
            }
        }
    }
}
