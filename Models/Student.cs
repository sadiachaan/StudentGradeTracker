using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeTracker.Models
{
    public class Student
    {
        public int nextID = 1;
        public int StudentID { get; set; }
        public string Name { get; set; }

        public List<Grade> Grades { get; private set; } = new List<Grade>();

        public Student(string name)
        {
            Name = name;
            StudentID = nextID++;
        }

        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
        }

        public double CalculateOverallGrade()
        {
            if (Grades.Count == 0)
            {
                return 0.00; //Handle no grades scenario
            }
            return Grades.Average(Grade => grade.Score);
        }

        public override string ToString()
        {
            return $"StudentID:{StudentID} \n Name:{Name} \n Overall Grade:{CalculateOverallGrade():F2}";
        }
    }
}
