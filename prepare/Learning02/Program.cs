using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Ministry of Education";
        job1._jobTitle = "Teacher";
        job1._startYear = 2013;
        job1._endYear = 2019;
        //Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._company = "Constructor Ltd";
        job2._jobTitle = "Civil Engineer";
        job2._startYear = 2019;
        job2._endYear = 2024;
        //Console.WriteLine(job2._company);

        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._name ="Cassien Habyarimana";
        myResume.DisplayResumeDetails();
    }
}