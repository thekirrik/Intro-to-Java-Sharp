/*
 * Program:	Exercise16.cs
 * Date:	2019/03/19
 * Purpose:	(Geometry: area of a hexagon) Write a program that prompts the user to enter the
    side of a hexagon and displays its area. The formula for computing the area of a
    hexagon is Area = ((3sqrt3) / 2) * s2 where s is the length of a side.
 */

using System;

namespace Exercise16 {
	internal class Exercise16 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter length: ");
			var length = double.Parse(Console.ReadLine());

			Console.WriteLine($"Area: {calcArea(length)}");
		}

		private static double calcArea(double length) {
			return 3 * Math.Sqrt(3) / 2 * Math.Pow(length, 2);
		}
	}
}