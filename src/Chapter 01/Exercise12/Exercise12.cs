/*
 * Program: Exercise12.cs
 * Author:  Æsc Æðelstan
 * Date:    2019/03/19
 * Purpose: (Average speed in kilometers) Assume a runner runs 24 miles in 1 hour, 40 minutes,
			and 35 seconds. Write a program that displays the average speed in kilometers per
			hour. (Note that 1 mile is 1.6 kilometers.)
 */

using System;

namespace Exercise12 {
	internal class Exercise12 {
		private static void Main(string[] args) {
			const double runTimeInSeconds = 3875;
			const double miles            = 24;

			// once again i don't really know if this math is right it's 04:03 why am i still doing this???
			Console.WriteLine("Average speed in km/h: " + miles / runTimeInSeconds * 60 * 60 * 1.6);
		}
	}
}