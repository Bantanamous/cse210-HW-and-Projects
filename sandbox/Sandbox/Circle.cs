class Circle
{
    private double radius;

    public Circle(double r) //constructor, sets radius to r which is given
    {
        radius = r;
    }
    public double GetArea()
    {
        double area = Math.PI * radius * radius;
        return area;
    }
    public void DisplayCircleArea()
    {
        Console.WriteLine($"The area of the circle is: {GetArea()}");
    }
    // public void SetRadius(double r)
    // {
    //     radius = r;
    // }
    public double GetRadius()
    {
        return radius;
    }
}