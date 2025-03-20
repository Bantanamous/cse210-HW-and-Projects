using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World!");

        // Circle myCircle = new Circle(10); //give in the radius r
        // myCircle.DisplayCircleArea();
        // Cylinder myCylinder = new Cylinder(10, myCircle); //give in the height, 10, and the circle of circle type 'myCirlce'
        // myCylinder.DisplayCylinderVolume();

        int counter = 0; //spinner demo
        while(counter < 10)
        {
            Console.Write("+");
            Console.Write("\b");
            Thread.Sleep(1000);
            Console.Write("-");
            Console.Write("\b");
            Thread.Sleep(1000);
            counter++;
        }
    }
}