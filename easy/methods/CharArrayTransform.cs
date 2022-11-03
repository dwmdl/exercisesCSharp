namespace exercisesCSharp.easy.methods;

public class CharArrayTransform
{
    // TODO-ENG: Write a program with a static method, the argument to which is a character array, and the result is a reference to an integer array, consisting of the character codes of the argument array (on 10/31/2022, 7:11pm)
    
    // TODO-RU: Напишите программу со статическим методом, аргументом которого является массив символов, а результатом является ссылка на целочисленный массив, состоящий из кодов символов массива-аргумента.

    private static void ArrayTransform(char[] array)
    {
        var integerArray = new int[array.Length];
        for (var i = 0; i < array.Length; i++) Console.Write($"{integerArray[i] = array[i]}, ");
    }

    private static void Main()
    {
        char[] symbolsArray = { 'a', 'b', 'C', 'D', 'E', 'f', 'g' };
        Console.WriteLine("Character array before function call:");
        foreach (var r in symbolsArray) Console.Write($"{r}, ");
        Console.WriteLine("\nCharacter array after function call: ");
        ArrayTransform(symbolsArray);
    }
}