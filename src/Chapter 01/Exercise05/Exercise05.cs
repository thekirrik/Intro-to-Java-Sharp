﻿/*
 * Program: Exercise05.cs
 * Date:    2019/03/19
 * Purpose: (Compute expressions) Write a program that displays the result of
                    9.5 X 4.5 - 2.5 X 3
                    -------------------
                        45.5 - 3.5
 */

using System;

namespace Chapter02 {
	internal class Exercise05 {
		private static void Main(string[] args) {
			Console.WriteLine("9.5 X 4.5 - 2.5 X 3");
			Console.WriteLine("------------------- = " + (9.5 * 4.5 - 2.5 * 3) / (45.5 - 3.5));
			Console.WriteLine("    45.5 - 3.5");
		}
	}
}