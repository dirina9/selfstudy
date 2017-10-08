using System.Collections;
using System.IO;

namespace _1_foundamentals_ex2
{
    internal interface IGradeTracker: IEnumerable
    {
        void AddGrade(float grade);
        GradeStatistics ComputeStatistics();
        void WriteGrades(TextWriter destination);
        string Name { get; set; }
    }
}