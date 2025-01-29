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
    }
}
