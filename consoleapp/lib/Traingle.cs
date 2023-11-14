using consoleapp.lib;

public class Triangle: FlatFigure {
    private double _width;
    private double _height;
    public Triangle(double width, double height) {
        this._width = width;
        this._height = height;
    }

    public override double getArea()
    {
        return (this._width * this._height) / 2;
    }
}