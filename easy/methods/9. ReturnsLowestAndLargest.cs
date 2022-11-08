namespace exercisesCSharp.easy.methods;

// TODO-RU:  Напишите программу со статическим методом, аргументом которому передается произвольное количество целочисленных аргументов. Результатом метод возвращает массив из двух элементов: это значения наибольшего и наименьшего значений среди аргументов, переданных методу. (on 11/6/2022)

// TODO-ENG:  Write a program with a static method that takes an arbitrary number of integer arguments as an argument. As a result, the method returns an array of two elements: these are the values of the largest and smallest values among the arguments passed to the method. 

public class ReturnsLowestAndLargest
{
    private static IEnumerable<int> FindingTwoValue(params int[] numbers)
    {
        var array = new int[2];
        var largestValue = numbers[0];
        var lowestValue = numbers[0];

        // You can also use LINQ expression for finding largest and lowest value
        foreach (var t in numbers)
            if (t > largestValue)
                largestValue = t;

        // finding a lowest value
        foreach (var x in numbers)
            if (x < lowestValue)
                lowestValue = x;

        (array[0], array[1]) = (largestValue, lowestValue);
        
        return array;
    }

    private static void Main()
    {
        var rnd = new Random();
        var array = new int[rnd.Next(2, 15)];

        for (var i = 0; i < array.Length; i++) array[i] = rnd.Next(1, 788);
        foreach (var t in FindingTwoValue(array)) Console.Write($"{t}, ");
    }
}