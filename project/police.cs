class Police : Person
{
    private string _weapons;

    public Police(string weapons, string fristName, string lastName, int age)
    : base(fristName, lastName, age)
    {
        _weapons = weapons;
        _height = 76;
    }

    public string DisplayPolice()
    {
        return $"{_weapons}, {DisplayInfo()}";
    }

}