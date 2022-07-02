using System;

namespace LibraryArea
{
    public class Area
    {
        // Вычисленеие площади круга по радиусу (возвращает площадь)
        public static double CircleFunc(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        // Вычисление площади треугольника по трём сторонам (возвращает площадь и результат проверки на наличие прямого угла)
        public static (double area, bool isRightAngle) TriangleFunc(double a, double b, double c)
        {

            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            bool isRightAngle;

            // Дополнительная проверка, является ли треугольник прямоугольным (возвращает истину или ложь)
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
            {
                isRightAngle = true;
            }
            else isRightAngle = false;
            return ( area, isRightAngle);
        }

        // Проверка легкости добавления других фигур (на примере площади прямоугольника)
        public static double SquareFunc(double f, double g)
        {
            double area = f * g;
            return area;
        }
    }
}
