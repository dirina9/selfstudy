﻿using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            worker.WorkPerformed += delegate(object sender, WorkPerformedEventArgs e)
            {
                Console.WriteLine("Hours worked: " + e.Hours + " " + e.WorkType);
            };
            worker.WorkCompleted += delegate
            {
                Console.WriteLine("Worker is done");
            };
            worker.DoWork(8, WorkType.GenerateReports);

            Console.Read();
        }

    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
