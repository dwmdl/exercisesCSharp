namespace exercisesCSharp.string_manipulation;

public static class FindPositions
{
	// This method takes a string and a character as parameters and returns an array of integers
	private static int[] FindSymbol(string text, char c)
	{
		// Create a list to store the positions of the character in the string
		var positions = new List<int>();

		// Loop through each character in the string
		for (var i = 0; i < text.Length; i++)
			if (text[i] == c)
				positions.Add(i);

		// If only one position was found, add -1 to the list
		if (positions.Count == 0) positions.Add(-1);
		return positions.ToArray();
	}

	private static void Main()
	{
		const string text = "RimWorld";
		Console.WriteLine("What character do you want to find?");
		var c = Convert.ToChar(Console.ReadLine()!);

		int[] positions = FindSymbol(text.ToLower(), c);
		Console.WriteLine(positions is [-1]
			? $"The character '{c}' wasn't found in the text: {positions[0]}"
			: $"The character '{c}' was found at positions: {String.Join(", ", positions)}");
	}
}