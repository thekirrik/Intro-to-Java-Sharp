/*
 * Program:	Exercise03.cs
 * Author:	Æsc Æðelstan
 * Date:	2019/03/19
 * Purpose:	(Convert feet into meters) Write a program that reads a number in feet, converts it
   to meters, and displays the result. One foot is 0.305 meter.
 */

using System;

namespace Exercise03 {
	internal class Exercise03 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter number of feet: ");
			var feet = double.Parse(Console.ReadLine());

			Console.WriteLine(feet + "ft is " + convertToMeters(feet) + "m");
		}

		private static double convertToMeters(double feet) {
			return feet * 0.305;
		}
	}
}