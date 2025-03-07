class Entry
{
    private string _response;
    private string _prompt;
    private DateTime _date;

    public Entry(DateTime date, string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }


    public string FormatEntry() //Formats the entry for saving to a file, uses a '|' for separating.
    {
        return $"{_date:MM-dd-yyyy}|{_prompt}|{_response}";
    }
    public void EntryDisplay()
    {
        Console.WriteLine($"{_date} - {_prompt}\n{_response}\n");
    }
    public static Entry FromFile(string line)
    {
        string[] parts = line.Split("|");
        DateTime date = DateTime.Parse(parts[0]);
        string prompt = parts[1].Trim();
        string response = parts[2].Trim();
        return new Entry(date, prompt, response);
    }
}