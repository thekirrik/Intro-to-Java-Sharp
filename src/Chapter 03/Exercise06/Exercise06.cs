/*
 * Program:	Exercise06.cs
 * Date:	2019/03/25
 * Purpose:	(Health application: BMI) Revise Listing 3.4, ComputeAndInterpretBMI.java, to
   let the user enter weight, feet, and inches. For example, if a person is 5 feet and 10
   inches, you will enter 5 for feet and 10 for inches.
 */

using System;

namespace Chapter03 {
	class Exercise06 {
		static void Main(string[] args) {
			// prompt user to enter weight in pounds
			Console.Write("Enter weight in pounds: ");
			var weight = double.Parse(Console.ReadLine());

			// prompt user to enter feet
			Console.Write("Enter feet: ");
			var feet = int.Parse(Console.ReadLine());

			// prompt user to enter inches
			Console.Write("Enter inches: ");
			var inches = int.Parse(Console.ReadLine());

			// DO NOT CHANGE
			double KILOGRAMS_PER_POUND = 0.45359237; // CONSTANT
			double METERS_PER_INCH     = 0.0254;     // CONSTANT

			// compute BMI
			weight *= KILOGRAMS_PER_POUND;
			double height = (feet * 12 + inches) * METERS_PER_INCH;
			double bmi    = weight               / Math.Pow(height, 2);

			// display results
			Console.WriteLine($"BMI is {bmi}.");
			if (bmi < 18.5) {
				Console.WriteLine("Underweight");
			} else if (bmi < 25) {
				Console.WriteLine("Normal");
			} else if (bmi < 30) {
				Console.WriteLine("Overweight");
			} else {
				Console.WriteLine("Obese");
			}
		}
	}
}