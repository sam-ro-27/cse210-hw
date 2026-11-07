using System;

public class Job
{
    public int Id { get; set; }
    public string _Title { get; set; } = string.Empty;
    public string _Company { get; set; } = string.Empty;
    public int _StartYear { get; set; }
    public int _EndYear { get; set; }
}

public class Program
{
    public static void Main()
    {
        Job job1 = new Job
        {
            _Title = "Software Engineer",
            _Company = "Microsoft",
            _StartYear = 2019,
            _EndYear = 2022
        };

        Console.WriteLine(job1._Company);

        Job job2 = new Job
        {
            _Title = "Manager",
            _Company = "Apple",
            _StartYear = 2022,
            _EndYear = 2023
        };

        Console.WriteLine(job2._Company);
    }
}
