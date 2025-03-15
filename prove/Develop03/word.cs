using System.Runtime.CompilerServices;
using System.Text;

class Word
{
    private string _word;
    private bool _hidden = false;
   
    public Word(string word) // constructor for Word Class
    {
        _word = word;
        _hidden = false;
    }
    
    public void Hide()
    {
        _hidden = true;
    }

    public void Unhide()
    {
        _hidden = false;
    }
    
    public bool IsHidden()
    {
        return _hidden;
    }

    public override string ToString()
    {
        if (!_hidden) // if word is not hidden, give back the actual word. 
        {
            return _word;
        }
        
        StringBuilder hiddenWord = new StringBuilder();

        foreach (char letter in _word)
        {
            if (char.IsLetter(letter)) // checks if character is a letter
            {
                hiddenWord.Append("_"); // replaces letters with (_)
            }
            else
            {
                hiddenWord.Append(letter); //if punctuation, add punctuation instead of (_)
            }
        }
        return hiddenWord.ToString();
    }
}