using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> masterNumbers = GetMasterNumbers(n);

            for (int i = 0; i < masterNumbers.Count; i++)
            {
                Console.WriteLine(masterNumbers[i]);
            }

        }

        static List<int> GetMasterNumbers(int n)
        {
            List<int> masters = new List<int>();

            for (int i = 1; i < n; i++)
            {
                bool isMaster = true;

                int digitsSum = GetDigitsSum(i);
                if (digitsSum % 7 != 0)
                {
                    isMaster = false;
                }

                bool hasEvenDigit = CheckEvenDigit(i);
                if (!hasEvenDigit)
                {
                    isMaster = false;
                }

                bool isPalindrome = IsPalindrome(i);
                if (!isPalindrome)
                {
                    isMaster = false;
                }

                if(isMaster)
                {
                    masters.Add(i);
                }
            }

            return masters;
        }

        static int GetDigitsSum(int n)
        {
            int digitsSum = 0;

            while (n != 0)
            {
                digitsSum += n % 10;
                n = n / 10;
            }

            return digitsSum;
        }

        static bool CheckEvenDigit(int n)
        {
            bool hasEvenDigit = false;

            while (n != 0)
            {
                int digit = n % 10;
                if (digit % 2 == 0)
                {
                    hasEvenDigit = true;
                    break;
                }
                else
                {
                    n = n / 10;
                }
            }

            return hasEvenDigit;
        }

        static bool IsPalindrome(int n)
        {
            string nString = string.Empty;
            bool isPalindrome = false;
            int initialValueN = n;

            while(n!=0)
            {
                nString += n % 10;
                n = n / 10;
            }

            if(initialValueN==int.Parse(nString))
            {
                isPalindrome = true; 
            }

            return isPalindrome;
        }
    }
}
