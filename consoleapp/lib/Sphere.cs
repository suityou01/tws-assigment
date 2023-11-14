using consoleapp.lib;

public class Sphere : SolidFigure
{
    private double _radius;
    public Sphere(double radius)
    {
        this._radius = radius;
    }

    public override double getVolume()
    {
        return 4 * Math.PI * Math.Pow(this._radius,2);
    }
}