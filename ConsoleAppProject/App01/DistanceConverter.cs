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
        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "feet";
        public const string METRES = "metres";
        public const string MILES = "miles";

        private double ToDistance;
        private double FromDistance;


        public string FromUnit;
        public string IntoUnit;

        ///<summary>
        ///This method will be used to input the distance in miles
        ///then will calcualte the disntace in feet and will output
        ///the disntance into feet.
        /// </summary>

        public void Run()
        {
            PrintHeading();
            InputFromUnit();
            InputToUnit();
            InputFromDistance();
            ConvertToDistance();
            PrintResults();
        }

        private void InputFromUnit()
        {
            Console.WriteLine("Please chose one of the following units to convert from!");
            Console.WriteLine("Feet, Miles or Metres");
            FromUnit = Console.ReadLine();


        }

        private void InputToUnit()
        {
            Console.WriteLine("Please chose one of the following units to convert to!");
            Console.WriteLine("Feet, Miles or Metres");
            IntoUnit = Console.ReadLine();

        }

        private void InputFromDistance()
        {
            Console.WriteLine("Enter the number of " + FromUnit);
            FromDistance = Convert.ToDouble(Console.ReadLine());
        }


        /// <summary>
        /// Used to convert distance
        /// </summary>

        private void ConvertToDistance()
        { 
            if(FromUnit == FEET && IntoUnit == MILES)
             {
                ToDistance = FromDistance / FEET_IN_MILES;
             }
            else if (FromUnit == MILES && IntoUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == MILES && IntoUnit == METRES)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == METRES && IntoUnit == MILES)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == FEET && IntoUnit == METRES)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
            else if (FromUnit == METRES && IntoUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
        }

        private void PrintResults()
        {
            Console.WriteLine(FromDistance + " " + FromUnit + " converts to " + ToDistance + " " + IntoUnit);
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