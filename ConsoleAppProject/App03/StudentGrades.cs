using System;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Application for converting marks into grades and calculating
    /// the mean, maximum and minimum mark that were entered.
    /// </summary>
    public class StudentGrades
    {
        // Constants (Grade Boundaries)

        public const int LOWESTMARK = 0;
        public const int LOWESTGRADED = 40;
        public const int LOWESTGRADEC = 50;
        public const int LOWESTGRADEB = 60;
        public const int LOWESTGRADEA = 70;
        public const int HighestMark = 100;

        // Properties
        public string[] STUDENTS { get; set; }

        public int[] MARKS { get; set; }

        public int[] GradeProfile { get; set; }

        public double MEAN { get; set; }

        public int MINMARK { get; set; }

        public int MAXMARK { get; set; }

        /// <summary>
        /// Used by class diagram
        /// </summary>
        public ConsoleHelper ConsoleHelper
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Used by class diagram
        /// </summary>
        public Grades Grades
        {
            get => default;
            set
            {
            }
        }

        public void DisplayMenu() 
        {
            ConsoleHelper.OutputHeading("Student Marks");

            InputMarks();
            OutputMarks();
            CalculateStats();
            OutputStats();
            CalculateGradeProfile();
            
        }

        /// <summary>
        /// Contains the 10 students and inputs the marks for all the students
        /// </summary>
        public void InputMarks()
        {
            int Mark;

            MARKS = new int[10];
            STUDENTS = new string[]
            {
                "Galimir","Max", "Edric",
                "Abdul", "Ivelin","Iskren",
                "Jack", "Maya", "Deryl",
                "Luke"
            };
            GradeProfile = new int[(int)Grades.A + 1];
            MARKS = new int[STUDENTS.Length];

            for (int i = 0; i < STUDENTS.Length; i++)
            {
                Mark = (int)ConsoleHelper.InputNumber("Please enter a mark for the student " + STUDENTS[i] + " " + (i + 1) + ": ");

                MARKS[i] = Mark;
            }

            Console.WriteLine("\nYou have entered the mark for the students. \n");
        }

        /// <summary>
        /// Outputs the marks for all the students
        /// </summary>
        public void OutputMarks()
        {
            for (int i = 0; i < STUDENTS.Length; i++)
            {
                Console.WriteLine($" {STUDENTS[i]} {MARKS[i]}");
            }
        }

        /// <summary>
        /// Turns the marks into grades
        /// </summary>
        public Grades ConvertToGrade(int Marks)
        {
            if (Marks >= 0 && Marks < LOWESTGRADED)
            {
                return Grades.F;
            }
            else if (Marks >= LOWESTGRADED && Marks < LOWESTGRADEC)
            {
                return Grades.D;
            }
            else if (Marks >= LOWESTGRADEC && Marks < LOWESTGRADEB)
            {
                return Grades.C;
            }
            else if (Marks >= LOWESTGRADEB && Marks < LOWESTGRADEA)
            {
                return Grades.B;
            }
            else if (Marks >= LOWESTGRADEA && Marks <= HighestMark)
            {
                return Grades.A;
            }

            return Grades.F;

        }

        /// <summary>
        /// Calculation for the maximum, minimum and mean marks
        /// </summary>
        public void CalculateStats()
        {
            double total = 0;

            MINMARK = MARKS[0];
            MAXMARK = MARKS[0];

            foreach (int mark in MARKS)
            {
                total = total + mark;
                if (mark > MAXMARK) MAXMARK = mark;
                if (mark < MINMARK) MINMARK = mark;
            }

            MEAN = total / MARKS.Length;
        }

        /// <summary>
        /// Outputs the mean, minimum and maximum marks
        /// </summary>
        public void OutputStats()
        {
            OutputMean();
            OutputMinimum();
            OutputMaximum();
        }


        public void OutputMean()
        {
            CalculateStats();
            Console.Write(" \nThe mean average mark is: " + $"{MEAN}");
        }

        public void OutputMinimum()
        {
            CalculateStats();
            Console.Write(" \nThe smallest mark in the group is: " + $"{MINMARK}");
        }

        public void OutputMaximum()
        {
            CalculateStats();
            Console.Write(" \nThe highest mark in the group is: " + $"{MAXMARK}");
        }

        /// <summary>
        /// Calculates the the gradeprofile
        /// </summary>
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in MARKS)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
            OutputGradeProfile();
        }
        
        /// <summary>
        /// Outputs the gradeprofile and the formula for the calculation
        /// </summary>
        public void OutputGradeProfile()
        {
            Grades grade = Grades.F;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / MARKS.Length;
                grade++;
                Console.WriteLine($"\nGrade {grade} {percentage}% Count {count}");
            }
            Console.WriteLine();
        }
    }

}