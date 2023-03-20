// TODO-RU: Напишите программу, в которой есть статический метод. Аргументом методу передается текстовое значение. Резульатом метод возвращает текст, в котором, по сравнению с аргументом, между символами вставлены пробелы.

// TODO-EN: Write a program that has a static method. A text value is passed as an argument to the method. As a result, the method returns the text, in which, in comparison with the argument, spaces are inserted between the characters.

namespace exercisesCSharp;

public static class ReplaceText
{
	private static void TextSpace(string txt)
	{
		char[] charArray = txt.ToCharArray();
		foreach (char t in charArray) Console.Write($"{t} ");
	}

	private static void Main()
	{
		const string someTxt = "How it is going?";
		Console.WriteLine($"Old text: {someTxt}");
		Console.Write($"New text: ");
		TextSpace(someTxt);
	}
}

