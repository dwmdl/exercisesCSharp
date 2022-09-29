/*
 * Создать двумерный целочисленный массив.
 * Заполнить массив случайными числами
 * Поменять строки и столбцы местами : 1-я строка = 1-й столбец, 2-я строка = 2-м столбцом и т.д.
 */

// Например, если массив состоял из 3стр и 5стлбц, то в итоге получим массив из 5стр и 3стлбц


namespace exercisesCSharp.exercises_1;

internal static class TwoDimensionalReverseArray
{
	private static void Main()
	{
		var rnd = new Random();
		var array = new int[rnd.Next(2, 6), rnd.Next(2, 6)];

		Console.WriteLine("Two-dimensional array before reverse : ");
		for (var i = 0; i < array.GetLength(0); i++)
		{
			for (var j = 0; j < array.GetLength(1); j++)
			{
				array[i, j] = rnd.Next(1, 45);
				Console.Write($"{array[i, j]}\t ");
			}

			Console.WriteLine();
		}

		Console.WriteLine("\nTwo-dimensional array after reverse : ");

		for (var i = 0; i < array.GetLength(1); i++)
		{
			for (var j = 0; j < array.GetLength(0); j++)
			{
				Console.Write($"{array[j, i]}\t");
			}

			Console.WriteLine();
		}
	}
}