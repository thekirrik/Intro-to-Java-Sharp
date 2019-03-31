/*
 * Program:	Exercise07.cs
 * Date:	2019/03/25
 * Purpose:	(Financial application: monetary units) Modify Listing 2.10, ComputeChange
   .java, to display the nonzero denominations only, using singular words for single
   units such as 1 dollar and 1 penny, and plural words for more than one unit such
   as 2 dollars and 3 pennies.
 */

using System;

namespace Chapter03 {
	class Exercise07 {
		static void Main(string[] args) {
			// recieve the amount
			Console.Write("Enter an amount in double, for example 11.56: ");
			var amount = double.Parse(Console.ReadLine());

			int remainingAmount = (int) (amount * 100);

			// find number of one dollars
			int numberOfDollars = remainingAmount / 100;
			remainingAmount %= 100;

			// find number of quarters
			int numberOfQuarters = remainingAmount / 25;
			remainingAmount %= 25;

			// find number of dimes
			int numberOfDimes = remainingAmount / 10;
			remainingAmount %= 10;

			// find number of nickles
			int numberOfNickels = remainingAmount / 5;
			remainingAmount %= 5;

			// find number of pennies
			int numberOfPennies = remainingAmount;

			Console.WriteLine($"Your amount {amount} consists of");
			if (numberOfDollars != 0) {
				Console.WriteLine(numberOfDollars + (numberOfDollars == 1 ? " dollar" : " dollars"));
			}

			if (numberOfQuarters != 0) {
				Console.WriteLine(numberOfQuarters + (numberOfQuarters == 1 ? " quarter" : " quarters"));
			}

			if (numberOfDimes != 0) {
				Console.WriteLine(numberOfDimes + (numberOfDimes == 1 ? " dime" : " dimes"));
			}

			if (numberOfNickels != 0) {
				Console.WriteLine(numberOfNickels + (numberOfNickels == 1 ? " nickel" : " nickels"));
			}

			if (numberOfPennies != 0) {
				Console.WriteLine(numberOfPennies + (numberOfPennies == 1 ? " penny" : " pennies"));
			}
		}
	}
}