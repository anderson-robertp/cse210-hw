using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square = new Square("blue" , 5);
        shapes.Add(square);
        Circle circle = new Circle("red", 7);
        shapes.Add(circle);
        Rectangle rectangle = new Rectangle("green", 15, 30);
        shapes.Add(rectangle);

        foreach (var item in shapes)
        {
            string color = item.GetColor();
            double area = item.GetArea();
            Console.WriteLine($"{color} {area}");
        }       

            
    }
}