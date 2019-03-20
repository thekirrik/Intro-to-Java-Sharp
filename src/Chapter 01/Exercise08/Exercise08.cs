/*
 * Program: Exercise08.cs
 * Author:  Æsc Æðelstan
 * Date:    2019/03/19
 * Purpose: (Area and perimeter of a circle) Write a program that displays the area and perimeter of a circle that
 * 			has a readius of 5.5 using the following formula:
 
			perimeter = 2 * radius * π
			area = radius * radius * π
   
 */

using System;

namespace Exercise08 {
	internal class Exercise08 {
		private static void Main(string[] args) {
			// calculates the perimeter and area of a circle using Math.PI and Math.Pow
			const double radius = 5.5d;

			Console.WriteLine("Perimeter: " + 2 * radius          * Math.PI);
			Console.WriteLine("Area: "      + Math.Pow(radius, 2) * Math.PI);
		}
	}
}