/*
 * Create a 2D numeric array
 * An array should be filled with a spiral :
	* First row first (left to right)
	* Then the last column (from top to bottom)
	* Last row (from right to left), etc.
*/


/*
 * Instead of n, you can use the dimension of the array, but this way the code is longer
 * n / 2, because full turns of the matrix will turn out to be two times less than the dimension itself
 */

namespace exercisesCSharp.exercises_1;

public static class SpiralAlgorithm
{
	private static void Main()
	{
		var array = new int[6, 6];
		var number = 1;

		const int n = 6;

		// algorithm for filling a 2D array in a spiral
		for (var i = 0; i < n / 2; i++)
		{
			for (int j = i; j < n - i; j++) array[i, j] = number++;
			for (int k = i + 1; k < n - i; k++) array[k, n - 1 - i] = number++;
			for (int j = n - i - 2; j >= i; j--) array[n - 1 - i, j] = number++;
			for (int k = n - 2 - i; k > i; k--) array[k, i] = number++;
		}

		for (var i = 0; i < array.GetLength(0); i++)
		{
			for (var j = 0; j < array.GetLength(1); j++)
			{
				Console.Write($"{array[i, j]}\t");
			}

			Console.WriteLine();
		}
	}
}