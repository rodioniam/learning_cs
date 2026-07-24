namespace Learning_C_;

public static class Math_Operators
{
    public static void Test()
    {
        int a = 4;
        int b = 5;
        double c = 5;
        int d = 3;

        int result = a + b;
        int result2 = a * b;
        bool result3 = a > b;

        // с делением есть особенности
        double result4 = a / b;
        double result5 = a / c;
        // приведение типов
        double result6 = (double) a / b;

        // остаток от деления
        int result7 = a % d;

        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.WriteLine(result4);
        Console.WriteLine(result5);
        Console.WriteLine(result6);
        Console.WriteLine(result7);
    }
}