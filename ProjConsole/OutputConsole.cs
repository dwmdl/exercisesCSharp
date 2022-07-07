/* DESCRIPTION:
 * 
 */

/* STEPS:
 * 1.  
 */

namespace ProjConsole;

internal static class BubbleSortArrayDemo
{
	private static void Main()
	{
		// symbol variable
		char s;

		// initial symbol array
		char[] symbols = { 'Q', 'Ы', 'a', 'B', 'R', 'A', 'r', 'q', 'b' };

		// displaying array
		Console.WriteLine("Array before sorting :");
		for (var i = 0; i < symbols.Length; i++) Console.WriteLine(symbols[i]);

		// sorting elements in the array
		for (var i = 1; i < symbols.Length; i++)
		{
			// iterating through the elements
			for (int j = 0; j < symbols.Length; j++)
			{
				if (symbols[j] <= symbols[j + 1]) continue;
				s = symbols[j + 1];
				symbols[j + 1] = symbols[j];
				symbols[j] = s;
			}
		}

		// displaying the contents of the array
		Console.WriteLine("Array after sorting");
		for (int i = 0; i < symbols.Length; i++) Console.WriteLine(symbols[i]);
	}
}