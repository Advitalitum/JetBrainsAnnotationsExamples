using System;
using System.Text.RegularExpressions;
using JetBrains.Annotations;

namespace RegexExample
{
	internal class Program
	{
		private static void Main()
		{
			var regex = CreateRegexWithPattern("[a-z]");

			Console.WriteLine(regex.IsMatch("123"));
			Console.WriteLine("End");
			Console.ReadLine();
		}

		private static Regex CreateRegexWithPattern([RegexPattern] string pattern) =>
			new Regex(pattern);
	}
}