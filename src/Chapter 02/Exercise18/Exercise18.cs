/*
 * Program:	Exercise18.cs
 * Date:	2019/03/19
 * Purpose:	(Print a table) Write a program that displays the following table. Cast floating-
    point numbers into integers.
    a	b	pow(a, b)
    1	2	1
    2	3	8
    3	4	81
    4	5	1024
    5	6	15625
 */

using System;

namespace Chapter02 {
	internal class Exercise18 {
		private static void Main(string[] args) {
			Console.WriteLine("a\tb\tpow(a,b)");
			for (var i = 1; i < 6; i++) Console.WriteLine(i + "\t" + (i + 1) + "\t" + Math.Pow(i, i + 1));
		}
	}
}