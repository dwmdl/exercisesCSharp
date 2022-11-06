namespace exercisesCSharp.easy.methods;

// TODO-Ru: Написать статический метод, аргументом которому передается одномерный символьный массив. В результате вызова метода элементы массива попарно меняются местами : первый - с последним, второй - с предпоследним и т.д. (on 12:46pm, 11/6/2022)

// TODO-ENG: Write a static method that takes a one-dimensional character array as an argument. As a result of calling the method, the elements of the array are swapped in pairs: the first one with the last one, the second one with the penultimate one, and etc.

public class SwapCharArrayElements
{
    private static void SwapElements(char[] array)
    {
        for (var i = 1; i <= array.Length / 2; i++) (array[i - 1], array[^i]) = (array[^i], array[i - 1]);
        foreach (var t in array) Console.Write(t);
    }

    private static void Main()
    {
        char[] symbolsArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k' };
        Console.WriteLine("Array before method call : ");
        foreach (var x in symbolsArray) Console.Write(x);
        Console.WriteLine("\nArray after method call : ");
        SwapElements(symbolsArray);
    }
}

