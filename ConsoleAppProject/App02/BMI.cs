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

        public const double Underweight = 18.5;
        public const double Normalweight = 24.9;
        public const double Overweight = 29.9;

        public const double Obeseweight1 = 34.9;
        public const double Obeseweight2 = 39.9;
        public const double Obeseweight3 = 40.0;


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
            }
            else
            {
                Console.WriteLine("Please enter the weight in Stones: ");
                Console.WriteLine("Please enter the weight in Pounds: ");
            }

            weight = Convert.ToDouble(Console.ReadLine());
            return weight;
        }

        public double GetHeight()
        {
            if (SelectedUnit == METRIC)
            {
                Console.WriteLine("Please enter the height in CMs: ");
            }
            else
            {
                Console.WriteLine("Please enter the height in Feet: ");
                Console.WriteLine("Please enter the height in Inches: ");
            }
            height = Convert.ToDouble(Console.ReadLine());
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
            Console.WriteLine(SelectedUnit + " " + bmiResults);
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
