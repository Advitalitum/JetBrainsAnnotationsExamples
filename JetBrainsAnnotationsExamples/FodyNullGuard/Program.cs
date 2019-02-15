using System;
using JetBrains.Annotations;
using NullGuard;

namespace FodyNullGuard
{
	[NullGuard(ValidationFlags.All)]
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

		private static int DangerouslyGetLength([CanBeNull] string parameter) => parameter?.Length ?? int.MinValue;
	}
}