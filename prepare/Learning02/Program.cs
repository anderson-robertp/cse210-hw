using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Create new job instance and set member vatiables
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Blizzard";
        job1._startYear = 1999;
        job1._endYear = 2003;

        // Display company member variable for job1
        //job1.DisplayJobDetails();

        // Create new job instance and set member vatiables
        Job job2 = new Job();
        job2._jobTitle = "Software Team Lead";
        job2._company = "Bungie";
        job2._startYear = 2004;
        job2._endYear = 2009;

        // Display company member variable for job2
        //job2.DisplayJobDetails();

        // Create resume class instance
        Resume myResume = new Resume();

        // Add Jobs to the myResume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._name = ("Wilt Chamberlin");

        // Display jobs from job list
        //Console.WriteLine(myResume._jobs[0]._jobTitle);

        // Display resume
        myResume.DisplayResumeDetails();

    }
}