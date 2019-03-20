/*
 * Program:	Exercise07.cs
 * Author:	Æsc Æðelstan
 * Date:	2019/03/19
 * Purpose:	(Find the number of years) Write a program that prompts the user to enter the
    minutes (e.g., 1 billion), and displays the number of years and days for the min-
    utes. For simplicity, assume a year has 365 days.
 */

using System;

namespace Exercise07 {
	internal class Exercise07 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter number of minutes: ");
			var minutes = int.Parse(Console.ReadLine());

			// minutes / minutes in year
			var years = minutes / 525600;

			// minutes % minutes in year / minutes in day
			double days = minutes % 525600 / 1440;

			Console.WriteLine("Total time: " + years + " years " + days + " days");
		}
	}
}