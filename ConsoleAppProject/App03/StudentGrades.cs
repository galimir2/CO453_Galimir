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

        public void Run() 
        {
            ConsoleHelper.OutputHeading("Student Marks");

            InputMarks();
            CalculateStats();
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

            for (int i = 0; i < STUDENTS.Length; i++)
            {
                Mark = (int)ConsoleHelper.InputNumber("Please enter a mark for the student " + STUDENTS[i] + " > ", 0, 100);

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
                Console.WriteLine("Student " + i + " achieved " + MARKS[i]);
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
            else if (MARKS >= LOWESTGRADEA && MARKS <= HighestMark)
            {
                return Grades.A;
            }
            return Grades.F;

        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateStats()
        {
            double total = 0;

            MINMARK = HighestMark;
            MAXMARK = 0;

            foreach (int mark in MARKS)
            {
                total = total + mark;
                if (mark > MAXMARK) MAXMARK = mark;
                if (mark < MINMARK) MINMARK = mark;
            }

            MEAN = total / MARKS.Length;
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
        }
    }

}