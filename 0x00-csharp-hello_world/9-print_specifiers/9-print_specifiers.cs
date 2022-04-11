﻿using System;
using System.Globalization;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine("Percent: {0}\nCurrency: {1}", percent.ToString("0.00%"), currency.ToString("C2", CultureInfo.CreateSpecificCulture("en-US.utf-8")));
	}
}
