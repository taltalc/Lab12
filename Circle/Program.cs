using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle.Curcumference(12);
            Circle.CircleSquare(12);
            Circle.CircleCoordinates(12, 8, 4);
            Console.ReadKey();
        }
    }
    public static class Circle
    {
        public static double radius;
        public static double coordinatex;
        public static double coordinatey;


        public static void Curcumference(double radius)
        {

            double curcumference = 0;
            curcumference = 2 * Math.PI * radius;
            Console.WriteLine("Длина окружности равна {0:f2}", curcumference);
        }
        public static void CircleSquare(double radius)
        {

            double circlesqure = 0;

            circlesqure = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Площадь круга равна {0:f2}", circlesqure);
        }
        public static void CircleCoordinates(double radius, double coordinatex, double coordinatey)
        {
            if ((coordinatex * coordinatex + coordinatey * coordinatey) == (radius * radius))
            {
                Console.WriteLine("Точка с заданными координатами {0}, {1} принадлежит окружности с радиусом {2}", coordinatex, coordinatey, radius);
            }
            else
            {
                Console.WriteLine("Точка с заданными координатами {0}, {1}  не принадлежит окружности с радиусом {2}", coordinatex, coordinatey, radius);
            }

        }
    }
}
