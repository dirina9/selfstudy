﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_foundamentals_ex2
{
    public class GradeBook : GradeTracker
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float> { 91 , 89.5f, 75};
        }

        public override GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();


            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public override void WriteGrades(TextWriter destination)
        {
            foreach (var grade in grades)
            {
                destination.WriteLine(grade);
            }
        }


        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }
        protected List<float> grades;

    }
}
