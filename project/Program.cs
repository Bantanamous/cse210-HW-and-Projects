// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program
{
    public static void Main(string[] args)
    {

        Person myPerson = new Person("bob", "buuba", 97);

        myPerson.DisplayInfo();

        Police newpolice = new Police("gun", "bob", "joe", 16);
        Console.WriteLine($"{newpolice.DisplayPolice()}");

        Console.WriteLine($"{newpolice.GetName()}");

    }
}