/*
 * Program:	Exercise08.cs
 * Date:	2019/03/29
 * Purpose:	(Sort three integers) Write a program that prompts the user to enter three integers
   and display the integers in non-decreasing order.
 */

using System;

namespace Chapter03 {
	class Exercise08 {
		static void Main(string[] args) {
			Console.Write("Enter three integers: ");
			var   nums     = Console.ReadLine();
			int[] numArray = new int[3];

			for (int i = 0; i < numArray.Length; i++) {
				numArray[i] = int.Parse(nums.Split(' ')[i]);
			}

			Array.Sort(numArray);

			Console.WriteLine($"Ascending Order: {numArray[0]}, {numArray[1]}, {numArray[2]}");
		}
	}
}