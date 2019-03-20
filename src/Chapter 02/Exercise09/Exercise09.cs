/*
 * Program:	Exercise09.cs
 * Author:	Æsc Æðelstan
 * Date:	2019/03/19
 * Purpose:	(Physics: acceleration) Average acceleration is defined as the change of velocity
    divided by the time taken to make the change, as shown in the following formula:
		a = (v1 - v0) / t
    Write a program that prompts the user to enter the starting velocity v0 in meters/
    second, the ending velocity v1 in meters/second, and the time span t in seconds,
    and displays the average acceleration.
 */

using System;

namespace Exercise09 {
	internal class Exercise09 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter starting velocity: ");
			var v0 = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter ending velocity: ");
			var v1 = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter timespan: ");
			var t = double.Parse(Console.ReadLine());

			Console.WriteLine($"Average acceleration: {computeAcceleration(v0, v1, t)}m/s");
		}

		private static double computeAcceleration(double startVelocity, double endVelocity, double timespan) {
			return (endVelocity - startVelocity) / timespan;
		}
	}
}