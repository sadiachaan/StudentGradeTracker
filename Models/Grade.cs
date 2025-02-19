﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeTracker.Models
{
    public class Grade
    {
        public string Subject { get; set; }
        public double Score { get; set; }

        public Grade(string subject, double score)
        {
            Subject = subject; 
            Score = score;
        }

        public override string ToString()
        {
            return $"{Student}:{Score:F2}"; //F2 means 2 float points
        }


    }
}
