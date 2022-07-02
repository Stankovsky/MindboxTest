using System;
using LibraryArea;

namespace ConsoleSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности в см:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Радиус = {0}см\n\rПлощадь круга = {1} кв.см\n\r\n\r", radius, Area.CircleFunc(radius));


            Console.WriteLine("Введите длины сторон треугольника в см:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            var (area, isRightAngle) = Area.TriangleFunc(a, b, c);
            Console.WriteLine("Сторона а = {0}\n\rСторона b = {1}\n\rСторона c = {2}\n\rПлощадь треугольника = {3} кв.см\n\r", a, b, c, area);

            if (isRightAngle)
            {
                Console.WriteLine("Треугольник является прямоугольным\n\r\n\r");
            }
            else Console.WriteLine("Треугольник не является прямоугольным\n\r\n\r");


            Console.WriteLine("Введите длины сторон прямоугольника в см:");
            double f = Convert.ToDouble(Console.ReadLine());
            double g = Convert.ToDouble(Console.ReadLine());
            if (f == g)
            {
                Console.WriteLine("Сторона а = {0}\n\rСторона b = {1}\n\rПлощадь квадрата = {2} кв.см\n\r", f, g, Area.SquareFunc(f, g));
            }
            else Console.WriteLine("Сторона а = {0}\n\rСторона b = {1}\n\rПлощадь прямоугольника = {2} кв.см\n\r", f, g, Area.SquareFunc(f, g));
        }
    }
}

