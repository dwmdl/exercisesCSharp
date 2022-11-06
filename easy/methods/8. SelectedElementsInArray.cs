namespace exercisesCSharp.easy.methods;

// TODO-RU: Написать перегруженный статический метод. Если аргументом методу передается два целых числа, то результатом возвращается ссылка на целочисленный массив, состоящий из натуральных чисел, а первое и последнее число в массиве определяется аргументами метода. Например, если передать аргументами числа 2 и 4 , то результатом будет массив из чисел 2 , 3 и 4 . Также необходимо сделать, если аргументом передаются символы. Первый символ-аргумент должен стоять под индексом 0, второй символ-аргумент под индексом [^1], то есть последним (on 2:11pm, 11/6/2022)

// TODO-ENG: Write an overloaded static method. If two integers are passed as an argument to the method, then the result returns a reference to an integer array consisting of natural numbers, and the first and last number in the array is determined by the method arguments. For example, if you pass the numbers 2 and 4 as arguments, then the result will be an array of the numbers 2 , 3 and 4 . It also needs to be done if characters are passed as an argument. The first character argument must be at index 0, the second character argument at index [^1], that is, the last 

public class SelectedElementsInArray
{
    private static int[] SelectedElements(int a, int b)
    {
        var rnd = new Random();
        var array = new int[rnd.Next(3,11)];
        array[0] = a;
        array[^1] = b;
        for (var i = 1; i < array.Length - 1; i++) array[i] = rnd.Next(1, 827);
        return array;
    }

    private static char[] SelectedElements(char x, char y)
    {
        var rnd = new Random();
        var symbolsArray = new char[rnd.Next(3, 11)];
        symbolsArray[0] = x;
        symbolsArray[^1] = y;
        for (var i = 1; i < symbolsArray.Length - 1; i++) symbolsArray[i] = (char)(rnd.Next('A', 'Z'));
        return symbolsArray;
    }

    private static void Main()
    {
        Console.WriteLine("Integer array : ");
        int[] intArray = SelectedElements(1, 5);
        foreach (var k in intArray) Console.Write($"{k}, ");
        
        Console.WriteLine("\nSymbols array : ");
        char[] charArray = SelectedElements('a', 'z');
        foreach (var j in charArray) Console.Write($"{j}, ");
    }
}