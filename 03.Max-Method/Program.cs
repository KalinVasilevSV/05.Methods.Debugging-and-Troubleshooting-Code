using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            int numHighest = GetMax(numOne, GetMax(numTwo,numThree));

            Console.WriteLine(numHighest);
        }

        static int GetMax(int first, int second)
        {
            if(first>second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
