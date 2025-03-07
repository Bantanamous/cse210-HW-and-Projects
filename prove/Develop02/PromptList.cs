class PromptList{
public List<string> _prompts = new List<string>() //List of some prompts to ask the user
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over, what would it be?",
        "What was the most important thing I learned today?",
        "What was the most important thing I did for someone else today?",
        "What was the most important thing I did for myself today?",
        "What was the most important thing I did today to further my goals?",
        "What was a challenging situation I faced today?",
        "Who is someone new I met today?",
        "What was the most fun thing I did today?"
    };
    Random random = new Random();
    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}