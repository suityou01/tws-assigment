using consoleapp.lib;

public class Square : IFlatFigure
{
    private double _length = 0;
    public Square(double length){
        this._length = length;
    }
    public double getArea()
    {
        return this._length * this._length;
    }
}