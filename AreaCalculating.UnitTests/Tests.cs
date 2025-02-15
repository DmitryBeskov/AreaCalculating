namespace AreaCalculating.UnitTests;

public class Tests
{

    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void TriangleAreaTest() // Убедиться, что площадь треугольника высчитывается правильно
    {
        double area = Shapes.Triangle.GetArea(5, 4, 3);
        Assert.That(area, Is.EqualTo(6));
    }

    [Test]
    public void TriangleIsNotExistsTest() // Убедиться, что при невозможном треугольнике возвращает ноль
    {
        double area = Shapes.Triangle.GetArea(100, 20, 30);
        Assert.That(area, Is.EqualTo(0));
    }

    [Test]
    public void CircleAreaTest() // Убедиться, что площадь круга высчитывается правильно
    {
        double area = Shapes.Circle.GetArea(5);
        Assert.That(area, Is.EqualTo(5 * 5 * Math.PI));
    }
}
