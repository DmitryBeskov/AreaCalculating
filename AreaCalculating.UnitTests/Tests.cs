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
        double area = new Triangle(5, 4, 3).GetArea();
        Assert.That(area, Is.EqualTo(6));
    }

    [Test]
    public void TriangleIsNotExistsTest() // Убедиться, что при невозможном треугольнике возвращает ноль
    {
        double area = new Triangle(100, 20, 30).GetArea();
        Assert.That(area, Is.EqualTo(0));
    }

    [Test]
    public void CircleAreaTest() // Убедиться, что площадь круга высчитывается правильно
    {
        double area = new Circle(5).GetArea();
        Assert.That(area, Is.EqualTo(5 * 5 * Math.PI));
    }
}
