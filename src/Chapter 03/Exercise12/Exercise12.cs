/*
 * Program:	Exercise12.cs
 * Date:	2019/03/31
 * Purpose:	(Palindrome number) Write a program that prompts the user to enter a three-digit
   integer and determines whether it is a palindrome number. A number is palindrome if it
   reads the same from right to left and from left to right.
 */

using System;
using System.Linq;

namespace Chapter03 {
	class Exercise12 {
		static void Main(string[] args) {
			Console.Write("Enter a number: ");
			var str = Console.ReadLine();

			if (str.SequenceEqual(str.Reverse())) {
				Console.WriteLine($"{str} is a palindrome");
			} else {
				Console.WriteLine($"{str} is not a palindrome");
			}
		}
	}
}