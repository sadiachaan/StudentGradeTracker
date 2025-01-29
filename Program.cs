using System;
using StudentGradeTracker;
using StudentGradeTracker.Models;

namespace StudentGradeTracker
{
    class Program
    {
        private static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            Console.WriteLine("***Student Grade Tracker***");
            while (true)
            {
                DisplayMenu();
                int choice = GetChoice();

                switch (choice) { 

                }
            }

            //Function to display menu options
            private static void DisplayMenu() {
            Console.WriteLine("***Menu***");
            Console.WriteLine("***Menu***");
            Console.WriteLine("***Menu***");
            Console.WriteLine("***Menu***");

        }

        private static int GetChoice() { 
            Console.WriteLine("Enter choice: ");
            string input = Console.ReadLine();
            int choice = int.Parse(input);
        }

    }

    }
}