using System;
using System.ComponentModel.Design;
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

                switch (choice)
                {

                }
            }
        }

            //Function to display menu options
            private static void DisplayMenu() {
            Console.WriteLine("***Menu***");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Add Grade");
            Console.WriteLine("4. Exit");
        }

        private static int GetChoice() { 
            Console.WriteLine("Enter choice: ");
            string input = Console.ReadLine();
            int choice;
            while (!int.TryParse(input,out choice)) {
                Console.WriteLine("Invalid input. Please enter an integer!");
                input = Console.ReadLine();
            }
            return choice;
        }

        //Function to add a new Student 
        private static void AddStudent()
        {
            Console.WriteLine("Enter students's name: ");
            string name = Console.ReadLine();
            students.Add(new Student(name));
            Console.WriteLine("Student Added Successfully");
        }

        //Function to view Students 
        private static void ViewStudents()
        {
            if (students.Count == 0) {
                Console.WriteLine("No student added yet");
                return;
            }
            Console.WriteLine("***View Students***");
            foreach (Student student in students) { 
                Console.WriteLine(student);
            }
        }

        private static void AddGrade()
        {

        }
    }
}