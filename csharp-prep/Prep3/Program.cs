using System;
using System.ComponentModel;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // int intMagicNumber;
        int intUserGuess;
        
        // Asked the user for a magic number, now uses a random number from the computer.
        /* Console.WriteLine("What is the Magic Number?");
        string magicNumber = Console.ReadLine();
        intMagicNumber = int.Parse(magicNumber); */
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        // A do while loop to keep the user playing until the magic number is correctly guessed.
        do 
        {            
            Console.WriteLine("What is your guess?");
            string userGuess = Console.ReadLine();
            intUserGuess = int.Parse(userGuess);
             
            if (number < intUserGuess)
            {
                Console.WriteLine("Too high.");
            }
            else if (number > intUserGuess)
            {
                Console.WriteLine("Too low.");
            }
            else
            {
                Console.WriteLine("You guessed the magic number!");
            } 

        } while (number != intUserGuess);

       
    }
}