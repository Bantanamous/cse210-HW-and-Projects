using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?"); // asks for the person's first name
        String firstName = Console.ReadLine(); // takes an input for the person's first name
        Console.WriteLine("What is your last name?"); // asks for the person's last name
        String lastName = Console.ReadLine(); // takes an input for the person's last name
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}"); // prints out the person's name
    }
}