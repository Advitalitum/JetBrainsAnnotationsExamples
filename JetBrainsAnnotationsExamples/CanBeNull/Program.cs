using System;
using JetBrains.Annotations;

namespace CanBeNull
{
	internal class Program
	{
		private const string NullString = default(string);

		private static void Main()
		{
			var length = DangerouslyGetLength(NullString);

			Console.WriteLine(length);
			Console.WriteLine("End");
			Console.ReadLine();
		}

		private static int DangerouslyGetLength([NotNull] string parameter) => parameter.Length;
	}
}