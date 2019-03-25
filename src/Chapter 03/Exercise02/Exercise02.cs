/*
 * Program:	Exercise02.cs
 * Author:	Æsc Æðelstan
 * Date:	2019/03/24
 * Purpose:	(Game: add three numbers) The program in Listing 3.1, AdditionQuiz.java, gen-
   erates two integers and prompts the user to enter the sum of these two integers.
   Revise the program to generate three single-digit integers and prompt the user to
   enter the sum of these three integers.
 */

using System;

namespace Chapter03 {
	class Exercise02 {
		static void Main(string[] args) {
			Random rnd = new Random();

			int num1 = rnd.Next(-9, 9);
			int num2 = rnd.Next(-9, 9);
			int num3 = rnd.Next(-9, 9);

			Console.WriteLine($"Enter sum of {num1}, {num2}, and {num3}");

			Console.WriteLine(int.Parse(Console.ReadLine()) == num1 + num2 + num3 ? "Correct!" : "Incorrect!");
		}
	}
}