public class Square : Shape
{
    //Variables
    private double _side;

    //Constructor
    public Square() : base(){}
    public Square(string color, double side) : base(color){
        _side = side;
    }

    //Methods
    public override double GetArea()
    {
        return _side * _side;
    }

}