/*
 * Program:	Exercise10.cs
 * Author:	Æsc Æðelstan
 * Date:	2019/03/19
 * Purpose:	(Science: calculating energy) Write a program that calculates the energy needed
    to heat water from an initial temperature to a final temperature. Your program
    should prompt the user to enter the amount of water in kilograms and the initial
    and final temperatures of the water. The formula to compute the energy is
		Q = M * (finalTemperature – initialTemperature) * 4184
    where M is the weight of water in kilograms, temperatures are in degrees Celsius,
    and energy Q is measured in joules.
 */

using System;

namespace Chapter02 {
	internal class Exercise10 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter weight of water: ");
			var m = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter initial temperature: ");
			var initialTemperature = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter final temperature");
			var finalTemperature = double.Parse(Console.ReadLine());

			Console.WriteLine($"Energy needed: {calculateEnergyNeeded(m, initialTemperature, finalTemperature)}J");
		}

		private static double calculateEnergyNeeded(double m, double initialTemperature,
		                                            double finalTemperature) {
			return m * (finalTemperature - initialTemperature) * 4184d;
		}
	}
}