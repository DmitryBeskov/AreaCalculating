namespace AreaCalculating;

public class Triangle : Shape
{
    private double _side1;
    private double _side2;
    private double _side3;

    public Triangle(double side1, double side2, double side3)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
    }

    public override double GetArea() // Метод, высчитывающий площадь треугольника по 3 сторонам
    {
        if (IsExists())
        {
            double p = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        }

        return 0;
    }

    public override bool IsExists() // Метод, проверяющий существует ли треугольник
    {
        return (_side1 + _side2 > _side3 && _side2 + _side3 > _side1 && _side3 + _side1 > _side2);
    }

    public bool IsRectangular() // Метод, проверяющий прямоугольный ли треугольник
    {
        if (!IsExists())
            return false;

        double[] sides =
        {
            _side1,
            _side2,
            _side3
        };
        Array.Sort(sides);

        return Math.Pow(sides[2], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2);
    }
}
