namespace exercisesCSharp.easy.methods;

public class AverageValueOfArrayElements
{
    // TODO-RU: Написать программу со статическим методом, аргументом которому передается целочисчленный массива, а результатом возвращает среднее значение для элементов массива  (11/3/2022, 8:04AM)
    // TODO-ENG: Write a program with a static method that takes an integer array as an argument and returns the average value of the array elements as a result
    
    private static int Average(int[] array)
    {
        var result = 0;
        foreach (var t in array) result += t;
        return result / array.Length;
    }

    private static void Main()
    {
        int[] array = { 580, 387, 21, 293, 527 }; 
        Console.WriteLine($"Average value of array elements: {Average(array)}");
    }
}