using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        int intUserNumber = 1;
        int sum = 0;
        int average = 0;
        int count = 0;
        
        Console.WriteLine("Enter a list of numbers, type '0' to finish.");
        
        do 
            {
                string userNumber = Console.ReadLine();
                intUserNumber = int.Parse(userNumber);
                
                if (intUserNumber != 0)
                {
                    numbers.Add(intUserNumber);
                }

            } while (intUserNumber !=0);

        foreach (int number in numbers)
        {
            Console.WriteLine();
            Console.Write($"{number}");
            //Console.WriteLine();
            count =+ 1 ;
            sum = sum + number;
            average = sum / count;
        }
        Console.WriteLine();
        Console.Write($"Sum: {sum}");
        Console.WriteLine();
        Console.Write($"Average: {average}");
    }
}