namespace exercisesCSharp;

public static class StringEquals
{
	private static bool AreStringEqual(string firstString, string secondString)
	{
		// create a set of characters for the first string
		var firstSet = new HashSet<char>(firstString);

		// create a set of characters for the second string
		var secondSet = new HashSet<char>(secondString);

		return firstSet.SetEquals(secondSet);
	}


	private static void Main()
	{
		var firstString = "Hello, World!";
		var secondString = "World, Hello";

		Console.WriteLine(AreStringEqual(firstString, secondString)
			? "The string are equals"
			: "The string aren't equals");
	}
}