using consoleapp.lib;

double dimensionA = 0;
double dimensionB = 0;

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
    dimensionA = resultArg1;
} else {
    Console.WriteLine("Dimensions must be real numbers");
    return;
}

if(args.Length > 3) {
    if(Double.TryParse(args[3], out double resultArg2)) {
        dimensionB = resultArg2;
    } else {
        Console.WriteLine("Dimensions must be real numbers");
    }
}

AreaReporter r = new AreaReporter();
VolumeReporter v = new VolumeReporter();

switch(args[1]){
    case "Square":
        Square s = new Square(dimensionA);        
        r.doReport(s);
        break;
    case "Rectangle":
        Rectangle rect = new Rectangle(dimensionA, dimensionB);        
        r.doReport(rect);
        break;
    case "Triangle":
        Triangle t = new Triangle(dimensionA, dimensionB);
        r.doReport(t);
        break;
    case "Circle":
        Circle c = new Circle(dimensionA);
        r.doReport(c);
        break;
    case "Sphere":
        Sphere sp = new Sphere(dimensionA);
        v.doReport(sp);
        break;
    default:
        Console.WriteLine("Unknown figure {0}", args[1]);
        break;
}

