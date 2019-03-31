/*
 * Program:	Exercise06.cs
 * Date:	2019/03/19
 * Purpose:	 (Sum the digits in an integer) Write a program that reads an integer between 0 and
    1000 and adds all the digits in the integer. For example, if an integer is 932, the
    sum of all its digits is 14.
 */

using System;

namespace Chapter02 {
	internal class Exercise06 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter number: ");
			var num      = Console.ReadLine();
			var numArray = num.ToCharArray();

			var total                         = 0;
			foreach (var c in numArray) total += int.Parse(c.ToString());

			Console.WriteLine("Total: " + total);
		}
	}
}