using System;
using System.Text;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This class is containing methods that are used
    /// for calculating the users's BMI. By using
    /// imperial or metric units.
    /// </summary>
    /// <author>
    /// Galimir Bozmarov 28/02/2021
    /// </author>
    public class BMI
    {

        public const string METRIC = "METRIC";
        public const string IMPERIAL = "IMPERIAL";

        public double weight;
        public double height;

        public string SelectedUnit;

        public double bmiResults;

        public string[] MenuChoices = { METRIC, IMPERIAL};

        public const double UNDERWEIGHT = 18.5;
        public const double NORMALWEIGHT = 24.9;
        public const double OVERWEIGHT = 29.9;

        public const double OBESEWEIGHT1 = 34.9;
        public const double OBESEWEIGHT2 = 39.9;
        public const double OBESEWEIGHT3 = 40.0;


        public void OutputUnit()
        {
            Console.WriteLine("Please Chose between: ");
            ConsoleHelper.OutputMenu(MenuChoices);

        }

        public string GetUnit()
        {
            SelectedUnit = Console.ReadLine().ToUpper();
            return SelectedUnit;
        }

        public double GetWeight()
        {
            if (SelectedUnit == METRIC)
            {
                Console.WriteLine("Please enter the weight in KGs: ");
                weight = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Please enter the weight in Stones: ");
                double stones = Convert.ToDouble(Console.ReadLine());
                weight = stones * 14;
                Console.WriteLine("Please enter the weight in Pounds: ");
                double pounds = Convert.ToDouble(Console.ReadLine());
                weight += pounds;
            }
            return weight;
        }

        public double GetHeight()
        {
            if (SelectedUnit == METRIC)
            {
                Console.WriteLine("Please enter the height in CMs: ");
                height = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Please enter the number of Feet: ");
                double feet = Convert.ToDouble(Console.ReadLine());
                height = feet * 12;
                Console.WriteLine("Please enter the number of Inches: ");
                double inches = Convert.ToDouble(Console.ReadLine());
                height += inches;
            }
            return height;
        }

        public void CalculateBMI()
        {
            if (SelectedUnit == METRIC)
            {
                bmiResults = (weight / height / height) * 10000;
            }
            if (SelectedUnit == IMPERIAL)
            {
                bmiResults = (weight * 703) / (height * height);
            }
        }

        public void OutputResult()
        {
            Console.WriteLine(SelectedUnit);

            if (bmiResults < UNDERWEIGHT)
            {
                Console.WriteLine("Your bmi is: " + bmiResults
                    + "\nYou are Underweight!");
            }
            else if (bmiResults < NORMALWEIGHT)
            {
                Console.WriteLine("Your bmi is: " + bmiResults
                    + "\nYou are healthy and you are in the normal range!");
            }
            else if (bmiResults < OVERWEIGHT)
            {
                Console.WriteLine("Your bmi is: " + bmiResults
                    + "\nYou are Overweight!");
            }
            else if (bmiResults < OBESEWEIGHT1)
            {
                Console.WriteLine("Your bmi is: " + bmiResults
                    + "\nYou are obese level 1!");
            }
            else if (bmiResults < OBESEWEIGHT2)
            {
                Console.WriteLine("Your bmi is: " + bmiResults
                    + "\nYou are obese level 2!");
            }
            else if (bmiResults >= OBESEWEIGHT3)
            {
                Console.WriteLine("Your bmi is: " + bmiResults
                    + "\nYou are obese level 3!");
            }
        }

        public void PrintHeading()
        {
            Console.WriteLine("\n-----------------------");
            Console.WriteLine("\tBMI Calculator");
            Console.WriteLine("\tBy Galimir Bozmarov");
            Console.WriteLine("\n-----------------------");
        }
    }

}
