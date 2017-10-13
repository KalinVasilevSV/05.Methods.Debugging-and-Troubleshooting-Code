using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ax = double.Parse(Console.ReadLine());
            var Ay = double.Parse(Console.ReadLine());
            var Bx = double.Parse(Console.ReadLine());
            var By = double.Parse(Console.ReadLine());

            var Cx = double.Parse(Console.ReadLine());
            var Cy = double.Parse(Console.ReadLine());
            var Dx = double.Parse(Console.ReadLine());
            var Dy = double.Parse(Console.ReadLine());

            double lengthAB = GetLineLength(Ax, Ay, Bx, By);
            double lengthCD = GetLineLength(Cx, Cy, Dx, Dy);

            //Console.WriteLine(lengthAB);
            //Console.WriteLine(lengthCD);

            if(lengthAB>=lengthCD)
            {
                PrintLineFromCloserPoint(Ax, Ay, Bx, By);
            }
            else
            {
                PrintLineFromCloserPoint(Cx, Cy, Dx, Dy);
            }

        }

        static double GetLineLength(double Ax,double Ay, double Bx, double By)
        {
            double length = 0;

            double a = Math.Abs(Ax - Bx);
            double b = Math.Abs(Ay - By);

            length = Math.Sqrt((a*a)+(b*b));

            return length; 
        }

        static void PrintLineFromCloserPoint(double Ax, double Ay, double Bx, double By)
        {
            double distanceA = Math.Sqrt((Ax * Ax) + (Ay * Ay));
            double distanceB = Math.Sqrt((Bx * Bx) + (By * By));

            if(distanceA<=distanceB)
            {
                Console.WriteLine($"({Ax}, {Ay})({Bx}, {By})");
            }
            else
            {
                Console.WriteLine($"({Bx}, {By})({Ax}, {Ay})");
            }
        }
    }
}
