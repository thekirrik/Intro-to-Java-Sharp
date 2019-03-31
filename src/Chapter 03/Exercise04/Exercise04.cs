﻿/*
 * Program:	Exercise04.cs
 * Date:	2019/03/25
 * Purpose:	(Random month) Write a program that randomly generates an integer between 1
   and 12 and displays the English month name January, February, ..., December for
   the number 1, 2, ..., 12, accordingly.
 */

using System;

namespace Chapter03 {
	class Exercise04 {
		static void Main(string[] args) {
			Console.Write("Enter month number: ");
			var month = int.Parse(Console.ReadLine());

			switch (month) {
				case 1:
					Console.WriteLine("January");
					break;
				case 2:
					Console.WriteLine("February");
					break;
				case 3:
					Console.WriteLine("March");
					break;
				case 4:
					Console.WriteLine("April");
					break;
				case 5:
					Console.WriteLine("May");
					break;
				case 6:
					Console.WriteLine("Jun");
					break;
				case 7:
					Console.WriteLine("July");
					break;
				case 8:
					Console.WriteLine("August");
					break;
				case 9:
					Console.WriteLine("September");
					break;
				case 10:
					Console.WriteLine("October");
					break;
				case 11:
					Console.WriteLine("November");
					break;
				case 12:
					Console.WriteLine("December");
					break;
				default:
					Console.WriteLine("invalid month");
					break;
			}
		}
	}
}