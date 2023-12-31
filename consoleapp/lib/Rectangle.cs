using consoleapp.lib;

public class Rectangle : IFlatFigure
{
    private double _width = 0;
    private double _length = 0;
    public Rectangle(double width, double length) {
        this._width = width;
        this._length = length;
    }
    public double getArea()
    {
        return this._width * this._length;
    }
}