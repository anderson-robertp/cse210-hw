using System.Formats.Asn1;

public class Shape
{
    // Variables
    protected string _color;

    //Constructor
    public Shape(){}
    public Shape(string color){
        _color = color;
    }

    //Methods

    public string GetColor(){
        
        return _color;
    }

    public void SetColor(string color){
        _color = color;
    }

    public virtual double GetArea(){
        double area = 100;
        return area;
    }

}