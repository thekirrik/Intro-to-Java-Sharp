/*
 * Program:	Exercise22.cs
 * Date:	2019/03/19
 * Purpose:	(Cost of driving) Write a program that prompts the user to enter the distance to
   drive, the fuel efficiency of the car in miles per gallon, and the price per gallon,
   and displays the cost of the trip.
 */

using System;

namespace Chapter02 {
	class Exercise23 {
		static void Main(string[] args) {
			Console.Write("Enter distance of trip (miles): ");
			var distance = double.Parse(Console.ReadLine());

			Console.Write("Enter fuelefficiency (mpg): ");
			var fuelEfficiency = double.Parse(Console.ReadLine());

			Console.Write("Enter price/gallon: ");
			var pricePerGallon = double.Parse(Console.ReadLine());

			Console.WriteLine($"Cost of driving: {CalculateTripCost(distance, fuelEfficiency, pricePerGallon)}");
		}

		private static double CalculateTripCost(double distance, double fuelEfficiency, double pricePerGallon) {
			return (distance / fuelEfficiency) * pricePerGallon;
		}
	}
}