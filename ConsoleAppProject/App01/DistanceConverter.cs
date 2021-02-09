using System;
using System.Runtime;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app converts miles to feet
    /// </summary>
    /// <author>
    /// Galimir Bozmarov version 0.1
    /// </author>
    class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        private double miles;
        private double feet;
        private double metres;
        ///<summary>
        ///This method will be used to input the distance in miles
        ///then will calcualte the disntace in feet and will output
        ///the disntance into feet.
        /// </summary>

        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
            InputFeet();
            CalculateMiles();
            OutputMiles();
            InputMiles();
            CalculateMetres();
            OutputMetres();

        }

        public void MilesToFeet()
        {
            PrintHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            PrintHeading();
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }
        public void MilesToMetres()
        {
            PrintHeading();
            InputMiles();
            CalculateMetres();
            OutputMetres();
        }

        private void InputMiles()
        {
            Console.Write("Enter the number of miles");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void InputMetres()
        {
            Console.Write("Enter the number of metres");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);
        }

        private void InputFeet()
        {
            Console.Write("Enter the number of feet");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        /// <summary>
        /// Used to calculate feet
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles* FEET_IN_MILES;
        }

        /// <summary>
        /// Used to calculate miles
        /// </summary>
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        /// <summary>
        /// Used to calculate metres
        /// </summary>
        private void CalculateMetres()
        {
            metres = feet / FEET_IN_MILES;
        }

        /// <summary>
        /// Used to output the number of feet
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine();
            Console.WriteLine(miles + " miles is " + feet + " feet");
            Console.WriteLine();
        }

        /// <summary>
        /// Used to output the number of miles
        /// </summary>
        private void OutputMiles()
        {
            Console.WriteLine();
            Console.WriteLine(feet + " feet is " + miles + " miles");
            Console.WriteLine();
        }

        /// <summary>
        /// Used to output the number of miles
        /// </summary>
        private void OutputMetres()
        {
            Console.WriteLine();
            Console.WriteLine(miles + " miles is " + metres + " metres");
            Console.WriteLine();
        }

        private void PrintHeading()
        {
            Console.WriteLine("\n-----------------------");
            Console.WriteLine("\tConvert Distances");
            Console.WriteLine("\tBy Galimir Bozmarov");
            Console.WriteLine("\n-----------------------");
        }
    }
}