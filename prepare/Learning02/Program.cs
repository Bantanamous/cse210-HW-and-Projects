using System;

class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public void Display()
    {
        Console.WriteLine($"Job Title: {_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}

class Resume 
{
    public string _name = "";
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Lockheed Martin";
        job1._jobTitle = "Quantity Assurance Officer";
        job1._startYear = 2021;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "Bro's Bread";
        job2._jobTitle = "Master of Bread";
        job2._startYear = 2005;
        job2._endYear = 2027;

        job1.Display();
        job2.Display();
        //Console.WriteLine(job1._company);
        //Console.WriteLine(job2._company);
    }
}