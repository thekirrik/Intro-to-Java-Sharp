/*
 * Program:	Exercise19.cs
 * Date:	2019/03/19
 * Purpose:	(Geometry: area of a triangle) Write a program that prompts the user to enter
   three points (x1, y1), (x2, y2), (x3, y3) of a triangle and displays its area.
   The formula for computing the area of a triangle is
   s = (side1 + side2 + side3) / 2
   area = sqrt(s(s - side1)(s - side2)(s - side3))
 */

using System;

namespace Chapter02 {
	class Exercise19 {
		static void Main(string[] args) {
			Exercise15 e = new Exercise15();
			Console.Write("Enter points (x1, y1, x2, y2, x3, y3): ");
			var nums = Console.ReadLine().Split(" ");

			double side1 = Exercise15.CalcDistance(double.Parse(nums[0]), double.Parse(nums[2]), double.Parse(nums[1]),
			                                       double.Parse(nums[3]));
			double side2 = Exercise15.CalcDistance(double.Parse(nums[2]), double.Parse(nums[4]), double.Parse(nums[3]),
			                                       double.Parse(nums[5]));
			double side3 = Exercise15.CalcDistance(double.Parse(nums[0]), double.Parse(nums[2]), double.Parse(nums[3]),
			                                       double.Parse(nums[5]));

			Console.WriteLine($"Area: {calcArea(side1, side2, side3)}");
		}

		private static double calcArea(double side1, double side2, double side3) {
			double s = (side1 + side2 + side3) / 2;
			return Math.Sqrt(s                 * ((s - side1) * (s - side2) * (s - side3)));
		}
	}
}