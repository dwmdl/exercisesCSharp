/*
 * Создать и инициализировать двумерный числовой массив.
 * После, из созданного массива удаляется одна строка и столбец.
	* Создается новый массив,в котором по сравнению с исходным удалена одна строка и столбец.
	* Индекс удаляемой строки и удялемого столбца определяется с помощью генератора случайных чисел
 */


namespace ProjConsole;

internal static class DeleteRowAndColFrom2DArray
{
	private static void Main()
	{
		var rnd = new Random();
		var array = new int[7, 3];
		
		// indexes of the column and row to be deleted, randomly generated
		int rowToRemove = rnd.Next(0, 7);
		int columnToRemove = rnd.Next(0, 3);
		
		// new array that is one row and one column smaller than original 
		var result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
		
		// filling the array with random numbers
		Console.WriteLine("Array before edit : ");
		for (var i = 0; i < array.GetLength(0); i++)
		{
			for (var j = 0; j < array.GetLength(1); j++)
			{
				array[i, j] = rnd.Next(1, 101);
				Console.Write($"{array[i, j]}\t");
			}

			Console.WriteLine();
		}

		Console.WriteLine($"\nArray after deleted {rowToRemove + 1}-row and {columnToRemove + 1}-column : ");
		
		/*
		 * Если индекс удаляемой строки и столбца совпадает с i или k, то итерация пропускается
		 * Соответственно, не выводится сначала одно число, потом второе и т.д.
		 * Пока не получится так, что отсутсвует целая строка и целый столбец 
		 */ 
		
		for (var i = 0; i < array.GetLength(0); i++)
		{
			if (i == rowToRemove) continue;
			for (var k = 0; k < array.GetLength(1); k++)
			{
				if (k == columnToRemove) continue;
				Console.Write($"{array[i, k]}\t");
			}
			
			Console.WriteLine();
		}
	}
}