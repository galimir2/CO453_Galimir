using System;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// 
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
        public string[] STUDENTS;

        public int[] MARKS;

        public int[] GradeProfile;

        public double MEAN;

        public int MINMARK;

        public int MAXMARK;

        public void DisplayMenu() 
        {
            ConsoleHelper.OutputHeading("Student Marks");

            InputMarks();
            OutputMarks();
            CalculateStats();
            OutputStats();
            CalculateGradeProfile();
            
        }

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
        /// 
        /// </summary>
        public void OutputMarks()
        {
            for (int i = 0; i < STUDENTS.Length; i++)
            {
                Console.WriteLine($" {STUDENTS[i]} {MARKS[i]}");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Grades ConvertToGrade(int MARKS)
        {
            if (MARKS >= 0 && MARKS < LOWESTGRADED)
            {
                return Grades.F;
            }
            else if (MARKS >= LOWESTGRADED && MARKS < LOWESTGRADEC)
            {
                return Grades.D;
            }
            else if (MARKS >= LOWESTGRADEC && MARKS < LOWESTGRADEB)
            {
                return Grades.C;
            }
            else if (MARKS >= LOWESTGRADEB && MARKS < LOWESTGRADEA)
            {
                return Grades.B;
            }
            else if (MARKS >= LOWESTGRADEA && MARKS < HighestMark)
            {
                return Grades.A;
            }
            else
                return Grades.G;
        }

        /// <summary>
        /// 
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
        /// 
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

        public void OutputGradeProfile()
        {
            Grades grade = Grades.G;

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