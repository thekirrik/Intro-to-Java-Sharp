/*
 * Program:	Exercise20.cs
 * Author:	Æsc Æðelstan
 * Date:	2019/03/19
 * Purpose:	 (Financial application: calculate interest) If you know the balance and the annual
   percentage interest rate, you can compute the interest on the next monthly pay-
   ment using the following formula:
   interest = balance * (annualInterestRate/1200)
   Write a program that reads the balance and the annual percentage interest rate and
   displays the interest for the next month.
   
 */

using System;

namespace Chapter02 {
	class Exercise20 {
		static void Main(string[] args) {
			Console.Write("Enter balance: ");
			var balance = double.Parse(Console.ReadLine());

			Console.Write("Enter annual percentage interest rate: ");
			var annualInterestRate = double.Parse(Console.ReadLine());

			Console.WriteLine($"Interest: {CalculateInterest(balance, annualInterestRate)}");
		}

		private static double CalculateInterest(double balance, double annualInterestRate) {
			return balance * (annualInterestRate / 1200);
		}
	}
}