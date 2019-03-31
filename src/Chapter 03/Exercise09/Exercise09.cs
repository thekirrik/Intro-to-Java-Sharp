/*
 * Program:	Exercise09.cs
 * Date:	2019/03/29
 * Purpose:	(Business: check ISBN-10) An ISBN-10 (International Standard Book Number)
   consists of 10 digits. The last digit, d10, is a checksum,
   which is calculated from the other nine digits using the following formula:
   (d1 * 1 + d2 * 2 + d3 * 3 + d4 * 4 + d5 * 5 +
   d6 * 6 + d7 * 7 + d8 * 8 + d9 * 9) % 11
   If the checksum is 10, the last digit is denoted as X according to the ISBN-10
   convention. Write a program that prompts the user to enter the first 9 digits and
   displays the 10-digit ISBN (including leading zeros). Your program should read
   the input as an integer.
 */

using System;

namespace Chapter03 {
	class Exercise09 {
		static void Main(string[] args) {
			Console.Write("Enter the first 9 digits of an ISBN as integer: ");
			var nine = Console.ReadLine();

			Console.WriteLine($"The ISBN-10 number is {nine}{CalculateISBNChecksum(nine)}");
		}

		private static char CalculateISBNChecksum(string isbn) {
			int check = 0;
			for (int i = 1; i <= 9; i++) {
				check += (int.Parse(isbn[i - 1].ToString()) * i);
			}

			check %= 11;

			switch (check) {
				case 10:
					return 'X';
				default:
					return char.Parse(check.ToString());
			}
		}
	}
}