public static class AbstractShapeFactory {
    public static IFigure? buildShape(string shape, double [] args) {
        switch(shape){
            case "Square":
                Square s = new Square(args[0]);
                return s;       
            case "Rectangle":
                Rectangle rect = new Rectangle(args[0], args[1]);        
                return rect;
            case "Triangle":
                Triangle t = new Triangle(args[0], args[1]);
                return t;
            case "Circle":
                Circle c = new Circle(args[0]);
                return c;
            case "Sphere":
                Sphere sp = new Sphere(args[0]);
                return sp;
            default:
                Console.WriteLine("Unknown figure {0}", args[1]);
                return null;
        }
    }
}