/*
 * Program: Exercise04.cs
 * Date:    2019/03/19
 * Purpose: (Print a table) Write a program that displays the following table:
 *
        a       a^2     a^3
	    1       1       1
        2       4       8
        3       9       27
        4       16      64

 */

using System;

namespace Chapter02 {
	internal class Exercise04 {
		private static void Main(string[] args) {
			// prints a table using tabs for spacing consistence.
			Console.WriteLine("a\ta^2\ta^3");
			Console.WriteLine("1\t1\t1");
			Console.WriteLine("2\t4\t8");
			Console.WriteLine("3\t9\t27");
			Console.WriteLine("4\t16\t64");
		}
	}
}