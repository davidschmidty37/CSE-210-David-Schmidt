using System;

class Program
{

    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2018;
        job1._endYear = 2022;
        //job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Computer Programmer";
        job2._company = "Microsoft";
        job2._startYear = 2022;
        job2._endYear = 2025;
        //job2.DisplayJobDetails();
        
    
        Resume resume1 = new Resume();
        resume1._name = "Austin Virgin ";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}