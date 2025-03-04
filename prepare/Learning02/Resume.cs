using System;

class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs");
        // Console.WriteLine($"Job Title, Company, Start Year, End Year");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}