/*
 * Program:	Exercise10.cs
 * Date:	2019/03/30
 * Purpose:	(Game: addition quiz) Listing 3.3, SubtractionQuiz.java, randomly generates a
   subtraction question. Revise the program to randomly generate an addition question with two integers less than 100.
 */

using System;

namespace Chapter03 {
	class Exercise10 {
		static void Main(string[] args) {
			Random random = new Random();
			int    num1   = random.Next(1, 100);
			int    num2   = random.Next(1, 100);

			Console.Write($"What is {num1} - {num2}?: ");

			if (int.Parse(Console.ReadLine()) == (num1 - num2)) {
				Console.WriteLine("Correct!");
			} else {
				Console.WriteLine("Wrong");
				Console.WriteLine($"The correct answer is {num1 - num2}");
			}
		}
	}
}