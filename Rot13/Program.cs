using System;

namespace Rot13
{
	class Program
	{
		private static char[] Alphabets = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

		private const string TestExpected = "grfg";
		private const string Test = "test";
		//private const string SwedishExpected = "Övning";
		static void Main(string[] args)
		{
			var testActual = Rot13(Test);
			//var swedishActual = Rot13(SwedishExpected)
			var isPassed = testActual == TestExpected;
			Console.WriteLine($"Test actual: {testActual}. {nameof(TestExpected)}: {TestExpected}");
		}

		public static string Rot13(string message)
		{
			
		}
	}
}
