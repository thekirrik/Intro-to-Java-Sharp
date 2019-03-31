/*
 * Program:	Exercise01
 * Date:	2019/03/19
 * Purpose:	(Convert Celsius to Fahrenheit) Write a program that reads a Celsius degree in
	a double value from the console, then converts it to Fahrenheit and displays the
   result. The formula for the conversion is as follows:
   fahrenheit = (9 / 5) * celsius + 32
 */

using System;

namespace Chapter02 {
	internal class Exercise01 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter temperature in Celsius: ");
			var celsius = double.Parse(Console.ReadLine());
			Console.WriteLine(celsius + " in fahrenheit is " + ConvertToFahrenheit(celsius));
		}

		private static double ConvertToFahrenheit(double celsius) {
			return 9d / 5d * celsius + 32;
		}
	}
}