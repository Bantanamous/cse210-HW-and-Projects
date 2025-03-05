class Cylinder
{
    private double _height = 10;
    private Circle _circle;//new circle of circle type, but is private
    
    public Cylinder(double h, Circle c)//constructor initializing h and c as parameters of cylinder and assigns them to h and c which are given.
    {
        _height = h;
        _circle = c;
    }
    public double GetVolume()
    {
        double volume = _height * _circle.GetArea();
        return volume;
    }
    public void DisplayCylinderVolume()
    {
        Console.WriteLine($"Cylinder volume: {GetVolume()}");
    }
}