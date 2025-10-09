/*
 
Desc: Write a program to calculate the total number of dragon hatchlings in a magical hatchery, based on exponential egg-laying growth
Author: Albara Awad
Date: Oct 10, 2025
 
 
 
 */




using System;

namespace Arithmetic_Expressions_Awad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start the simulation
            Console.WriteLine("Welcome to the Dragon Hatchery Simulator!");

            //Ask for the starting number of dragons
            Console.Write("Enter the initial number of dragons: ");
            int initialDragons = int.Parse(Console.ReadLine());

            //Ask for the daily growth rate in percent
            Console.Write("Enter the daily growth rate (%): ");
            double growthRatePercent = double.Parse(Console.ReadLine());

            //Ask for how many weeks have passed
            Console.Write("Enter the number of weeks: ");
            int numberOfWeeks = int.Parse(Console.ReadLine());

            //Convert percentage to decimal
            double growthRateDecimal = growthRatePercent / 100.0;

            // Convert weeks to days
            int totalDays = numberOfWeeks * 7;

            //Calculate the total number of dragons
            double totalDragons = initialDragons * Math.Pow(1 + growthRateDecimal, totalDays);

            //Round to the nearest whole number
            int roundedTotal = (int)Math.Round(totalDragons);

            //Announce the final count to the realm!
            Console.WriteLine("There will be about " + roundedTotal + " dragons after " + totalDays + " days.");
        }
    }
}
