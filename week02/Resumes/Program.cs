using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._jobTitle = "Software Engineer";
        Job1._companyName = "Amazon";
        Job1._startYear = 2020;
        Job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._companyName = "Apple";
        job2._startYear = 2024;
        job2._endYear = 2025;


        Resume myResume = new Resume();
        myResume._personName = "Danson Nganga";
        myResume._jobs.Add(Job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
