namespace Learning_C_;

// это класс
public static class Functions
{  
    // это метод класса, их может быть несколько
    public static int Sum(int a, int b)
    {
        int result = a + b;

        return result;
    }

    public static int Minus(int a, int b)
    {
        int result = a - b;

        return result;
    }

    // можно использовать функции и внутри самого класса
    public static void PrintResult()
    {   
        // теперь тут в зависимости от параметров внутри метода будет вызван подходящий
        int result = Sum(1, 1, 3);
        int result2 = Sum(3, 2);

        Console.WriteLine($"Version 1: {result}");
        Console.WriteLine($"Version 2: {result2}");
    }

    // перегрузка методов

    // у меня уже есть метод Sum, но я могу написать еще один с другим набором аргументов

    /// <summary>
    /// описание метода
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns>sum of a, b, c as int</returns>
    public static int Sum(int a, int b, int c)
    {
        int result = a + b + c;

        return result;
    }

    
    
}