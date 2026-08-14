namespace Learning_C_;


public static class Structures
{
    public static void Result()
    {
        ClassPoint classPoint = new();
        StructPoint structPoint = new();

        Func(classPoint);
        Func2(structPoint);
        // будет типичный результат для ссылочных и значимых типов
        classPoint.Print(); // тут была ссылка и значения присвоились
        structPoint.Print(); // тут было копирование и значения не вышли на пределы видимости метода

        ClassPoint classPoint1 = new() { X = 2, Y = 3};
        ClassPoint classPoint2 = new() { X = 2, Y = 3};

        bool EqualCheckClasses = classPoint1.Equals(classPoint2);

        StructPoint structPoint1 = new() { X = 2, Y = 3 };
        StructPoint structPoint2 = new() { X = 2, Y = 3 };

        bool EqualCheckStructures = structPoint1.Equals(structPoint2);

        Console.WriteLine($"\nClasses check result: {EqualCheckClasses}, Structures check result: {EqualCheckStructures}");
    }

    static void Func(ClassPoint classPoint)
    {
        classPoint.X++;
        classPoint.Y++;
    }

    static void Func2(StructPoint structPoint)
    {
        structPoint.X++;
        structPoint.Y++;
    }
}

public class ClassPoint
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine($"X: {X}\tY: {Y}");
    }
}

// в данном примере использование структуры гораздо лучше чем класс.
public struct StructPoint 
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine($"X: {X}\tY: {Y}");
    }
}

