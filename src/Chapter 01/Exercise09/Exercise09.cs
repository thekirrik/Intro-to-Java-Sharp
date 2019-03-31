/*
 * Program: Exercise09.cs
 * Date:    2019/03/19
 * Purpose: (Area and perimeter of a rectangle) Write a program that displays the area and perimeter of a rectangle=
		with the width of 4.5 and the height of 7.9 using the following formula:
		area = width X height
 */

using System;

namespace Chapter03 {
	internal class Exercise09 {
		private static void Main(string[] args) {
			const double height = 7.9;
			const double width  = 4.5;

			Console.WriteLine("Area: " + width * height);
		}
	}
}