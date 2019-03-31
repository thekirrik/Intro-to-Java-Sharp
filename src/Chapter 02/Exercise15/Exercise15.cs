/*
 * Program:	Exercise15.cs
 * Date:	2019/03/19
 * Purpose:	(Geometry: distance of two points) Write a program that prompts the user to enter
    two points (x1, y1) and (x2, y2) and displays their distance between them.
    The formula for computing the distance is sqrt((x2 - x1)2 + (y2 - y1)2). Note that
    you can use Math.pow(a, 0.5) to compute 2a.
 */


using System;

namespace Chapter02 {
	public class Exercise15 {
		private static void Main(string[] args) {
			Console.Write("Enter x1 & y1: ");
			var str = Console.ReadLine();
			var x1  = double.Parse(str.Split(' ')[0]);
			var y1  = double.Parse(str.Split(' ')[1]);

			Console.Write("Enter x2 & y2: ");
			str = Console.ReadLine();
			var x2 = double.Parse(str.Split(' ')[0]);
			var y2 = double.Parse(str.Split(' ')[1]);

			Console.WriteLine($"Distance between points: {CalcDistance(x1, x2, y1, y2)}");
		}

		public static double CalcDistance(double x1, double x2, double y1, double y2) {
			return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
		}
	}
}