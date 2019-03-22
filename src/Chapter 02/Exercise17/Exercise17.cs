/*
 * Program:	Exercise17.cs
 * Author:	Æsc Æðelstan
 * Date:	2019/03/19
 * Purpose:	(Science: wind-chill temperature) How cold is it outside? The temperature alone
    is not enough to provide the answer. Other factors including wind speed, rela-
    tive humidity, and sunshine play important roles in determining coldness outside.
    In 2001, the National Weather Service (NWS) implemented the new wind-chill
    temperature to measure the coldness using temperature and wind speed. The
    formula is
    twc = 34.74 + 0.6215ta - 35.75v^0.16 + 0.4275taV^0.16
    where t a is the outside temperature measured in degrees Fahrenheit and v is the
    speed measured in miles per hour. t wc is the wind-chill temperature. The formula
    cannot be used for wind speeds below 2 mph or temperatures below -58 oF or
    above 41oF.
    Write a program that prompts the user to enter a temperature between -58 oF and
    41oF and a wind speed greater than or equal to 2 and displays the wind-chill tem-
    perature. Use Math.pow(a, b) to compute v0.16.
 */

using System;

namespace Chapter02 {
	internal class Exercise17 {
		private static void Main(string[] args) {
			Console.WriteLine("Enter temperature (F) between -58 and 41: ");
			var temp = double.Parse(Console.ReadLine());
			while (temp < -58 || temp > 41) {
				Console.WriteLine("Temperature is out of range (-58 to 41). Try again: ");
				temp = double.Parse(Console.ReadLine());
			}

			Console.WriteLine("Enter windspeed (mi) >= 2: ");
			var speed = double.Parse(Console.ReadLine());
			while (speed < 2) {
				Console.WriteLine("Windspeed is out of range (>=2). Try again: ");
				speed = double.Parse(Console.ReadLine());
			}


			Console.WriteLine($"Windchill: {calcWindchill(speed, temp)}");
		}

		private static double calcWindchill(double speed, double temp) {
			return 35.74 + 0.6215 * temp - 35.75 * Math.Pow(speed, 0.16) +
			       0.4275 * temp * Math.Pow(speed, 0.16);
		}
	}
}