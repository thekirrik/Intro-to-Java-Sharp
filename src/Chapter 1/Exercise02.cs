/*
 * Program: Exercise02.cs
 * Author:  Æsc Æðelstan
 * Date:    2019/03/19
 * Purpose: (Display five messages) Write a program that displays "Welcome to C#" five times.
 */

using System;

namespace Exercise_2 {
    class Exercise02 {
        static void Main(string[] args) {
	        // prints the same message 5 times
	        for (int i = 0; i < 6; i++) {
		        Console.WriteLine("Welcome to C#");
	        }
        }
    }
}