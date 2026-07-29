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
        int result = Sum(2, 5);

        Console.WriteLine(result);
    }
    
}