class SauceRecipe : Recipe
{
    private string _sauceType;
    
    public SauceRecipe(string name, List<string> ingredients, string instructions, string sauceType)
        : base(name, ingredients, instructions)
    {
        _sauceType = sauceType;
    }

    public override void DisplayRecipe()
    {
        Console.WriteLine($"Sauce Recipe ({_sauceType}): ");
        base.DisplayRecipe();
    }
}