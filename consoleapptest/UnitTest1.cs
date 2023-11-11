using System.Runtime.CompilerServices;
using consoleapp.lib;

namespace consoleapptest;

[TestClass]
public class UnitTest1
{

    [TestMethod]
    public void TestSquare()
    {
        var s = new Square(10);
        Assert.AreEqual(s.getArea(), 100);
    }

    [TestMethod]
    public void TestRectangle()
    {
        var r = new Rectangle(10, 20);
        Assert.AreEqual(r.getArea(), 200);
    }

    [TestMethod]
    public void TestTriangle()
    {
        var t = new Triangle(10, 20);
        Assert.AreEqual(t.getArea(), 100);
    }

    [TestMethod]
    public void TestCircle()
    {
        var c = new Circle(10);
        Assert.AreEqual(Math.Round(c.getArea(),2), 314.16);
    }

    [TestMethod]
    public void TestSphere()
    {
        var s = new Sphere(10);
        Assert.AreEqual(Math.Round(s.getVolume(),2), 1256.64);
    }

    [TestMethod]
    public void TestAbstractShapeFactory()
    {
        double [] dimensions = new double[1];
        dimensions[0] = 15;
        IFigure? shape = AbstractShapeFactory.buildShape("Circle", dimensions);
        Assert.IsInstanceOfType(shape, typeof(Circle));       
    }

    [TestMethod]
    public void TestAbstractReporterFactory()
    {
        Circle c = new Circle(15);
        Sphere s = new Sphere(15);
        IReporter? reporter = AbstractReporterFactory.getReporter(c);
        Assert.IsInstanceOfType(reporter, typeof(AreaReporter));       
        reporter = AbstractReporterFactory.getReporter(s);
        Assert.IsInstanceOfType(reporter, typeof(VolumeReporter));       
    }
}