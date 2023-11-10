using consoleapp.lib;

public class AreaReporter : IReporter
{
    public void doReport(IFlatFigure figure)
    {
        Console.WriteLine("The area of the {0} is {1}", figure.GetType(), Math.Round(figure.getArea(),2));
    }
}