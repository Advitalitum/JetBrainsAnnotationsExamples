using System;
using System.Collections.Generic;
using System.Linq;

namespace NoEnumerationExample
{
	internal class Program
	{
		private static void Main()
		{
			var enumerable = GetEnumerable();

			CheckNotNull(enumerable);

			var list = enumerable.ToList();
			list.ForEach(Console.WriteLine);

			Console.WriteLine("End");
			Console.ReadLine();
		}

		private static IEnumerable<string> GetEnumerable() => Enumerable.Repeat(Guid.NewGuid().ToString(), 10);

		private static void CheckNotNull(IEnumerable<string> enumerable)
		{
			if (enumerable is null)
				throw new ArgumentNullException(nameof(enumerable));
		}
	}
}