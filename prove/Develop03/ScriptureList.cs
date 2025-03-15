class ScriptureList
{
    private List<Scripture> _scriptures;

    public ScriptureList()
    {
        _scriptures = new List<Scripture>();
        LoadScriptures(); // Load or initialize the list of scriptures
    }

    // Load scriptures into the collection
    private void LoadScriptures()
    {
        // Set of Scriptures
        _scriptures.Add(new Scripture("John", 3, 16, "For God so loved the world that he gave his only begotten Son"));
        _scriptures.Add(new Scripture("Proverbs", 3, 6, "Trust in the Lord with all your heart and lean not on your own understanding."));
        _scriptures.Add(new Scripture("1 Nephi", 3, 7, "I will go and do the things which the Lord hath commanded."));
        _scriptures.Add(new Scripture("Moroni", 10, 3, 5, "Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts. And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And"));

    }

    // Display available scriptures and let the user choose
    public Scripture ChooseScripture()
    {
        Console.Clear();
        Console.WriteLine("Please choose a scripture:");
        
        for (int i = 0; i < _scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_scriptures[i].GetReference()}"); // accesses the reference from reference through a getreference method in scripture
        }
        
        int choice;
        do
        {
            Console.WriteLine("Enter the number of your choice (1 to " + _scriptures.Count + "):");
        } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > _scriptures.Count);
        
        return _scriptures[choice - 1]; // Return the selected scripture
    }

    // Methods to set to add or remove scriptures if implemented
    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }

    public void RemoveScripture(Scripture scripture)
    {
        _scriptures.Remove(scripture);
    }
}