class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private static Random random = new Random();

    
    public Scripture(string bookName, int chapter, int verse, string text) // single verse constructor
    {
        _reference = new Reference(bookName, chapter, verse);
        addWord(text);
    }

    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text) // multi verse constructor
    {
        _reference = new Reference(bookName, chapter, startVerse, endVerse);
        addWord(text);
    }
    private void addWord(string text)
    {
        string[] words = text.Split(' '); // splits text by spaces
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }   
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetReference());
        foreach (Word word in _words)
        {
            Console.Write(word.ToString() + " ");
        }
        Console.WriteLine();
    }

    public string GetReference()
    {
        return _reference.GetReference(); // Access GetReference() of the Reference object
    }


    public void HideRandomWord(int count)
    {
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        if (visibleWords.Count == 0) return;

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
