using System;

namespace AreaCalculating;


public class Circle : Shape
{
    private double _r;

    public Circle(double r)
    {
        _r = r;
    }

    public override double GetArea() //Метод, высчитывающий площадь круга
    {
        return _r * _r * Math.PI;
    }

    public override bool IsExists()
    {
        return _r > 0;
    }
}
