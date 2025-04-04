using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Amazon";
        job1._jobTitle = "Warehouse Worker";
        job1._startYear = 2015;
        job1._endYear = 2020;

        Job job2 = new Job();

        job2._company = "Microsoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2018;
        job2._endYear = 2024;

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();

        myResume._name = "Daniel Davis";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}