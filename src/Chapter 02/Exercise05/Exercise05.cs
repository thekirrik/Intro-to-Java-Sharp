/*
 * Program:	Exercise05.cs
 * Date:	2019/03/19
 * Purpose:	(Financial application: calculate tips) Write a program that reads the subtotal
    and the gratuity rate, then computes the gratuity and total. For example, if the
    user enters 10 for subtotal and 15% for gratuity rate, the program displays $1.5
    as gratuity and $11.5 as total.    
 */

using System;

namespace Chapter02 {
	internal class Exercise05 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter subtotal: ");
			var subtotal = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter gratuity: ");
			var gratuity = double.Parse(Console.ReadLine()) / 100d;

			Console.WriteLine("Gratuity: $" + subtotal * gratuity);
			Console.WriteLine("Total: $"    + (subtotal + subtotal * gratuity));
		}
	}
}