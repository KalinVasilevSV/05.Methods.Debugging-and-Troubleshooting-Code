using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            List<int> primes = FindPrimesInRange(startNum, endNum);

            for (int i = 0; i < primes.Count; i++)
            {
                if (i == primes.Count - 1)
                {
                    Console.Write(primes[i]);
                }
                else
                {
                    Console.Write(primes[i] + ", ");
                }
            }

            //foreach(int prime in primes)
            //{
            //    Console.Write(prime+", ");
            //}
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();

            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                bool isPrime = true;
                if (currentNum == 0 || currentNum == 1)
                {
                    isPrime = false;
                }

                for (int divider = 2; divider <= Math.Sqrt(currentNum); divider++)
                {
                    if (currentNum % divider == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    primes.Add(currentNum);
                }
            }

            return primes;
        }
    }
}
