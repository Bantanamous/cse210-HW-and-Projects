using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job("Lockheed Martin","Quantity Assurance Officer",2021,2025);//now using constructor
        // job1._company = "Lockheed Martin";
        // job1._jobTitle = "Quantity Assurance Officer";
        // job1._startYear = 2021;
        // job1._endYear = 2025;

        Job job2 = new Job("Bro's Bread","Master of Bread",2005,2027);//now using constructor
        // job2._company = "Bro's Bread";
        // job2._jobTitle = "Master of Bread";
        // job2._startYear = 2005;
        // job2._endYear = 2027;

        Console.WriteLine();
        job1.Display();
        job2.Display();
        Console.WriteLine();
        
        Resume Resume = new Resume("Geoffery Vaynerchuk");//using constructor to add name at start
        // Resume._name = "Geoffery Vaynerchuk";
        Resume.AddJob(job1);
        Resume.AddJob(job2);
        // Resume._jobs.Add(job1);
        // Resume._jobs.Add(job2);

        Resume.Display();
        Console.WriteLine();
        // Console.WriteLine(Resume._jobs[0]._jobTitle);
        // Console.WriteLine($"Job: {job1._jobTitle}");
        //Console.WriteLine(job1._company);
        //Console.WriteLine(job2._company);
        }
}