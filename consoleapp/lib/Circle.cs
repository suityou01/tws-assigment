using consoleapp.lib;

public class Circle: IFlatFigure {
    protected double _radius;
    public Circle(double radius){
        this._radius = radius;
    }

    public double getArea()
    {
        return Math.PI * (this._radius * this._radius);
    }
}