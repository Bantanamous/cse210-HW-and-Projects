using System;

class Breathing : Activity
{
    public Breathing()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") {}

    public void RunActivity()
    {
        Start(); // Prompt the user for the duration once at the start of the activity.

        int elapsed = 0; // to track time spent in activity

        while (elapsed < _duration)
        {
            
            Console.WriteLine("Breathe in...");
            Pause(5); // pause 5 seconds while showing a countdown
            elapsed += 5; // increment elapsed time by 5 seconds

            if (elapsed >= _duration) break; // Stop if we have completed the desired duration

            // Breathe out
            Console.WriteLine("Breathe out...");
            Pause(5); // pause for 5 seconds while showing a countdown
            elapsed += 5; // increment elapsed time by 5 seconds
        }

        End(); 
    }
}
