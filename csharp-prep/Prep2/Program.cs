using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter your Grade: ");
        String userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);
        String letter = "";
        if (grade >= 90)
        {
            //Console.WriteLine($"Your entered grade is {grade}, you got an A.");
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            //Console.WriteLine($"Your entered grade is {grade}, you got a B.");
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            //Console.WriteLine($"Your grade is {grade}, you got a C.");
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            //Console.WriteLine($"Your entered grade is {grade}, you got a D.");
            letter = "D";
        }
        else if (grade < 60)
        {
            //Console.WriteLine($"Your entered grade is {grade}, you got an F.");
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");
        if (grade > 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else 
        {
            Console.WriteLine("You did not pass the class, please contact your instructor.");
        }
    }
}