/*
 * Program:	Exercise05.cs
 * Date:	2019/03/25
 * Purpose:	(Find future dates) Write a program that prompts the user to enter an integer for
   today’s day of the week (Sunday is 0, Monday is 1, ..., and Saturday is 6). Also
   prompt the user to enter the number of days after today for a future day and dis-
   play the future day of the week.
 */

using System;

namespace Chapter03 {
	class Exercise05 {
		static void Main(string[] args) {
			string[] DAYSOFWEEK = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

			Console.Write("Enter today's day: ");
			var day = int.Parse(Console.ReadLine());

			Console.Write("Enter the number of days elapsed since today: ");
			var elapsed = int.Parse(Console.ReadLine());

			var newDay = (day + elapsed) % 7;

			Console.WriteLine($"Today is {DAYSOFWEEK[day]} and the future day is {DAYSOFWEEK[newDay]}");
		}
	}
}