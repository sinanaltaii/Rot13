using System;

namespace Rot13
{
	class Program
	{
		private static char[] Alphabets = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

		private const string TestExpected = "Grfg";
		private const string Test = "Test";
		private const int Position = 13;
		//private const string SwedishExpected = "Övning";
		
		static void Main(string[] args)
		{
			var testActual = Rot13(Test);
			Console.WriteLine($"Test actual: {testActual}. {nameof(TestExpected)}: {TestExpected}");
		}

		public static string Rot13(string message)
		{
			var hashed = new char[message.Length];
			char charInAlphabets;
			for (var i = 0; i < message.Length; i++)
			{
				var inputCharValue = message[i];
				for (var k = 0; k <Alphabets.Length; k++)
				{
					charInAlphabets = Alphabets[k];
					bool isLower = char.IsLower(inputCharValue);
					if (charInAlphabets.Equals(char.ToLower(inputCharValue)))
					{
						var charIndex = k;
						if (k <= 12)
						{
							var newPostion = charIndex + Position;
							hashed[i] = isLower == false ?  char.ToUpper(Alphabets[newPostion]) : Alphabets[newPostion];
							break;
						}
						else
						{
							var congurent = charIndex % Position;
							hashed[i] = isLower == false ? char.ToUpper(Alphabets[congurent]) : Alphabets[congurent];
							break;
						}
					}
				}
			}
			var hashedValue = new string(hashed);

			return hashedValue;
		}
	}
}
