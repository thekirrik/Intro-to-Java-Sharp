/*
 * Program:	Exercise11.cs
 * Date:	2019/03/19
 * Purpose:	(Population projection) Rewrite Programming Exercise 1.11 to prompt the user
    to enter the number of years and displays the population after the number of years.
    Use the hint in Programming Exercise 1.11 for this program. The population
    should be cast into an integer.
 */

using System;

namespace Chapter02 {
	internal class Exercise11 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter number of years: ");
			var years = double.Parse(Console.ReadLine());

			// calculates the seconds in a year to make finding the total number of births, deaths,
			// and immigrations easier
			var secondsInYear = 60 * 60 * 24 * 365;

			// base population we start with
			var population = 312032486;

			// amount of births each year
			var birthRate = secondsInYear / 7;

			// amount of deaths each year
			var deathRate = secondsInYear / 13;

			// amount of immigrations each year
			var immigrationRate = secondsInYear / 45;

			Console.WriteLine("Year 0: " + population);
			for (var i = 1; i <= years; i++)
				Console.WriteLine("Year " + i + ": " +
				                  (population + i * birthRate - i * deathRate + i * immigrationRate));
		}
	}
}