// TODO-RU: Написать программу, в которой есть статический метод, возвращающий результатом текстовое значение и получающий аргументом текст. Результат метода - переданный аргументом текст, в котором слова следуют в обратном порядке. Словами считать блоки текста разделенные пробелами.

// TODO-EN: Write a program that has a static method that returns a text value as a result and receives text as an argument. The result of the method is the text passed as an argument, in which the words follow in reverse order. Words are blocks of text separated by spaces.

namespace exercisesCSharp;

public static class ReverseWords
{
	private static void Reverse(string txt)
	{
		string[] reverseTxt = txt.Split(' ');
		for (var i = 1; i < reverseTxt.Length + 1; i++) Console.WriteLine(reverseTxt[^i]);
	}
	
	
	private static void Main() => Reverse("How it is going?");
}