class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    protected int _height;

    public Person(string fristName, string lastName, int age)
    {
        _firstName = fristName;
        _lastName = lastName;
        _age = age;
        _height = 0;
    }

    public string DisplayInfo()
    {
        return $"Info: {_firstName} {_lastName} {_age}";
    }

    public int GetHeight()
    {
        return _height;
    }
    public void setHeight(int height)
    {
        _height = height;
    }
}