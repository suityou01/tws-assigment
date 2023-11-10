using consoleapp.lib;

namespace consoleapptest;

[TestClass]
public class UnitTest1
{

    [TestMethod]
    public void TestSquare()
    {
        var r = new AreaReporter();
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
    public void TestAreaReporter()
    {
        var s = new Square(10);
        var r = new AreaReporter();
        var stringWriter = new StringWriter();
	    Console.SetOut(stringWriter);
        
        r.doReport(s);
        var output = stringWriter.ToString();
        //Code smell, why do I need to trim it?
	    Assert.AreEqual("The area of the Square is 100", output.Trim());
    }

    [TestMethod]
    public void TestvolumeReporter()
    {
        var s = new Sphere(10);
        var r = new VolumeReporter();
        var stringWriter = new StringWriter();
	    Console.SetOut(stringWriter);
        
        r.doReport(s);
        var output = stringWriter.ToString();
        //Code smell, why do I need to trim it?
	    Assert.AreEqual("The volume of the Sphere is 1256.64", output.Trim());
    }
}