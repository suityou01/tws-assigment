public static class AbstractReporterFactory {
    public static IReporter? getReporter(IFigure shape){
        switch(shape){
            case Circle:
            case Square:
            case Rectangle:
            case Triangle:
                return new AreaReporter();
            case Sphere:
                return new VolumeReporter();
            default:
                return null;
        }
    }
}