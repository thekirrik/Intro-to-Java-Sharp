/*
 * Program:	Exercise22.cs
 * Date:	2019/03/19
 * Purpose:	(Financial application: monetary units) Rewrite Listing 2.10, ComputeChange
   .java, to fix the possible loss of accuracy when converting a double value to an
   int value. Enter the input as an integer whose last two digits represent the cents.
   For example, the input 1156 represents 11 dollars and 56 cents.
 */

using System;

namespace Chapter02 {
	class Exercise22 {
		static void Main(string[] args) {
			Console.Write("Enter an amount in integer, for example 1156: ");
			var amount = int.Parse(Console.ReadLine());

			// find the number of one dollars
			var numberOfOneDollars = amount / 100;
			amount = amount % 100;

			// find the number of quarters in the remaining amount
			var numberOfQuarters = amount / 25;
			amount = amount % 25;

			// find the number of dimes in the remaining amount
			var numberOfDimes = amount / 10;
			amount = amount % 10;

			// find the number of nickels in the remaining amount
			var numberOfNickels = amount / 5;
			amount = amount % 5;

			// find the number of pennies in the remaining amount
			var numberOfpennies = amount;

			// display results
			Console.WriteLine($"Your amount {amount} consists of: ");
			Console.WriteLine($"{numberOfOneDollars} dollars");
			Console.WriteLine($"{numberOfQuarters} quarters");
			Console.WriteLine($"{numberOfDimes} dimes");
			Console.WriteLine($"{numberOfNickels} nickels");
			Console.WriteLine($"{numberOfpennies} pennies");
		}
	}
}