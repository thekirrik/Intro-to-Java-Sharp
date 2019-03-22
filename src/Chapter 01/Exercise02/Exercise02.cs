/*
 * Program: Exercise02.cs
 * Author:  Æsc Æðelstan
 * Date:    2019/03/19
 * Purpose: (Display five messages) Write a program that displays "Welcome to C#" five times.
 */

using System;

namespace Chapter02 {
	internal class Exercise02 {
		private static void Main(string[] args) {
			// prints the same message 5 times
			for (var i = 0; i < 6; i++) Console.WriteLine("Welcome to C#");
		}
	}
}