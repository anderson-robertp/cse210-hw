public class Circle : Shape{
    // Variables
    private double _radius;
    public const double PI = 3.1415926535897931;

    // Constrictor
    public Circle():base(){}
    public Circle(string color, double radius) : base(color){
        _radius = radius;
    }

    // Methods
    public override double GetArea()
    {
        return PI * (_radius * _radius);
    }
}