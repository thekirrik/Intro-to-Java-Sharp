/*
 * Program:	Exercise01
 * Author:	Æsc Æðelstan
 * Date:	2019/03/19
 * Purpose:	 (Convert Celsius to Fahrenheit) Write a program that reads a Celsius degree in
	a double value from the console, then converts it to Fahrenheit and displays the
   result. The formula for the conversion is as follows:
   fahrenheit = (9 / 5) * celsius + 32
 */

using System;

namespace Exercise01 {
	internal class Exercise01 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter temperature in Celsius: ");
			var celsius = double.Parse(Console.ReadLine());
			Console.WriteLine(celsius + " in fahrenheit is " + convertToFahrenheit(celsius));
		}

		private static double convertToFahrenheit(double celsius) {
			return 9d / 5d * celsius + 32;
		}
	}
}