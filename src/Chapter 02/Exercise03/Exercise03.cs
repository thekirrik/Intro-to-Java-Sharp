/*
 * Program:	Exercise03.cs
 * Date:	2019/03/19
 * Purpose:	(Convert feet into meters) Write a program that reads a number in feet, converts it
   to meters, and displays the result. One foot is 0.305 meter.
 */

using System;

namespace Chapter02 {
	internal class Exercise03 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter number of feet: ");
			var feet = double.Parse(Console.ReadLine());

			Console.WriteLine(feet + "ft is " + ConvertToMeters(feet) + "m");
		}

		private static double ConvertToMeters(double feet) {
			return feet * 0.305;
		}
	}
}