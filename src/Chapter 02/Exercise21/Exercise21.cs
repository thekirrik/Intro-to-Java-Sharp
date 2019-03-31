/*
 * Program:	Exercise21.cs
 * Date:	2019/03/19
 * Purpose:	(Financial application: calculate future investment value) Write a program that
   reads in investment amount, annual interest rate, and number of years, and dis-
   plays the future investment value using the following formula:
   futureInvestmentValue = investmentAmount * (1 + monthlyInterestRate)numberOfYears*12
   For example, if you enter amount 1000, annual interest rate 3.25%, and number
   of years 1, the future investment value is 1032.98.
 */

using System;

namespace Chapter02 {
	class Exercise21 {
		static void Main(string[] args) {
			Console.Write("Enter inverstment amount: ");
			var investmentAmount = double.Parse(Console.ReadLine());

			Console.Write("Enter annual interest rate: ");
			var monthlyInterest = double.Parse(Console.ReadLine());

			Console.Write("Enter number of years: ");
			var years = double.Parse(Console.ReadLine());

			Console.WriteLine(
				$"Accumulated value: {CalculateFutureInvestmentValue(investmentAmount, monthlyInterest, years)}");
		}

		private static double
			CalculateFutureInvestmentValue(double investmentAmount, double monthlyInterest, double years) {
			return investmentAmount * Math.Pow(1 + monthlyInterest, years * 12);
		}
	}
}