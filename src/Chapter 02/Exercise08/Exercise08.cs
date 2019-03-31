/*
 * Program:	Exercise08.cs
 * Date:	2019/03/19
 * Purpose:	(Current time) Listing 2.7, ShowCurrentTime.java, gives a program that displays
    the current time in GMT. Revise the program so that it prompts the user to enter
    the time zone offset to GMT and displays the time in the specified time zone.
 */

using System;

namespace Chapter02 {
	internal class Exercise08 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter timezone offset to UTC: ");
			var offset = int.Parse(Console.ReadLine());

			var totalMilliseconds   = DateTimeOffset.Now.ToUnixTimeMilliseconds();
			var currentMilliseconds = totalMilliseconds % 1000;

			var totalSeconds  = totalMilliseconds / 1000;
			var currentSecond = totalSeconds      % 60;

			var totalMinutes   = totalSeconds / 60;
			var currentMinutes = totalMinutes % 60;

			var totalHours  = totalMinutes / 60;
			var currentHour = totalHours   % 24;
			var offsetHour  = currentHour - offset;

			Console.WriteLine("Current Time: " + (offsetHour + ":" + currentMinutes + ":" + currentSecond));
		}
	}
}