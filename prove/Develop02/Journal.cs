class Journal
{
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayJournal()
    {
        if (_entries.Count == 0) //checks if there are any entries to display
        {
            Console.WriteLine("No entries to display.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.EntryDisplay();
            }
        }
    }
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.FormatEntry());
            }
        }
    }
    public void LoadFromFile(string fileName)
    {
        try
        {
            _entries.Clear(); //Clears currently loaded journal before loading needed journal
            string[] entries = File.ReadAllLines(fileName);

                foreach (string line in entries)
            {
                Entry entry = Entry.FromFile(line); //creates an entry object
                _entries.Add(entry); //adds entry to journal
            }
            Console.WriteLine("Journal Loaded.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
}