using consoleapp.lib;

public class Circle: FlatFigure {
    protected double _radius;
    public Circle(double radius){
        this._radius = radius;
    }

    public override double getArea()
    {
        return Math.PI * (this._radius * this._radius);
    }
}