/*
 * Создать символьный массив.
 * Заполнить массив случайными символами
 * Поменять порядок массива на обратный 
 */


namespace ProjConsole;

internal static class ReverseArray
{
	private static void Main()
	{
		var rnd = new Random();
		var array = new char[rnd.Next(1, 12)];

		for (var i = 0; i < array.Length; i++)
		{
			array[i] = (char)rnd.Next(65, 90);
			Console.Write($"{array[i]}, ");
		}

		Console.WriteLine();

		for (var i = 1; i < array.Length + 1; i++) Console.Write($"{array[^i]}, ");
	}
}