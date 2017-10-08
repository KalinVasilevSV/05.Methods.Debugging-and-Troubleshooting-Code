using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(n));
        }

        static int Fib(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                int fibA = 1;
                int fibB = 1;
                int fibSwitch = 1;

                for (int i = 2; i <= n; i++)
                {
                    fibSwitch = fibA + fibB;
                    fibA = fibB;
                    fibB = fibSwitch;
                }
                return fibSwitch;
            }
        }
    }
}
