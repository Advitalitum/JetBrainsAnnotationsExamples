using System;
using JetBrains.Annotations;

namespace ContractAnnotation
{
	internal class Program
	{
		private static void Main()
		{
			var nullString = GenerateString();

			if (StringIsNotNull(nullString))
			{
				Console.WriteLine(nullString.Length);
			}

			//ThrowExceptionWhenNull(nullString);
			//var length = nullString.Length;
			//Console.WriteLine(length);

			Console.WriteLine("End");
			Console.ReadLine();
		}

		[CanBeNull]
		private static string GenerateString() => new Random().Next() % 2 == 0 ? string.Empty : null;

		//[ContractAnnotation("null => false")]
		private static bool StringIsNotNull([CanBeNull] string parameter) => !(parameter is null);

		//[ContractAnnotation("null => stop")]
		private static void ThrowExceptionWhenNull([CanBeNull] string parameter)
		{
			if (parameter is null)
			{
				throw new ArgumentNullException(nameof(parameter));
			}
		}
	}
}