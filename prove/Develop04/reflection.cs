using System.Diagnostics;

class Reflection : Activity
{
    public Reflection()
        : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") {}


    public void RunActivity()
    {
        Start();

        // list of initial prompts
        string[] prompts =
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of the last time you visited the Temple.",
            "Thinks of a time when you completed or fell short of a goal."
        };

        // list of follow-up questions
        string[] questions =
        {
            "Why was this experience meaningful to you?",
            "How did you feel when it was complete?",
            "What did you learn about yourself?", 
            "Have you done anything like this before?",
            "How did you get started",
            "What made this time different than other times where you were not as successful?",
            "What is your favorite thing about this experience",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself from this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Random rand = new Random(); // creates a new random object to get random prompts and follow-up questions
        Console.WriteLine(prompts[rand.Next(prompts.Length)]);
        Pause(5); // pauses for 5 seconds

        int elapsed = 0;
        while (elapsed < _duration) // checks the elapsed activity time against the duration provided
        {
            Console.WriteLine(questions[rand.Next(questions.Length)]);
            Pause(5);
            elapsed += 5;
        }

        End();
    }
}
