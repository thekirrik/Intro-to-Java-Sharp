/*
 * Program:	Exercise04.cs
 * Date:	2019/03/19
 * Purpose:	(Convert pounds into kilograms) Write a program that converts pounds into kilo-
   grams. The program prompts the user to enter a number in pounds, converts it
   to kilograms, and displays the result. One pound is 0.454 kilograms.
 */

using System;

namespace Chapter02 {
	internal class Exercise04 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter pounds: ");
			var pounds = double.Parse(Console.ReadLine());

			Console.WriteLine(pounds + "lbs is " + convertToKilograms(pounds) + "kg");
		}

		private static double convertToKilograms(double pounds) {
			return pounds * 0.454;
		}
	}
}