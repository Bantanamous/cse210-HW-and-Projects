using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");

    // Fraction f1 = new Fraction();
    // Fraction f2 = new Fraction(6);
    // Fraction f3 = new Fraction(7,6);
    // f1.SetTop(1);
    // f1.SetBottom(2);
    // Console.WriteLine(f1.GetTop() + "/" + f1.GetBottom());

    Fraction fraction = new Fraction();
    Fraction fraction1 = new Fraction(1);
    Fraction fraction2 = new Fraction(1, 2);
    Console.WriteLine(fraction.GetFractionString());
    Console.WriteLine(fraction1.GetFractionString());
    Console.WriteLine(fraction2.GetFractionString());

    
    fraction1.SetTop(15);
    fraction2.SetTop(13);
    fraction2.SetBottom(7);
    fraction2.GetFractionString();
    Console.WriteLine(fraction2.GetFractionString());
    fraction2.GetDecimalValue();
    Console.WriteLine(fraction2.GetDecimalValue());

    }
}