/*
 * Program:	Exercise13.cs
 * Author:	Æsc Æðelstan
 * Date:	2019/03/19
 * Purpose:	 (Financial application: compound value) Suppose you save $100 each month
    into a savings account with the annual interest rate 5%. Thus, the monthly inter-
    est rate is 0.05/12 = 0.00417. After the first month, the value in the account
    becomes
    100 * (1 + 0.00417) = 100.417
    After the second month, the value in the account becomes
    (100 + 100.417) * (1 + 0.00417) = 201.252
    After the third month, the value in the account becomes
    (100 + 201.252) * (1 + 0.00417) = 302.507
    and so on.
    Write a program that prompts the user to enter a monthly saving amount and
    displays the account value after the sixth month.
 */

using System;

namespace Exercise13 {
	internal class Exercise13 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter monthly saving amount: ");
			var amount = double.Parse(Console.ReadLine());

			Console.WriteLine($"After 6 months: {calcIntrest(amount, 6)}");
		}

		private static double calcIntrest(double amount, int months) {
			var account                              = 0d;
			for (var i = 0; i < months; i++) account = (100 + account) * (1 + 0.00417);
			return account;
		}
	}
}