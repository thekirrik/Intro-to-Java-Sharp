/*
 * Program:	Exercise01.cs
 * Author:	Æsc Æðelstan
 * Date:	2019/03/24
 * Purpose:	 (Algebra: solve quadratic equations) The two roots of a quadratic equation
 * 	can be obtained using the following formula:
   r1 = (-b + sqrt(b^2 - 4ac) / (2a) and r2 = (-b - sqrt(b^2 - 4ac) / (2a)
   -b - 4ac is called the discriminant of the quadratic equation. If it is positive, the
   equation has two real roots. If it is zero, the equation has one root. If it is negative,
   the equation has no real roots.
 */

using System;

namespace Chapter03 {
	class Exercise01 {
		static void Main(string[] args) {
			Console.WriteLine("Enter a, b, and c: ");
			var str = Console.ReadLine();
			var a = double.Parse(str.Split(' ')[0]);
			var b = double.Parse(str.Split(' ')[1]);
			var c = double.Parse(str.Split(' ')[2]);

			// calculate the discriminant of the quadratic equation
			var discriminant = Math.Pow(b, 2) - 4 * a * c;
			var answers = CalculateQuadraticEquation(a, b, discriminant);

			if (discriminant > 0) {
				Console.WriteLine($"The equation has tworoots: {answers.Item1} and {answers.Item2}");
			} else if (discriminant == 0) {
				Console.WriteLine($"The equation has one real root: {answers.Item1}");
			} else {
				Console.WriteLine("The equation has no real roots.");
			}
		}

		private static (double, double)CalculateQuadraticEquation(double a, double b, double discriminant) {
			double positiveSolve = (-b + Math.Sqrt(discriminant)) / (2 * a);
			double negativeSolve = (-b - Math.Sqrt(discriminant)) / (2 * a);

			return (positiveSolve, negativeSolve);
		}
	}
}