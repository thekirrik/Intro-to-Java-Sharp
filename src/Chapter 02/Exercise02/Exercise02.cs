/*
 * Program:	Exercise02.cs
 * Author:	Æsc Æðelstan
 * Date:	2019/03/19
 * Purpose:	(Compute the volume of a cylinder) Write a program that reads in the radius
   and length of a cylinder and computes the area and volume using the following
   formulas:
   area = radius * radius * p
   volume = area * length
   
 */

using System;

namespace Chapter02 {
	internal class Exercise02 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter radius: ");
			var radius = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter length: ");
			var length = double.Parse(Console.ReadLine());

			Console.WriteLine("Area: "   + CalcArea(radius));
			Console.WriteLine("Volume: " + CalcVolume(CalcArea(radius), length));
		}

		private static double CalcArea(double radius) {
			return Math.Pow(radius, 2) * Math.PI;
		}

		private static double CalcVolume(double area, double length) {
			return area * length;
		}
	}
}