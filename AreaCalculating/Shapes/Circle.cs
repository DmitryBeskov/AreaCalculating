namespace AreaCalculating;

public static partial class Shapes
{
    public static class Circle
    {
        public static double GetArea(double r) // Метод, высчитывающий площадь круга
        {
            return r * r * Math.PI;
        }
    }
}