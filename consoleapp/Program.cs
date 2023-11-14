using System.Reflection.Metadata;
using consoleapp.lib;

double[] dimensions = new double [2];

if(args.Length ==1) {
    Console.WriteLine("Usage :");
    Console.WriteLine("consoleapp Square {length}");
    Console.WriteLine("consoleapp Rectangle {width} {length}");
    Console.WriteLine("consoleapp Triangle {width} {height}");
    Console.WriteLine("consoleapp Circle {radius}");
    Console.WriteLine("consoleapp Sphere {radius}");
    return;
}

if(Double.TryParse(args[2], out double resultArg1)) {
    dimensions[0] = resultArg1;
} else {
    Console.WriteLine("Dimensions must be real numbers");
    return;
}

if(args.Length > 3) {
    if(Double.TryParse(args[3], out double resultArg2)) {
        dimensions[1] = resultArg2;
    } else {
        Console.WriteLine("Dimensions must be real numbers");
    }
}

IFigure? shape  = AbstractShapeFactory.buildShape(args[1], dimensions);
if(shape !=null){
    IReporter? reporter = AbstractReporterFactory.getReporter(shape);
    if(reporter != null) {
        reporter.doReport(shape);
    }
}


