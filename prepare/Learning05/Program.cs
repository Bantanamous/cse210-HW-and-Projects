using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();
        
        Square newSquare = new Square(5, "Red");
        Rectangle newRectangle = new Rectangle(5, 10, "Blue");
        Circle newCircle = new Circle(5, "Green");
       
        shapes.Add(newSquare);
        shapes.Add(newRectangle);
        shapes.Add(newCircle);

        Console.WriteLine($"Square Area: {newSquare.GetArea()}, Color: {newSquare.GetColor()}");
        Console.WriteLine($"Rectangle Area: {newRectangle.GetArea()}, Color: {newRectangle.GetColor()}");
        Console.WriteLine($"Circle Area: {newCircle.GetArea()}, Color: {newCircle.GetColor()}");
    }
}