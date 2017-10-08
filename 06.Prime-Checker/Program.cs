using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(long n)
        {
            bool isPrime = true;

            if(n<=1)
            {
                isPrime = false;
                return isPrime;
            }

            for (int i = 2; i <= Math.Sqrt(Math.Abs(n)); i++)
            {
                if(n%i==0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
