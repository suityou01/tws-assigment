using consoleapp.lib;

public class VolumeReporter : IReporter
{
    public void doReport(ISolidFigure figure)
    {
        Console.WriteLine("The volume of the {0} is {1}", figure.GetType(), Math.Round(figure.getVolume(),2));
    }
}