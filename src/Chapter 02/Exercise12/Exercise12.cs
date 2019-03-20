/*
 * Program:	Exercise12.cs
 * Author:	Æsc Æðelstan
 * Date:	2019/03/19
 * Purpose:	(Physics: finding runway length) Given an airplane’s acceleration a and take-off
    speed v, you can compute the minimum runway length needed for an airplane to
    take off using the following formula:
		length = v2/2a
    Write a program that prompts the user to enter v in meters/second (m/s) and the
    acceleration a in meters/second squared (m/s2), and displays the minimum run-
    way length.
 */

using System;

namespace Exercise12 {
	internal class Exercise12 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter velocity (meters/second): ");
			var v = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter acceleration (meters/second squared): ");
			var a = double.Parse(Console.ReadLine());

			Console.WriteLine($"Minimum Runway Length: {calcMinRunwayLength(v, a)}");
		}

		private static double calcMinRunwayLength(double v, double a) {
			return Math.Pow(v, 2) / (2 * a);
		}
	}
}