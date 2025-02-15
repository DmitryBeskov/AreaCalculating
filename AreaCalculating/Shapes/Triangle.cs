namespace AreaCalculating;

public static partial class Shapes
{
    public static class Triangle
    {
        public static double GetArea(double side1, double side2, double side3) // Метод, высчитывающий площадь треугольника по 3 сторонам
        {
            if (IsExists(side1, side2, side3))
            {
                double p = (side1 + side2 + side3) / 2;
                return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            }

            return 0;
        }

        public static double GetArea(double side, double h) // Метод, высчитывающий площадь треугольника по стороне и высоте
        {
            return (side * h) / 2;
        }

        public static bool IsExists(double side1, double side2, double side3) // Метод, проверяющий существует ли треугольник
        {
            return (side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2);
        }

        public static bool IsRectangular(double side1, double side2, double side3) // Метод, проверяющий прямоугольный ли треугольник
        {
            if (!IsExists(side1, side2, side3))
                return false;

            double[] sides =
            {
                side1,
                side2,
                side3
            };
            Array.Sort(sides);

            return Math.Pow(sides[2], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2);
        }
    }
}