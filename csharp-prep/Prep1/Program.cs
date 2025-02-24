using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?"); // asks for the person's first name
        String first_name = Console.ReadLine(); // takes an input for the person's first name
        Console.WriteLine("What is your last name?"); // asks for the person's last name
        String last_name = Console.ReadLine(); // takes an input for the person's last name
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}"); // prints out the person's name
    }
}