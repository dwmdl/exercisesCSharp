// Написать программу со статическим методом, определяющим позиции, на которых в тексте находится определенный символ. Аргументами методу передаются текст и символ. Результатом метод возвращает целочисленный массив, значения элементов которого - это индексы позиций, на которых символ находится в тексте. Если символ в тексте не встречается, метод возвращает массив из одного элемента, значения которого равно -1. 

namespace exercisesCSharp.string_manipulation;

public static class Entity
{
	private static int[] FindSymbol(string text, char s)
	{
		var temp = "";

		for (var i = 0; i < text.Length; i++)
			if (text[i] == s)
				temp += $"{i}";

		int[] indexes;
		
		if (temp.Length > 0)
		{
			indexes = new int [temp.Length];
			for (var i = 0; i < temp.Length; i++) indexes[i] = temp[i];
		}
		else
			indexes = new int[1];

		return indexes;
	}

	private static void Main()
	{
		const string text = "RimWorld";
		Console.WriteLine("What character do you want to find in the text?");
		var s = Convert.ToChar(Console.ReadLine()!);

		Console.Write("Indexes where the search symbol occurs: ");
		foreach (var t in FindSymbol(text.ToLower(), s))
		{
			Console.Write(t);
		}
	}
}