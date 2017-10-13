using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine().ToLower();

            switch(parameter)
            {
                case "face":
                    Console.WriteLine("{0:f2}",GetCubeFaceDiagonal(a));
                    break;
                case "space":
                    Console.WriteLine("{0:f2}", GetCubeSpaceDiagonal(a));
                    break;
                case "volume":
                    Console.WriteLine("{0:f2}", GetCubeVolume(a));
                    break;
                case "area":
                    Console.WriteLine("{0:f2}", GetCubeSurfaceArea(a));
                    break;
            }

        }

        static double GetCubeVolume(double a)
        {
            var volume = a * a * a;

            return volume;
        }

        static double GetCubeSurfaceArea(double a)
        {
            var surfaceArea = 6 * (a * a);

            return surfaceArea;
        }

        static double GetCubeFaceDiagonal(double a)
        {
            var faceDiagonal = Math.Sqrt(2 * (a * a));

            return faceDiagonal;
        }

        static double GetCubeSpaceDiagonal(double a)
        {
            var faceDiagonal = GetCubeFaceDiagonal(a);

            var spaceDiagonal = Math.Sqrt((a * a) + (faceDiagonal * faceDiagonal));

            return spaceDiagonal;
        }
    }
}
