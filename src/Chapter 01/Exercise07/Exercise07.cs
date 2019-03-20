/*
 * Program: Exercise07.cs
 * Author:  Æsc Æðelstan
 * Date:    2019/03/19
 * Purpose: (Approximate π) π can be computed using the following formula:
 * 				 
 * 			π = 4 X ( 1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + ...)
 * 			Write a program to display the result of 4 X ( 1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11)
 * 			and 4 X ( 1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13). Use 1.0 instead of 1 in your program
 */

using System;

namespace Exercise07 {
	internal class Exercise07 {
		private static void Main(string[] args) {
			// calculates pi
			Console.WriteLine("4 X ( 1 - 1 /3 + 1 /5 - 1 /7 + 1 /9 - 1 /11) = "
			                + 4f * (1f - 1f / 3f + 1f / 5f - 1f / 7f + 1f / 9f - 1f / 11f));
			Console.WriteLine("4 X ( 1 - 1 /3 + 1 /5 - 1 /7 + 1 /9 - 1 /11 + 1/13) = "
			                + 4f * (1f - 1f / 3f + 1f / 5f - 1f / 7f + 1f / 9f - 1f / 11f + 1f / 13f));
		}
	}
}