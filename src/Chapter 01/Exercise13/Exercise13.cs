/*
 * Program: Exercise13.cs
 * Author:  Æsc Æðelstan
 * Date:    2019/03/19
 * Purpose: (Algebra: solve 2 X 2 linear equations) You can use Cramer's rule to solve the following
 * 			2 X 2 system of linear equation:
 *
			ax + by = e		cx + dy = f
			x = (ed - bf) / (ad - bc)	y = (af - ec) / (ad - bc)
			
			Write a program that solves the following equation and displayes the value of x and y:
			3.4x + 50.2y = 44.5
			2.1x + 0.55y = 5.9
 */

using System;

namespace Chapter02 {
	internal class Exercise13 {
		private static void Main(string[] args) {
			// uses Cramer's rule to solve for x and y 

			const double a = 3.4;
			const double b = 50.2;
			const double c = 2.1;
			const double d = 0.55;
			const double e = 44.5;
			const double f = 5.9;
			double       x, y;

			Console.WriteLine(a + "x + " + b + "y = "     + e);
			Console.WriteLine(c + "x + " + d + "y = " + f + "\n");

			Console.WriteLine("Cramer's Rule:");
			x = (e * d - b * f) / (a * d - b * c);
			Console.WriteLine("x = " + x);
			y = (a * f - e * c) / (a * d - b * c);
			Console.WriteLine("y = " + y);
		}
	}
}