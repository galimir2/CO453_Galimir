﻿using System;
using System.Runtime;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;


namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Galimir Bozmarov 11/02/2021
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();

            //DistanceConverter converter = new DistanceConverter();
            //converter.Run();

            BMI calculator = new BMI();
            calculator.PrintHeading();
            calculator.OutputUnit();
            calculator.GetUnit();
            calculator.GetWeight();
            calculator.GetHeight();
            calculator.CalculateBMI();
            calculator.OutputResult();
            
            
        }

    }
}
