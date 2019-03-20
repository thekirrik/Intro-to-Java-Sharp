/*
 * Program:	Exercise14.cs
 * Author:	Æsc Æðelstan
 * Date:	2019/03/19
 * Purpose:	(Health application: computing BMI) Body Mass Index (BMI) is a measure of
    health on weight. It can be calculated by taking your weight in kilograms and
    dividing by the square of your height in meters. Write a program that prompts the
    user to enter a weight in pounds and height in inches and displays the BMI. Note
    that one pound is 0.45359237 kilograms and one inch is 0.0254 meters.
 */


using System;

namespace Exercise14 {
	internal class Exercise14 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter weight (lbs): ");
			var weight = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter height (in): ");
			var height = double.Parse(Console.ReadLine());

			Console.WriteLine($"BMI: {calculateBMI(weight, height)}");
		}

		private static double calculateBMI(double weight, double height) {
			var convertedWeight = weight * 0.45359237;
			var convertedHeight = height * 0.0254;

			return convertedWeight / Math.Pow(convertedHeight, 2);
		}
	}
}