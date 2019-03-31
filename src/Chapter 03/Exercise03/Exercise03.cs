/*
 * Program:	Exercise03.cs
 * Date:	2019/03/25
 * Purpose:	(Algebra: solve 2 * 2 linear equations) A linear equation can be solved using
   Cramer’s rule given in Programming Exercise 1.13. Write a program that prompts
   the user to enter a, b, c, d, e, and f and displays the result. If ad - bc is 0, report
   that “The equation has no solution.”
 */

using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace Chapter03 {
	class Exercise03 {
		static void Main(string[] args) {
			// ax + by = e | cx + dy = f
			Console.WriteLine("Enter a, b, c, d, e, f: ");
			var    str = Console.ReadLine().Split(" ");
			double a   = double.Parse(str[0]);
			double b   = double.Parse(str[1]);
			double c   = double.Parse(str[2]);
			double d   = double.Parse(str[3]);
			double e   = double.Parse(str[4]);
			double f   = double.Parse(str[5]);

			// Solve the linear equation
			if (a * d - b * c == 0)
				Console.WriteLine("The equation has no solution.");
			else {
				double x = (e * d - b * f) / (a * d - b * c);
				double y = (a * f - e * c) / (a * d - b * c);
				Console.WriteLine("x is " + x + " and y is " + y);
			}
		}
	}
}