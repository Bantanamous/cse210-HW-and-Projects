class Reference
{
    private string _bookName;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Constructors for single or multi verse references
    public Reference(string bookName, int chapter, int verse) // single verse constructor
    {
        _bookName = bookName;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0;
    }

    public Reference (string bookName, int chapter, int startVerse, int endVerse) //multi verse constructor
    {
        _bookName = bookName;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    
    public string GetReference() // returns formatted reference based on if it is one verse (_endVerse == 0) or multiple verses (shown by a range form start to end)
    {
        if (_endVerse == 0)
        {
            return $"{_bookName} {_chapter}:{_startVerse}"; // one verse
        }
        else
        {
            return $"{_bookName} {_chapter}:{_startVerse}-{_endVerse}"; //  verse range
        }
    }
}