namespace exercisesCSharp.easy.methods;

// TODO-RU: Написать метод, который принимает текст и произвольное кол-во символьных аргументов. Метод возвращает текст, который получается добавлением в конец исходного текста(первый аргумент) символьных значений, переданных вторым аргументом методу (on 11/9/2022, 11:44pm)

// TODO-ENG: Write a method that accepts text and an arbitrary number of character arguments. The method returns the text that is obtained by adding to the end of the source text (the first argument) the character values passed as the second argument to the method

public class NewMeaningWord
{
	private static string AddChar(string txt, params char[] symbols)
	{
		// You can use LINQ expression
		// All this can be written in one line
		foreach (var t in symbols) txt += t;
		return txt;
	}


	private static void Main() => Console.WriteLine(AddChar("Road to ", 'G', 'o', 'o', 'g', 'l', 'e'));
}
