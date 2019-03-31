/*
 * Program:	Exercise11.cs
 * Date:	2019/03/30
 * Purpose:	 (Find the number of days in a month) Write a program that prompts the user
   to enter the month and year and displays the number of days in the month. For
   example, if the user entered month 2 and year 2012, the program should display
   that February 2012 had 29 days. If the user entered month 3 and year 2015, the
   program should display that March 2015 had 31 days.
 */

using System;
using System.Globalization;

namespace Chapter03 {
	class Exercise11 {
		static void Main(string[] args) {
			Console.Write("Enter month (MM) and year (YYYY): ");
			var str   = Console.ReadLine();
			int month = int.Parse(str.Split(' ')[0]);
			int year  = int.Parse(str.Split(' ')[1]);

			Console.WriteLine(
				$"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month)} in {year} has {DateTime.DaysInMonth(year, month)} days");
		}
	}
}