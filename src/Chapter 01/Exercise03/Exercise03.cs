﻿/*
 * Program: Exercise03.cs
 * Date:    2019/03/19
 * Purpose: (Display a pattern) Write a program that displays the following pattern:
 *
     	   _____     _  _   
		 / ____|   | || |_ 
		| |      |_  __  _|
		| |       _| || |_ 
        | |___   |_  __  _|
         \_____|   |_||_|  
                 
                 
 */

using System;

namespace Chapter02 {
	internal class Exercise03 {
		private static void Main(string[] args) {
			// prints out ascii art
			Console.Write(
				"    _____     _  _   \n  / ____|   | || |_ \n | |      |_  __  _|\n | |       _| || |_ \n | |___   |_  __  _|\n  \\_____|   |_||_|  \n                 \n                 ");
		}
	}
}