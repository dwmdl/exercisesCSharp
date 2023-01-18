namespace exercisesCSharp.medium.classes_and_objects;

public static class CosAndSin
{
    private static double Cosine(int x)
    {
        double secondPow = x * x;
        double fourthPow = secondPow * secondPow;

        double answer = 1 - secondPow / 2 + fourthPow / 24 - secondPow * fourthPow / 720 +
            fourthPow * fourthPow / 40320 - secondPow * fourthPow * fourthPow / 3628800;
        // 24, 720, 40320 etc. are factorials of 2,4,6

        return answer;
    }


    private static double SinusH(int x)
    {
        double thirdPow = x * x * x;
        double fifthPow = thirdPow * x * x;

        double answer = x + thirdPow / 6 + fifthPow / 120 + fifthPow * x * x / 5040 + thirdPow * fifthPow * x / 362880 +
                        fifthPow * fifthPow * x / 39916800;

        return answer;
    }

    private static double CosineH(int x)
    {
        double secondPow = x * x;
        double fourthPow = secondPow * secondPow;

        var answer = 1 + secondPow / 2 + fourthPow / 24 + secondPow * fourthPow / 720 +
                        fourthPow * fourthPow / 40320 + secondPow * fourthPow * fourthPow / 3628800;

        return answer;
    }


    private static void Main()
    {
        Console.WriteLine($"Cos(1) : {Cosine(1)}");
        Console.WriteLine($"SinH(2) : {SinusH(2)}");
        Console.WriteLine($"CosH(3) : {CosineH(3)}");
        
        // all this can be calculated using the class Math.Cos/Sin/Cosh/Sinh
        Console.WriteLine(Math.Cos(1));
        Console.WriteLine(Math.Sinh(2));
        Console.WriteLine(Math.Cosh(3));
    }
}