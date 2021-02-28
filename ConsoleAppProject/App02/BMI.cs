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

        public string SelectedUnit;

        public string[] MenuChoices = { METRIC, IMPERIAL};


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

        public void OutputResult()
        {
            Console.WriteLine(SelectedUnit);
        }






        private void PrintHeading()
        {
            Console.WriteLine("\n-----------------------");
            Console.WriteLine("\tBMI Calculator");
            Console.WriteLine("\tBy Galimir Bozmarov");
            Console.WriteLine("\n-----------------------");
        }
    }
}
