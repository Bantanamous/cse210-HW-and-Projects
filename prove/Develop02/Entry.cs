class Entry
{
    private string _response;
    private string _prompt;
    private DateTime _date = DateTime.Now;

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
    }

    public void EntryDisplay()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }
    
}