using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine().ToLower();

            switch(figure)
            {
                case "triangle":
                    Console.WriteLine("{0:f2}",GetTriangleArea());
                    break;
                case "square":
                    Console.WriteLine("{0:f2}", GetSquareArea());
                    break;
                case "rectangle":
                    Console.WriteLine("{0:f2}", GetRectangleArea());
                    break;
                case "circle":
                    Console.WriteLine("{0:f2}", GetCircleArea());
                    break;
            }
        }

        static double GetTriangleArea()
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var triangleArea = (a * h) / 2;

            return triangleArea;
        }

        static double GetSquareArea()
        {
            var a = double.Parse(Console.ReadLine());

            var squareArea = a * a;

            return squareArea;
        }

        static double GetRectangleArea()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            var rectangleArea = a * b;

            return rectangleArea;
        }

        static double GetCircleArea()
        {
            var r = double.Parse(Console.ReadLine());

            var circleArea = Math.PI * r * r;

            return circleArea;
        }
    }
}
