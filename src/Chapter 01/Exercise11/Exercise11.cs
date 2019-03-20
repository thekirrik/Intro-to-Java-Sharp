/*
 * Program: Exercise11.cs
 * Author:  Æsc Æðelstan
 * Date:    2019/03/19
 * Purpose: (Population projection) The U.S. Census Bureau projects population based on the following assumptions:
 * 			One birth every 7 seconds
 * 			One death every 13 seconds
 * 			One new immigrant every 45 seconds
 *
 * 			Write a program to display the population for each of the next five years. Assume the current population
 * 			is 312,032,486 and one year has 365 days.
 */

using System;

namespace Exercise11 {
	internal class Exercise11 {
		private static void Main(string[] args) {
			// calculates the total population each year

			// calculates the seconds in a year to make finding the total number of births, deaths,
			// and immigrations easier
			var secondsInYear = 60d * 60d * 24d * 365d;

			// base population we start with
			var population = 312032486d;

			// amount of births each year
			var birthRate = secondsInYear / 7d;

			// amount of deaths each year
			var deathRate = secondsInYear / 13d;

			// amount of immigrations each year
			var immigrationRate = secondsInYear / 45d;

			Console.WriteLine("Year 0: " + population);
			for (double i = 1; i < 6; i++)
				Console.WriteLine("Year " + i + ": " +
				                  (population + i * birthRate - i * deathRate + i * immigrationRate));
		}
	}
}