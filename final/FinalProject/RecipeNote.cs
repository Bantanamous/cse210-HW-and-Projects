public class RecipeNote
{
    private readonly Dictionary<string, string> _notes = new Dictionary<string, string>();

    public void AddNoteToRecipe(string recipeName, string note)
    {
        _notes[recipeName] = note;
    }
}
