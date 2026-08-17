using System.Numerics;

namespace Learning_C_;

public static class Generics
{
    public static void Result()
    {
        Basics.Basic();
        // MoreComplex.Complex();
    }
}

static class Basics
{
    public static void Basic()
    {
        int a = 10, b = 4;
        Console.WriteLine($"a = {a}\tb = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a = {a}\tb = {b}");

        Console.WriteLine();

        string str = "Hello", str2 = "World";
        Console.WriteLine($"string 1: {str}\tstring 2: {str2}");
        Swap(ref str, ref str2); // как можно заметить метод один и тот же но из-за использования generics он работает с любым типом данных
        Console.WriteLine($"string 1: {str}\tstring 2: {str2}");

        // при вызове такого метода нужно явно указать тип с которым он будет работать
        Func<int>();
    }

    static void Swap<T>(ref T a, ref T b) // так выглядит generic тип для методов, их может быть несколько
    {
        T temp = a;
        a = b;
        b = temp;
    }

    // данный метод не принимает параметры, но возвращает generic тип данных - сможет возвращать тот тип, который получил внутри
    static T Func<T>()
    {
        return default(T)!; // вернет default значение того типа, который придет в метод.
    }
}

static class MoreComplex
{
    public static void Complex()
    {
        List<int> list = new List<int>(); // при создании обобщенной коллекции используются обобщения 
    }
}