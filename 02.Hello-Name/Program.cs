using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            Hello(name); 

        }

        static void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
