using System;
using System.ComponentModel;

class Resume
{
    private string _name;
    private List<Job> _jobs;// _jobs = new List<Job>();

    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        // Console.WriteLine($"Job Title, Company, Start Year, End Year");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}