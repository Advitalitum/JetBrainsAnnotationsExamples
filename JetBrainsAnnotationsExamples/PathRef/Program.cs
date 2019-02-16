using System;
using System.IO;
using JetBrains.Annotations;

namespace PathRef
{
	internal class Program
	{
		private static void Main()
		{
			var fileContent = ReadFileContent("SomeFile.file");

			Console.WriteLine(fileContent);
			Console.WriteLine("End");
			Console.ReadLine();
		}

		private static string ReadFileContent([PathReference] string path)
			=> File.ReadAllText(path);
	}
}