public class Rectangle : Shape{
    // Variables
    private double _length;

    private double _width;

    // Constrictor
    public Rectangle() : base(){}
    public Rectangle(string color, double length, double width) : base(color){
        _length = length;
        _width = width;
    }

    // Methods
    public override double GetArea()
    {
        return _length * _width;
    }
}